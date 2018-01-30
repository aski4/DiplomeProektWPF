using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using TweetSharp;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Net;
using HtmlAgilityPack;

namespace DiplomeProektWPF
{
    /// <summary>
    /// Interaction logic for LoginDialogWindow.xaml
    /// </summary>
    public partial class LoginDialogWindow : Window
    {

        private TwitterService service;
        OAuthRequestToken requestToken;

        public LoginDialogWindow()
        {
            InitializeComponent();
        }

        private void OpenAutorizePage()
        {
            const string consumerKey = "o4iyHtNojZ5Vrc9oqeRKLCPqJ";
            const string consumerSecret = "SMbH4Y4ekOU6F08K4Y0cWAGs89BAzUfNcN7Za5BujYe2ula9MA";

            service = new TwitterService(consumerKey, consumerSecret);
            requestToken = service.GetRequestToken();
            var uri = service.GetAuthorizationUri(requestToken);

            browser.Navigate(uri);


        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if (CheckForInternetConnection() == true)
            {
                OpenAutorizePage();
            }
            else
            {
                var mainWindowNoConnect = new MainWindow();
                mainWindowNoConnect.BdForCsh();
                mainWindowNoConnect.Show();
                Close();
            }
        }

        private void browser_LoadCompleted(object sender, System.Windows.Navigation.NavigationEventArgs e)
        {
            if (e.Uri.ToString() == "https://api.twitter.com/oauth/authorize")

            {

                var verifier = GetVerifierFromPage();

                var accessToken = service.GetAccessToken(requestToken, verifier);

                service.AuthenticateWith(accessToken.Token, accessToken.TokenSecret);

                var mainWindow = new MainWindow() { service = service};

                //mainWindow.LogInTwitter();
                mainWindow.FirstTweetData();
                //mainWindow.BdForCsh();
                mainWindow.Show();

                Close();

            }
        }
        private string GetVerifierFromPage()

        {

            dynamic doc = this.browser.Document;
            var html = doc.documentElement.innerHtml;

            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(html);
            var codeNode = htmlDoc.DocumentNode.SelectSingleNode("//code");
            return codeNode.InnerText;

        }

        public static bool CheckForInternetConnection()
        {
            try
            {
                using (var client = new WebClient())
                using (var stream = client.OpenRead("https://twitter.com/"))
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        //private void loginButton_Click(object sender, RoutedEventArgs e)
        //{
        //    this.DialogResult = true;
        //    this.Close();
        //}

        //public string Verifaer
        //{
        //    get
        //    {
        //        return this.TextBoxKey.Text;
        //    }
        //    set
        //    {
        //        this.TextBoxKey.Text = value;
        //    }
        //}
    }
}
