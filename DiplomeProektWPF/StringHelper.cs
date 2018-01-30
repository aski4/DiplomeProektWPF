using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomeProektWPF
{
    public static class StringHelper
    {
        public static string Cut(string cutTweetText, int cut)
        {
            if (cutTweetText != null)

                if (cutTweetText.Length > cut)

                    return cutTweetText.Remove(cut);

            return cutTweetText;

        }
    }
}
