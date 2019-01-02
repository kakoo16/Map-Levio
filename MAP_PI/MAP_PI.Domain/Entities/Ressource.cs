using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema; 

namespace MAP_PI.Domain.Entities
{
  //  [Table("Ressource")]
    public class Ressource : Person
    {
        [Key]
        public int RessourceId { get; set; }
        public string First_name { get; set; }
        public string Last_name { get; set; }
        public string Seniority { get; set; }
        public string Work_profil { get; set; }
        public float Note { get; set; }
        public string picture { get; set; }
        public string  Business_sector { get; set; }
        public float Salary { get; set; }
        public Boolean etat { get; set;  }
        public string  EtatResource  { get; set; }
        public string lang { get; set; }
        public string lat { get; set; }
        public string JobType { get; set; }
        public ContractType contract_Type { get; set; }
        public AvailibilityType availibity_type { get; set; }
        public StateType state_Type { get; set; }
        public virtual ICollection<DayOff> DayOFFs { get; set; }
        public virtual ICollection<Holiday> Holidays { get; set;  }
        public virtual ICollection<Mandate> Mandates { get; set; }
        public virtual ICollection<Skill> Skills { get; set; }
        //public virtual ICollection<Project> Projects { get; set; }
        public virtual ICollection<Request> Requests { get; set; }
        public virtual ICollection<Organizational_Chart> Organizational_Charts { get; set; }




        public virtual int ? SkiFk { get; set; } //type nullable
        public virtual int ? DaysoffFK { get; set; }
        public virtual int ? HolidayFk { get; set;  }
        //public virtual int ?  MandateFk { get; set;  }
        public virtual int ?  Organizational_ChartFk { get; set; }
        //public virtual int? ProjectFk { get; set; }
      
        public virtual Administrator MyAdminstrator { get; set; }




    }
}
