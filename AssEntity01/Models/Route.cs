﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssEntity01.Models
{
    internal class Route
    {
        public int Id { get; set; }
        public string Distance { get; set; }
        public string Destination { get; set; }
        public string Origin { get; set; }
        public string Classification { get; set; }
        public ICollection<AirCraftRoute> AirCraftRoute { get; set; } = new HashSet<AirCraftRoute>();

    }
}
