using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eMarket.Core.Entities
{
    public class News
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [MinLength(0)]
        [MaxLength(200)]
        public string Title { get; set; }
        [Required]
        [MinLength(10)]
        public int Description { get; set; }
        [Required]
        public DateTime Date { get; set; }
    }
}
