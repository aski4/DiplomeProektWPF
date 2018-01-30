using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomeProektWPF
{
    class HashTagsForBd
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string HashTags { get; set; }

        public virtual IList<TweetsForBd> Tweets { get; set; }
    }
}
