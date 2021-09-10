using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Models
{
    public class Skill
    {
        [Key]
        public int skillID { get; set; }
        public string skillName { get; set; }
    }
}
