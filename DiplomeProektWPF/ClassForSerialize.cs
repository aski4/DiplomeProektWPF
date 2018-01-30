using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomeProektWPF
{
    [Serializable]
    public class ClassForSerialize
    {
        public List<string> tweetsArray;

        public ClassForSerialize()
        {

        }

        public ClassForSerialize(string om)
        {
            tweetsArray = new List<string>();
        }

        public List<string> TweetsArray { get; set; }

    }
}
