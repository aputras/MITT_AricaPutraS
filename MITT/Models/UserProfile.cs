using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MITT.Models
{
    public class UserProfile
    {
        public string username { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public DateTime bod { get; set; }
        public string email { get; set; }

        [ForeignKey("username")]
        public virtual User User { get; set; }
    }
}
