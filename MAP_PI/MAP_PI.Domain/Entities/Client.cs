using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MAP_PI.Domain.Entities
{
    public class Client :Person
    {
        [Key]
        public int ClientId { get; set; }
        public ClientType client_Type { get; set; }
        public string nameClient { get; set; }
        public string logo { get; set; }
        public virtual ICollection<Request> ClientRequests { get; set; }

    }
}
