using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssEntity01.Models
{
    internal class AirCraft
    {
        public int Id { get; set; }
        public string Capacity { get; set; }
        public string Model { get; set; }
        public string Maj_Pilot { get; set; }
        public string Assistant { get; set; }
        public string Host1 { get; set; }
        public string Host2 { get; set; }
        [ForeignKey(nameof(AirLine))]
        public int? AirLineId { get; set; }
        public AirLine? AirLine { get; set; }
        public ICollection<AirCraftRoute> AirCraftRoute { get; set; } = new HashSet<AirCraftRoute>();
    }
}
