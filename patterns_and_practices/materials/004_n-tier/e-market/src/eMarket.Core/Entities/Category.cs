using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eMarket.Core.Entities
{
    public class Category
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [MinLength(0)]
        [MaxLength(100)]
        public string Name { get; set; }
        public virtual ICollection<Product> Products { get; set; } = new List<Product>();
    }
}
