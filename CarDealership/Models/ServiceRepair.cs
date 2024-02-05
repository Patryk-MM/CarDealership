using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CarDealership.Models {
    public class ServiceRepair {
        [Key]
        public int RepairID { get; set; }
        public int CarID { get; set; }
        public DateTime Date { get; set; }
        public string RepairDescription { get; set; }
    }
}
