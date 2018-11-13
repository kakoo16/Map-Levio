using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MAP_PI.Domain.Entities
{
    public class Inbox
    {
        [Key]    
        public int InboxId { get; set; }
        public string sender { get; set; }
        public virtual Person MyPerson { get; set; }
        public virtual ICollection<Message> Mymessages { get; set; }

    }
}
