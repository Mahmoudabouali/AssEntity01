using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssEntity01.Models
{
    internal class Transaction
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int Amount { get; set; }
        public DateOnly Date { get; set; }
        [ForeignKey(nameof(AirLine))]
        public int? AirLineId { get; set; }
        public AirLine? AirLine { get; set; }

    }
}
