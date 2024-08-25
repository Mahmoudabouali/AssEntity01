using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssEntity01.Models
{
    internal class AirLine
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Address { get; set; }
        public int Cont_Person { get; set; }

        public ICollection<AirCraft> AirCrafts { get; set; } = new HashSet<AirCraft>();
        public ICollection<Transaction> Transactions { get; set; } = new HashSet<Transaction>();
        public ICollection<Employee> Employees { get; set; } = new HashSet<Employee>();
        public ICollection<AirLinePhones> AirLinePhones { get; set; } = new HashSet<AirLinePhones>();
    }
}
