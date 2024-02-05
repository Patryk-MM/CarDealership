using CarDealership.Models;
using Microsoft.Identity.Client;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealership {
    public class Queries {
        public static Car? GetFirstCar(string brand) {
            using (Database db = new Database()) {
                Car? car = db.Cars?.FirstOrDefault(
                     p => p.Brand.Contains(brand));
                if (car == null) {
                    return null;
                }

                return car;

            }

        }

        public static List<string> GetCarBrands() {
            using (Database db = new Database()) {

                List<string>? brands = db.Cars?
                   .Select(p => p.Brand).Distinct().ToList();

                if (brands is null || !brands.Any()) {
                    return null;
                }

                return brands;
            }
        }

        public static List<string> GetCarModelsByBrand(string brand) {
            using (Database db = new Database()) {

                List<string>? models = db.Cars?
                   .Where(p => p.Brand == brand)
                   .Select(p => p.Model).Distinct().ToList();

                if (models is null || !models.Any()) {
                    return new List<string>();
                }

                return models;
            }
        }

        public static List<string> GetFuelTypes() {
            using (Database db = new Database()) {
                List<string>? brands = db.Cars?
                   .Select(p => p.FuelType).Distinct().ToList();

                if (brands is null || !brands.Any()) {
                    return null;
                }

                return brands;
            }
        }

        public static List<string> GetDrivetrainTypes() {
            using (Database db = new Database()) {
                List<string>? brands = db.Cars?
                   .Select(p => p.Drivetrain).Distinct().ToList();

                if (brands is null || !brands.Any()) {
                    return null;
                }

                return brands;
            }
        }

        public static List<string> GetTransmissionTypes() {
            using (Database db = new Database()) {
                List<string>? brands = db.Cars?
                   .Select(p => p.Transmission).Distinct().ToList();

                if (brands is null || !brands.Any()) {
                    return null;
                }

                return brands;
            }
        }

        public static List<string> GetBodyTypes() {
            using (Database db = new Database()) {
                List<string>? brands = db.Cars?
                   .Select(p => p.BodyType).Distinct().ToList();

                if (brands is null || !brands.Any()) {
                    return null;
                }

                return brands;
            }
        }

        public static List<string> GetColors() {
            using (Database db = new Database()) {
                List<string>? brands = db.Cars?
                   .Select(p => p.Color).Distinct().ToList();

                if (brands is null || !brands.Any()) {
                    return null;
                }

                return brands;
            }
        }

        public static List<string> GetSteeringWheelPosition() {
            using (Database db = new Database()) {
                List<string>? brands = db.Cars?
                   .Select(p => p.SteeringWheelPosition).Distinct().ToList();

                if (brands is null || !brands.Any()) {
                    return null;
                }

                return brands;
            }
        }

        public static List<string> GetCondition() {
            using (Database db = new Database()) {
                List<string>? brands = db.Cars?
                   .Select(p => p.TechnicalCondition).Distinct().ToList();

                if (brands is null || !brands.Any()) {
                    return null;
                }

                return brands;
            }
        }

        public static List<Car>? GetCarsByBrand(string brand) {
            using (Database db = new Database()) {
                List<Car>? cars = db.Cars?
                    .Where(p => p.Brand.Contains(brand))
                    .ToList();

                if (cars is null || !cars.Any()) {
                    return null;
                }

                return cars;
            }
        }

        public static Car? GetCarsByID(int id) {
            using (Database db = new Database()) {
                Car? car = db.Cars?
                    .FirstOrDefault(p => p.CarID == id);

                if (car is null) {
                    return null;
                }

                return car;
            }
        }

        public static BindingList<Insurance>? GetInsurancesByCarID(int id) {
            using (Database db = new Database()) {
                List<Insurance>? insurances = db.Insurances?
                    .Where(p => p.CarID == id)
                    .ToList();

                if (insurances is null) {
                    return null;
                }

                BindingList<Insurance> bindingInsurances = new BindingList<Insurance>(insurances);
                return bindingInsurances;
            }
        }

        public static List<Installment>? GetInstallmentsByInsuranceID(int id) {
            using (Database db = new Database()) {
                List<Installment>? installments = db.InsuranceInstallments?
                    .Where(p => p.InsuranceID == id)
                    .ToList();

                if (installments is null || !installments.Any()) {
                    return null;
                }

                return installments;
            }
        }

        public static BindingList<Reservation>? GetReservationsByCarID(int id) {
            using (Database db = new Database()) {
                List<Reservation>? meetings = db.Reservations?
                    .Where(p => p.CarID == id)
                    .ToList();
                if (meetings is null || !meetings.Any()) {
                    return null;
                }

                BindingList<Reservation> bindingMeetings = new BindingList<Reservation>(meetings);
                return bindingMeetings;
            }

        }

        public static List<ServiceRepair>? GetServicesRepairsByCarID(int id) {
            using (Database db = new Database()) {
                List<ServiceRepair>? repairs = db.ServicesRepairs?
                    .Where(p => p.CarID == id)
                    .ToList();
                if (repairs is null || !repairs.Any()) {
                    return null;
                }

                return repairs;
            }

        }

    }
}
