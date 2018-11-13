using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MAP_PI.Domain.Entities
{
   public  class Job_Request
    {
        [Key]
        public int Job_RequestId { get; set; }
        public StateType State_Type { get; set; }
        public DateTime Date_Request { get; set; }
        public string Speciality { get; set; }
        public virtual Candidat MyCandidat { get; set; }
    }
}
