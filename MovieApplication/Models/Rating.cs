using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApplication.Models
{
    public class Rating
    {
        public int id { get; set; }

        [Range(0,100)]
        public int RatingValue { get; set; }
        public int MovieId { get; set; }

        public Movie Movie { get
            {
                //TODO Make logic here
                return null;
            }
            }
    }
}
