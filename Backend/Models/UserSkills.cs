using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Models
{
    public class UserSkills
    {
        [Key]
        public string userSkillID { get; set; }
        public string username { get; set; }
        public int skillID { get; set; }
        public int skillLevelID { get; set; }

        [ForeignKey("username")]
        public virtual User User { get; set; }

        [ForeignKey("skillID")]
        public virtual Skill Skill { get; set; }

        [ForeignKey("skillLevelID")]
        public virtual SkillLevel SkillLevel { get; set; }
    }
}
