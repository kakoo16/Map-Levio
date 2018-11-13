using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace MAP_PI.Domain.Entities
{
    public class Organizational_Chart
    {
        [Key]
        public int ChartId { get; set; }
        public string directionnal_level { get; set; }
        public string program_Name { get; set; }
        public string project_responsable { get; set; }
        public string client_Name { get; set; }
        public string manager_account { get; set; }
        public string name_assignment_manager_client { get; set; }
        public virtual  ICollection<Ressource> ResourcesOrg { get; set; }
        public virtual ICollection<Project> MyProjectss { get; set; }
        public virtual ICollection<Client> MyClients { get; set; }

    }
}
