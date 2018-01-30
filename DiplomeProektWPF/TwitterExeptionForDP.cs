using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomeProektWPF
{
    class TwitterExeptionForDP : Exception
    {
        public TwitterExeptionForDP(string message)
            :base(message)
        {

        }
    }
}
