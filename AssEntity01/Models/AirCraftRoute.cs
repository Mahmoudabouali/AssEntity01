using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssEntity01.Models
{
    [PrimaryKey(nameof(AirCraftId),nameof(RouteId),nameof(Departure))]
    internal class AirCraftRoute
    {
        public int? AirCraftId { get; set; }
        public AirCraft? AirCraft { get; set; }
        public int? RouteId { get; set; }
        public Route? Route { get; set; }
        public string Departure { get; set; }
        public int numOfPass { get; set; }
        public int Price { get; set; }
        public int Arrival { get; set; }

    }
}
