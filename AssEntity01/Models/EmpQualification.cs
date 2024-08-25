using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssEntity01.Models
{
    [PrimaryKey(nameof(EmpId), nameof(Qualification))]
    internal class EmpQualification
    {
        public int EmpId { get; set; }
        public Employee? Employee { get; set; }
        public string Qualification { get; set; }
    }
}
