using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace MAP_PI.Domain.Entities
{
    public  class Request
    {
        [Key]
        public int RequestId { get; set; }
        public string requested_profil { get; set; }
        [DataType(DataType.Date)]
        public DateTime experience_year { get; set; }
        public string education_scolarity { get; set; }
        public string Manager { get; set; }
        [DataType(DataType.Date)]
        public DateTime deposit_hour { get; set; }
        [DataType(DataType.Date)]
        public DateTime deposit_Date { get; set; }
        [DataType(DataType.Date)]
        public DateTime start_date_mandate { get; set; }
        [DataType(DataType.Date)]
        public DateTime end_date_mandate { get; set; }
        public virtual Administrator MyAdmin { get; set; }
        public virtual Client MyClient { get; set; }
        public virtual Ressource MyResourcee { get; set; }


    }
}
