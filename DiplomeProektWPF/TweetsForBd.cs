using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomeProektWPF
{
    class TweetsForBd
    {
        public int Id { get; set; }

        [Required]
        public string Text { get; set; }

        public DateTime? TimeOfTweet { get; set; }

        public virtual TwitterUsersForBd User { get; set; }

        public virtual IList<HashTagsForBd> HashTags { get; set; }
    }
}
