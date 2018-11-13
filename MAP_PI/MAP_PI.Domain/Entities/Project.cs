using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MAP_PI.Domain.Entities
{
    public class Project
    {
        [Key]
        public int ProjectId { get; set; }
        public string project_name { get; set; }
        [DataType(DataType.Date)]
        public DateTime start_date { get; set; }
        [DataType(DataType.Date)]
        public DateTime end_date { get; set; }
        public Address addresse { get; set; }
        public int total_number_ressources { get; set; }
        public int levio_number_ressources { get; set; }
        public string picture { get; set; }

        public string category_type { get; set;  }
        public ProjectType project_type { get; set; }

        public virtual Client MyClient { get; set; }
        //public virtual Ressource MyResource { get; set; }
        public virtual Organizational_Chart MyOrgChart { get; set; }
        public virtual Skill SkillFk { get; set; }
        public virtual ICollection<Mandate> Mandates { get; set; }
    }
}
