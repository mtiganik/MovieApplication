using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApplication.Models
{
    public class Movie
    {
        public int id { get; set; }

        [MaxLength(70)]
        public string title { get; set; }

        [Range(1900, 2030)]
        public int year;

        public int rating { get
            {
                // TODO: 
                return 0;
            } }

        public int CategoryId { get
            {
                return Category.id;
            }
        }

        public Category Category { get; set; }
    }
}
