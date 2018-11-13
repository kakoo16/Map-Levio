using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace MAP_PI.Domain.Entities
{
    public class Candidat :Person
    {
        [Key]
        public int CandidatId { get; set; }
        //public virtual Job_Request MyJobRequest { get; set; }
    }
}
