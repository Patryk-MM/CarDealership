using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealership.Models {
    public class Insurance {
        public int InsuranceID { get; set; }
        public int CarID { get; set; }
        public string InsuranceNumber { get; set; }
        public string InsuranceType {  get; set; }
        public string Insurer {  get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int InstallmentCount { get; set; }
    }
}
