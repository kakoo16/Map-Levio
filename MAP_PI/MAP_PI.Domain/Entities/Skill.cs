using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace MAP_PI.Domain.Entities
{
    public class Skill
    {
        [Key]
        public int SkillId { get; set; }
        public string name_Skill { get; set; }
        public string  description_Skill  { get; set; }
        public float rate_Skill { get; set; }

        public virtual Ressource MyResource { get; set; }
    }
}
