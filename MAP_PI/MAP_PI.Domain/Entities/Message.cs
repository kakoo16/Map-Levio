using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MAP_PI.Domain.Entities
{
   public  class Message
    {
        [Key]
        public int MessageId { get; set; }
        public string Message_object { get; set; }
        public string Message_content { get; set; }
        [DataType(DataType.Date)]
        public DateTime DateDebutMessage { get; set; }
        [DataType(DataType.Date)]
        public DateTime DateFinMessage { get; set; }
        [DataType(DataType.Currency)]
        public float Cost { get; set; }

        public Boolean EtatMessage { get; set; }

        public DateTime Date_message { get; set; }
        public virtual ICollection<Inbox> Inboxs { get; set; }
        public virtual Ressource RessourceMsgFK { get; set; }



    }
}
