using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomeProektWPF
{
    class TrendsForBd
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Trends { get; set; }
    }
}
