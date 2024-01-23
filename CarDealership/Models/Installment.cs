using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealership.Models
{
    public class Installment
    {
        public int InstallmentID { get; set; }
        public int InsuranceID { get; set; }
        public DateTime InstallmentDate { get; set; }
    }
}
