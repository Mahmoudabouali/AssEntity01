using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssEntity01.Models
{
    [PrimaryKey(nameof(AirLineId),nameof(Phones))]
    internal class AirLinePhones
    {
        public int? AirLineId { get; set; }
        public AirLine? AirLine { get; set; }
        public int Phones { get; set; }
    }
}
