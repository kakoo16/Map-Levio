using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema; 


namespace MAP_PI.Domain.Entities
{
    public class Administrator :Person
    {
        [Key]
        public int AdministratorId { get; set; }
        public virtual ICollection<Message> MyMessages { get; set; }
        public virtual ICollection<Request> MyRequests { get; set; }
    }
}
