using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using TweetSharp;

namespace DiplomeProektWPF
{
    public static class NavigationService 
    {
        public static string NaviString { get; set; }

        private static readonly Regex RE_URL = new Regex("#[\\w-]+[\\d-]*");

        public static readonly DependencyProperty TextProperty = DependencyProperty.RegisterAttached(
            "Text",
            typeof(string),
            typeof(NavigationService),
            new PropertyMetadata(null, OnTextChanged)
        );

        public static string GetText(DependencyObject d)
        { return d.GetValue(TextProperty) as string; }

        public static void SetText(DependencyObject d, string value)
        { d.SetValue(TextProperty, value); }

        private static void OnTextChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var text_block = d as TextBlock;
            if (text_block == null)
                return;

            text_block.Inlines.Clear();

            var new_text = (string)e.NewValue;
            if (string.IsNullOrEmpty(new_text))
                return;

            // Find all URLs using a regular expression
            int last_pos = 0;
            foreach (Match match in RE_URL.Matches(new_text))
            {
                // Copy raw string from the last position up to the match
                if (match.Index != last_pos)
                {
                    var raw_text = new_text.Substring(last_pos, match.Index - last_pos);
                    text_block.Inlines.Add(new Run(raw_text));
                }

                // Create a hyperlink for the match
                var link = new Hyperlink(new Run(match.Value))
                {
                    DataContext = match.Value
                };
                link.Click += OnUrlClick;
                
                text_block.Inlines.Add(link);

                // Update the last matched position
                last_pos = match.Index + match.Length;
            }

            // Finally, copy the remainder of the string
            if (last_pos < new_text.Length)
                text_block.Inlines.Add(new Run(new_text.Substring(last_pos)));
        }

        private static void OnUrlClick(object sender, RoutedEventArgs e)
        {
            var link = (Hyperlink)sender;
            // Do something with link.NavigateUri like:
            var tb = (Hyperlink)e.OriginalSource;
            string cuts = tb.DataContext.ToString();
            NaviString = cuts;
                
        }
        


    }
}
