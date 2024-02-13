using CarDealership.Models;
using CsvHelper.Configuration;
using CsvHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarDealership.UserControls {
    public partial class UC_Cars : UserControl {

        public List<string> carBrands = Queries.GetCarBrands();
        public List<Car> cars = new List<Car>();
        public List<ComboBox> filterBoxes = new List<ComboBox>();
        public UC_Cars() {
            InitializeComponent();
            //Adding all comboboxes to a list for clearing button
            filterBoxes = FindControls<ComboBox>(this);
            //Filling filter comboboxes with options
            brandComboBox.DataSource = carBrands;
            brandComboBox.SelectedItem = null;
            fuelComboBox.DataSource = Queries.GetFuelTypes();
            fuelComboBox.SelectedItem = null;
            drivetrainComboBox.DataSource = Queries.GetDrivetrainTypes();
            drivetrainComboBox.SelectedItem = null;
            transmissionComboBox.DataSource = Queries.GetTransmissionTypes();
            transmissionComboBox.SelectedItem = null;
            colorComboBox.DataSource = Queries.GetColors();
            colorComboBox.SelectedItem = null;
            steeringWheelComboBox.DataSource = Queries.GetSteeringWheelPosition();
            steeringWheelComboBox.SelectedItem = null;
            conditionComboBox.DataSource = Queries.GetCondition();
            conditionComboBox.SelectedItem = null;
            //Fetching data for dataGrid
            reloadGrid();
            carsDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

        }

        public void reloadGrid() {
            cars = Queries.GetCarsByBrand("");
            carsDataGrid.DataSource = cars;
        }

        //Returns all the controls of specific type to a list
        public List<T> FindControls<T>(Control control) where T : Control {
            var controls = control.Controls.Cast<Control>();
            return controls.SelectMany(ctrl => FindControls<T>(ctrl))
                .Concat(controls)
                .Where(c => c.GetType() == typeof(T))
                .Cast<T>()
                .ToList();
        }

        private void brandComboBox_SelectedValueChanged(object sender, EventArgs e) {
            try {
                modelComboBox.DataSource = Queries.GetCarModelsByBrand(brandComboBox.SelectedValue.ToString());
            } catch (Exception) { modelComboBox.DataSource = null; }
            modelComboBox.SelectedItem = null;
        }

        //Swapping ComboBox values if necessary
        private void SwapComboBoxValues(ComboBox comboBox1, ComboBox comboBox2) {
            if (comboBox1.SelectedItem == null || comboBox2.SelectedItem == null) return;

            double value1, value2;
            if (!double.TryParse(comboBox1.SelectedItem.ToString(), out value1) || !double.TryParse(comboBox2.SelectedItem.ToString(), out value2))
                return;

            if (value1 > value2) {
                var temp = comboBox2.SelectedItem;
                comboBox2.SelectedItem = comboBox1.SelectedItem;
                comboBox1.SelectedItem = temp;
            }
        }

        private void yearComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            SwapComboBoxValues(yearFromComboBox, yearToComboBox);
        }

        private void engCapComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            SwapComboBoxValues(engCapFromComboBox, engCapToComboBox);
        }
        private void mileageComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            SwapComboBoxValues(mileageFromComboBox, mileageToComboBox);
        }

        private void engPowComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            SwapComboBoxValues(engPowFromComboBox, engPowToComboBox);
        }


        private void filterButton_Click(object sender, EventArgs e) {
            carsDataGrid.DataSource = HandleCarFilters(
                brand: brandComboBox.Text,
                model: modelComboBox.Text,
                startYear: yearFromComboBox.Text,
                endYear: yearToComboBox.Text,
                engCapFrom: engCapFromComboBox.Text,
                engCapTo: engCapToComboBox.Text,
                mileageFrom: mileageFromComboBox.Text,
                mileageTo: mileageToComboBox.Text,
                engPowFrom: engPowFromComboBox.Text,
                engPowTo: engPowToComboBox.Text,
                fuel: fuelComboBox.Text,
                drivetrain: drivetrainComboBox.Text,
                transmission: transmissionComboBox.Text,
                bodyType: bodyTypeComboBox.Text,
                color: colorComboBox.Text,
                steeringWheel: steeringWheelComboBox.Text,
                condition: conditionComboBox.Text);
        }



        private void carsDataGrid_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e) {
            CarDetailsForm cd = new CarDetailsForm((int)carsDataGrid.CurrentRow.Cells[0].Value);
            cd.Show();
        }

        private void clearFilters_Click(object sender, EventArgs e) {
            foreach (var box in filterBoxes) {
                box.Text = null;
            }
            reloadGrid();
        }

        public List<Car>? HandleCarFilters(string brand, string model, string startYear, string endYear, string engCapFrom,
            string engCapTo, string mileageFrom, string mileageTo, string engPowFrom, string engPowTo, string fuel, string drivetrain, string transmission, string bodyType, string color, string steeringWheel, string condition) {
            var filteredCars = cars;

            if (!string.IsNullOrEmpty(brand)) {
                filteredCars = filteredCars.Where(x => x.Brand.ToLower().Contains(brand.ToLower())).ToList();
            }

            if (!string.IsNullOrEmpty(model)) {
                filteredCars = filteredCars.Where(x => x.Model.ToLower().Contains(model.ToLower())).ToList();
            }

            if (!string.IsNullOrEmpty(startYear) && !string.IsNullOrEmpty(endYear))
                filteredCars = filteredCars.Where(x => x.ProductionYear >= Convert.ToInt32(startYear) && x.ProductionYear <= Convert.ToInt32(endYear)).ToList();
            else if (!string.IsNullOrEmpty(startYear)) {
                filteredCars = filteredCars.Where(x => x.ProductionYear >= Convert.ToInt32(startYear)).ToList();
            } else if (!string.IsNullOrEmpty(endYear)) {
                filteredCars = filteredCars.Where(x => x.ProductionYear <= Convert.ToInt32(endYear)).ToList();
            }


            if (!string.IsNullOrEmpty(engCapFrom) && !string.IsNullOrEmpty(engCapTo)) {
                filteredCars = filteredCars.Where(x => x.EngineCapacity >= Convert.ToInt32(engCapFrom) && x.EngineCapacity <= Convert.ToInt32(engCapTo)).ToList();
            } else if (!string.IsNullOrEmpty(engCapFrom)) {
                filteredCars = filteredCars.Where(x => x.EngineCapacity >= Convert.ToInt32(engCapFrom)).ToList();
            } else if (!string.IsNullOrEmpty(engCapTo)) {
                filteredCars = filteredCars.Where(x => x.EngineCapacity <= Convert.ToInt32(engCapTo)).ToList();
            }

            if (!string.IsNullOrEmpty(mileageFrom) && !string.IsNullOrEmpty(mileageTo)) {
                filteredCars = filteredCars.Where(x => x.Mileage >= Convert.ToInt32(mileageFrom) && x.Mileage <= Convert.ToInt32(mileageTo)).ToList();
            } else if (!string.IsNullOrEmpty(mileageFrom)) {
                filteredCars = filteredCars.Where(x => x.Mileage >= Convert.ToInt32(mileageFrom)).ToList();
            } else if (!string.IsNullOrEmpty(mileageTo)) {
                filteredCars = filteredCars.Where(x => x.Mileage <= Convert.ToInt32(mileageTo)).ToList();
            }

            if (!string.IsNullOrEmpty(engPowFrom) && !string.IsNullOrEmpty(engPowTo)) {
                filteredCars = filteredCars.Where(x => x.Power >= Convert.ToInt32(engPowFrom) && x.Power <= Convert.ToInt32(engPowTo)).ToList();
            } else if (!string.IsNullOrEmpty(engPowFrom)) {
                filteredCars = filteredCars.Where(x => x.Power >= Convert.ToInt32(engPowFrom)).ToList();
            } else if (!string.IsNullOrEmpty(engPowTo)) {
                filteredCars = filteredCars.Where(x => x.Power <= Convert.ToInt32(engPowTo)).ToList();
            }

            if (!string.IsNullOrEmpty(fuel)) {
                filteredCars = filteredCars.Where(x => x.FuelType.ToLower().Contains(fuel.ToLower())).ToList();
            }

            if (!string.IsNullOrEmpty(drivetrain)) {
                filteredCars = filteredCars.Where(x => x.Drivetrain.ToLower().Contains(drivetrain.ToLower())).ToList();
            }

            if (!string.IsNullOrEmpty(transmission)) {
                filteredCars = filteredCars.Where(x => x.Transmission.ToLower().Contains(transmission.ToLower())).ToList();
            }

            if (!string.IsNullOrEmpty(bodyType)) {
                filteredCars = filteredCars.Where(x => x.BodyType.ToLower().Contains(bodyType.ToLower())).ToList();
            }

            if (!string.IsNullOrEmpty(color)) {
                filteredCars = filteredCars.Where(x => x.Color.ToLower().Contains(color.ToLower())).ToList();
            }

            if (!string.IsNullOrEmpty(steeringWheel)) {
                filteredCars = filteredCars.Where(x => x.SteeringWheelPosition.ToLower().Contains(steeringWheel.ToLower())).ToList();
            }

            if (!string.IsNullOrEmpty(condition)) {
                filteredCars = filteredCars.Where(x => x.TechnicalCondition.ToLower().Equals(condition.ToLower())).ToList();
            }

            return filteredCars;
        }

        private void carsDataGrid_DataSourceChanged(object sender, EventArgs e) {
            resultLabel.Text = $"Result ({carsDataGrid.RowCount} entries)";
        }

        private void addCarButton_Click(object sender, EventArgs e) {
            NewCarForm nc = new NewCarForm();
            nc.Show();
        }

        private void removeCarButton_Click(object sender, EventArgs e) {
            var selected = carsDataGrid.SelectedRows;
            if (selected.Count <= 0) {
                MessageBox.Show("No records selected.");
                return;
            }

            var confirmResult = MessageBox.Show("Are you sure to delete this item?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes) {
                List<int> list = new();
                for (int i = 0; i < selected.Count; i++) {
                    list.Add(Convert.ToInt32(selected[i].Cells[0].Value));
                }
                using (Database db = new Database()) {
                    foreach (int i in list) {
                        db.Remove(Queries.GetCarsByID(i));
                    }
                    db.SaveChanges();
                    MessageBox.Show("Records have been deleted.");
                    reloadGrid();
                }
            } else { return; }
        }

        private void refreshPicture_Click(object sender, EventArgs e) {
            reloadGrid();
        }

        private void refreshPicture_MouseHover(object sender, EventArgs e) {
            //MessageBox.Show($"{refreshPicture.BackColor.ToString()}");
            refreshPicture.BackColor = Color.MediumSlateBlue;

        }

        private void refreshPicture_MouseLeave(object sender, EventArgs e) {
            refreshPicture.BackColor = Color.Transparent;

        }

        private void refreshPicture_MouseDown(object sender, MouseEventArgs e) {
            refreshPicture.BackColor = Color.Transparent;
        }

        private void exportButton_Click(object sender, EventArgs e) {
            var selected = carsDataGrid.SelectedRows;
            if (selected.Count <= 0) {
                MessageBox.Show("No records selected.");
                return;
            }

            var confirmResult = MessageBox.Show("Are you sure to export selected items to CSV file?", "Confirm Export", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes) {
                List<Car> list = new();
                for (int i = 0; i < selected.Count; i++) {
                    list.Add(Queries.GetCarsByID(Convert.ToInt32(selected[i].Cells[0].Value)));
                }
                using (OpenFileDialog openFileDialog = new OpenFileDialog()) {
                    openFileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
                    openFileDialog.FilterIndex = 1;
                    openFileDialog.RestoreDirectory = true;
                    var config = new CsvConfiguration(CultureInfo.InvariantCulture) {
                        HeaderValidated = null,
                        MissingFieldFound = null
                    };

                    if (openFileDialog.ShowDialog() == DialogResult.OK) {
                        try {
                            using (StreamWriter writer = new StreamWriter(openFileDialog.FileName)) {
                                using (CsvWriter csv = new CsvWriter(writer, config)) {
                                    csv.WriteRecords(list);
                                }
                            }
                        } catch (Exception ex) { MessageBox.Show($"{ex.Message}"); }
                    }
                }
            } else { return; }
        }

        private void importButton_Click(object sender, EventArgs e) {
            using (OpenFileDialog openFileDialog = new OpenFileDialog()) {
                openFileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;
                var config = new CsvConfiguration(CultureInfo.InvariantCulture) {
                    HeaderValidated = null,
                    MissingFieldFound = null
                };
                if (openFileDialog.ShowDialog() == DialogResult.OK) {

                    try {
                        using (StreamReader reader = new StreamReader(openFileDialog.FileName)) {
                            using (CsvReader csv = new CsvReader(reader, config)) {
                                var records = csv.GetRecords<Car>().ToList();
                                var confirmResult = MessageBox.Show($"There are {records.Count()} records in the CSV file. Are you sure to import them?", "Confirm Import", MessageBoxButtons.YesNo);
                                if (confirmResult == DialogResult.Yes) {
                                    using (Database db = new Database()) {
                                        foreach (var record in records) {
                                            record.CarID = 0;
                                            db.Add(record);
                                        }
                                        db.SaveChanges();
                                    }
                                } else { return; }
                            }

                        }
                    } catch (Exception ex) { MessageBox.Show($"{ex.Message}"); }
                }
            }
        }
    }
}
