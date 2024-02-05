using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace CarDealership.Models {
    public class Reservation {
        public int ReservationID { get; set; }
        public int CarID { get; set; }
        public int ClientID{ get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
