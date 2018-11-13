using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace MAP_PI.Domain.Entities
{
    public class Mandate
    {
        [Key, Column(Order = 0)]
        public int ProjectId { get; set; }

        [Key, Column(Order = 1)]
        public string Id { get; set; }

        [DataType(DataType.Date)]
        [Key, Column(Order = 2)]
        public DateTime start_Date { get; set; }

        [DataType(DataType.Date)]
        [Key, Column(Order = 3)]
        public DateTime end_Date { get; set; }

        public Double Fees { get; set; }
        public virtual Project ProFk { get; set; }
        public virtual Person ResFk { get; set; }
        //public virtual ICollection<Ressource> Ressourcess { get; set; }
        //public virtual ICollection<Project> Projets { get; set; }

    }
}
