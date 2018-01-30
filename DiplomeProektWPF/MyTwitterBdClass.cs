using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;

namespace DiplomeProektWPF
{
    class MyTwitterBdClass : DbContext
    {
        public DbSet<TweetsForBd> Tweets { get; set; }
        public DbSet<HashTagsForBd> HashTags { get; set; }
        public DbSet<FollowersFriendsForBd> FFC { get; set; }
        public DbSet<TwitterUsersForBd> Users { get; set; }
        public DbSet<TrendsForBd> Trends { get; set; }
    }
}
