using CarDealership.Models;
using Microsoft.Identity.Client;
using System;
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

        public static Insurance? GetInsuranceByCarID(int id) {
            using (Database db = new Database()) {
                Insurance? insurance = db.Insurances?
                    .FirstOrDefault(i => i.CarID == id);

                if (insurance is null) {
                    return null;
                }

                return insurance;
            }
        }

        public static List<Installment>? GetInstallmentsByInsuranceID(int id) {
            using (Database db = new Database()) {
                List<Installment>? installments = db.InsuranceInstallments?
                    .Where(i => i.InsuranceID == id)
                    .ToList();

                if (installments is null || !installments.Any()) {
                    return null;
                }

                return installments;
            }
        }
    }
}
