using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eMarket.Core.Entities
{
    public class User : IdentityUser
    {
        //[Required]
        //[MaxLength(100)]
        public string FirstName { get; set; }
        //[Required]
        //[MaxLength(100)]
        public string LastName { get; set; }
        //[Required]
        public DateTime JoinDate { get; set; }
    }
}
