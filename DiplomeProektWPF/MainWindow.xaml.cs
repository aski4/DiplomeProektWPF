using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Resources;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Serialization;
using System.IO;
using TweetSharp;
using System.Net;
using System.Data.SqlClient;
using System.Windows.Markup;
using System.Xml;
using System.ComponentModel;

namespace DiplomeProektWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window 
    {
        private List<TwitterStatus> testTweet;
        private List<TwitterStatus> newList;
        private List<TwitterTrend> newListTrend;
        
        private static string findTextBox = null;
        static int count = 0;
        static long IdNum = 0;
        

        public TwitterService service { get; set; }
        public static string searchStringFromNavi { get; set; }
       

        public MainWindow()
        {
            InitializeComponent();
            MouseMove += MainWindow_MouseMove;
        }

        private void MainWindow_MouseMove(object sender, MouseEventArgs e)
        {
            if (NavigationService.NaviString != null)
            {
                SearchHashTag(NavigationService.NaviString);
                NavigationService.NaviString = null;
            }
        }

        public void FirstTweetData()
        {
            testTweet = service.ListTweetsOnHomeTimeline(new ListTweetsOnHomeTimelineOptions { Count = 50 }).ToList();
            IdNum = testTweet.Last().Id;
            AddToBdTweet();
            GetTweetData();
            TrendsSearch();
            LogInTwitter();
        }

        public void GetTweetData()
        {
            newList = TweetTenPage();
            DataForMainPage();
            
        }
        
        public List<TwitterStatus> TweetTenPage()
        {
            return testTweet.Skip(count).Take(5).ToList();
        }

        public List<TwitterStatus> TweetForMainPage()
        {
            return service.ListTweetsOnHomeTimeline(new ListTweetsOnHomeTimelineOptions { MaxId = IdNum, Count = 50 }).ToList();
        }

        public void DataForMainPage()
        {
            itemControlTweets.ItemsSource = newList;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            count += 5;
            if (count < testTweet.Count)
            {   
                newList = TweetTenPage();
                DataForMainPage();
            }
            else
            {
                IdNum -= 1;
                testTweet = TweetForMainPage();
                count = 0;
                newList = TweetTenPage();
                DataForMainPage();
            }
        }

        private void AddToBdTweet()
        {
            using (var bd = new MyTwitterBdClass())
            {
                var dbListTweets = bd.Tweets.Select(t => t.Text).ToList();
                var dbListUsers = bd.Users.Select(t => t.Name).ToList();

                foreach ( var tweet in testTweet)
                {
                    if (dbListTweets.IndexOf(tweet.Text) < 0)
                    {
                        var UserIN = new TwitterUsersForBd { Name = tweet.User.Name, FullName = tweet.User.Name, ScreenName = tweet.User.ScreenName };
                        var tweetIN = new TweetsForBd { Text = tweet.Text, TimeOfTweet = tweet.CreatedDate };
                        var FFCIN = new FollowersFriendsForBd { Followers = tweet.User.FollowersCount, Friends = tweet.User.FriendsCount };
                        if (dbListUsers.IndexOf(tweet.User.Name) < 0)
                        {
                            dbListUsers.Add(tweet.User.Name);
                            bd.Users.Add(UserIN);
                            bd.SaveChanges();
                            var UserFromBdFirst = bd.Users.Where(a => a.Name == tweet.User.Name).Single();
                            UserFromBdFirst.Tweets.Add(tweetIN);
                            UserFromBdFirst.FFC.Add(FFCIN);
                            bd.SaveChanges();
                        }
                        else
                        {
                            var UserFromBd = bd.Users.Where(a => a.Name == tweet.User.Name).Single();
                            UserFromBd.Tweets.Add(tweetIN);
                            UserFromBd.FFC.Add(FFCIN);
                            bd.SaveChanges();
                        }
                    }
                }
            }
        }
        
        public void BdForCsh()
        {
            using (var bd = new MyTwitterBdClass())
            {
                
                var ListTop50 = bd.Tweets.Select(t => new TwitterStatus
                {
                    Text = t.Text,
                    CreatedDate = t.TimeOfTweet.Value,
                    User = new TwitterUser { Name = t.User.FullName, ScreenName = t.User.ScreenName}
                }).OrderByDescending(x => x.CreatedDate).Take(50).ToList();
                
                testTweet = ListTop50;
                newList = TweetTenPage();
                DataForMainPage();
            }
        }

        public void SearchUser(string e)
        {
            count = 0;
            testTweet = service.ListTweetsOnUserTimeline(new ListTweetsOnUserTimelineOptions() { ScreenName = e, Count = 50 }).ToList();
            GetTweetData();
        }

        public void SearchHashTag(string e)
        {
            count = 0;
            testTweet = service.Search(new SearchOptions() { Q = e, Count = 50 }).Statuses.ToList();
            GetTweetData();
        }

        private void RunINeed_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            var run = (Run)e.OriginalSource;
            SearchUser(run.Text);
        }

        private void HomeButton_Click(object sender, RoutedEventArgs e)
        {
            count = 0;
            FirstTweetData();
        }

        private void TrendsSearch()
        {
            newListTrend = service.ListLocalTrendsFor(new ListLocalTrendsForOptions { Id = 1 }).OrderBy(x => x.Name).Take(10).ToList();
            TrendList.ItemsSource = newListTrend;
        }

        public async void LogInTwitter()
        {
            string profileName;

            VerifyCredentialsOptions option = new VerifyCredentialsOptions();
            TwitterUser profile = service.VerifyCredentials(option);
            try
            {
                profileName = profile.Name;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                throw new TwitterExeptionForDP(e.Message);
            }

            var imageProfileUrl = Task.Run(() => GetUserImageUrlTask());
            string imageStringForTask = await imageProfileUrl;
            ProfileImageMain.Source = new BitmapImage(new Uri(imageStringForTask));
            FollowersTextBlockCount.Text = profile.FollowersCount.ToString();
            FollowingTextBlockCount.Text = profile.FriendsCount.ToString();
            ProfileTextBlockName.Text = profile.Name;
            RunNameHyperLink.Text = profile.ScreenName;
            
               
        }
        
        private string GetUserImageUrlTask()
        {
            return service.GetUserProfile(new GetUserProfileOptions()).ProfileImageUrl;
        }
        
        
        private void FindButton_Click(object sender, RoutedEventArgs e)
        {
            if (findTextBox != null && findTextBox.StartsWith("@"))
            {
                SearchUser(findTextBox);
            }
            if (findTextBox != null && findTextBox.StartsWith("#"))
            {
                SearchHashTag(findTextBox);
                
            }

        }

        private void inputText_TextChanged(object sender, TextChangedEventArgs e)
        {
            var tb = (TextBox)e.OriginalSource;
            findTextBox = tb.Text;
        }

        private void Run_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            var tb = (Run)e.OriginalSource;
            SearchHashTag(tb.Text);
        }

        private void TweetsUserImage_Loaded(object sender, RoutedEventArgs e)
        {
            var tb = (Image)e.OriginalSource;
            tb.Source = new BitmapImage(new Uri(tb.Tag.ToString()));
        }
    }

}
