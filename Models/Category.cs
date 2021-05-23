using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace rema.Models
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }
        public string Names { get; set; }
        public string Description { get; set; }
    }
}