using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Models
{
    public class SkillLevel
    {
        [Key]
        public int skillLevelID { get; set; }

        public string skillLevelName { get; set; }
    }
}
