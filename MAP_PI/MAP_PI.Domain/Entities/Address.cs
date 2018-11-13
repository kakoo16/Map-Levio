using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema; 



namespace MAP_PI.Domain.Entities
{
   public  class Address
    {
        [Key]
        public int AddressId { get; set; }
        public string city { get; set; }
        public string postal_Code { get; set; }
        public string country { get; set; }
    }
}
