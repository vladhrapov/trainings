using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eMarket.Core.Entities
{
    public class Product
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        [Range(0, double.MaxValue)]
        public double Price { get; set; }
        [Range(0, int.MaxValue)]
        public int Quantity { get; set; }

        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}
