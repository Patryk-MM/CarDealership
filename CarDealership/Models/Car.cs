using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace CarDealership.Models
{
    public class Car
    {
        public int CarID { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int ProductionYear { get; set; }
        public decimal EngineCapacity { get; set; }
        public int Power {  get; set; }
        public int Mileage { get; set; }
        public string FuelType { get; set; }
        public string Drivetrain {  get; set; }
        public string Transmission { get; set; }
        public string BodyType { get; set; }
        public string Color { get; set; }
        public string SteeringWheelPosition { get; set; }
        public string TechnicalCondition {  get; set; }
        public int DealershipID { get; set; }
    }
}
