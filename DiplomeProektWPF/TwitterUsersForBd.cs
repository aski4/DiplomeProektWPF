using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomeProektWPF
{
    class TwitterUsersForBd
    {
        public TwitterUsersForBd()
        {
            this.Tweets = new List<TweetsForBd>();
            this.FFC = new List<FollowersFriendsForBd>();
        }

        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [MaxLength(50)]
        public string FullName { get; set; }

        [MaxLength(50)]
        public string ScreenName { get; set; }

        public virtual IList<TweetsForBd> Tweets { get; set; }
        public virtual IList<FollowersFriendsForBd> FFC { get; set; }
    }
}
