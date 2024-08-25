using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssEntity01.Models
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Address { get; set; }
        public string Gender { get; set; }
        public string Position { get; set; }
        public DateTime date { get; set; }
        [ForeignKey(nameof(AirLine))]
        public int? AirLineId { get; set; }
        public AirLine? AirLine { get; set; }
        public ICollection<EmpQualification> EmpQualifications { get; set; } = new HashSet<EmpQualification>();
    }
}
