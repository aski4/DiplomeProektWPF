using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TweetSharp;

namespace DiplomeProektWPF
{
    class TweetsTextConsole
    {
        public const int cutKey = 140;
        string text;
        public List<string> trends;
        public List<string> tweets;
      

        public TweetsTextConsole()
        {
            trends = new List<string>();
            tweets = new List<string>();
        }

        public TweetsTextConsole(string t)
        {
            this.text = StringHelper.Cut(text, cutKey);
        }

        public string T
        {
            get
            {
                return this.text;
            }
            set
            {
                this.text = value;
            }
        }

        public void CycleOne()
        {

        }

        public override string ToString()
        {
            return this.text;
        }

        public List<string> Trends
        {
            get { return this.trends; }
        }

        public List<string> Tweets
        {
            get { return this.tweets; }
            set { this.tweets = value; }
        }
    }
}
