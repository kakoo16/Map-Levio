using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MAP_PI.Domain.Entities
{
    public class DayOff
    {
        [Key]
        public int DayoffId { get; set; }
        public DateTime start_Date { get; set; }
        public DateTime end_Date { get; set; }
        public string raison { get; set; }
    }
}
