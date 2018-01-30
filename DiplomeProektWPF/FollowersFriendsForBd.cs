using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomeProektWPF
{
    class FollowersFriendsForBd
    {
        public int Id { get; set; }


        public int? Followers { get; set; }

        public int? Friends { get; set; }

        public virtual TwitterUsersForBd User { get; set; }
    }
}
