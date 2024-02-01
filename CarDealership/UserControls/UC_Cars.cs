using CarDealership.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            cars = Queries.GetCarsByBrand("");
            carsDataGrid.DataSource = cars;
            carsDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

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

        //These two swap year values if the starting year is higher than the ending year.
        private void yearToComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            if (yearFromComboBox.SelectedItem == null || yearToComboBox.SelectedItem == null) return;
            if (Convert.ToInt32(yearFromComboBox.SelectedItem) > Convert.ToInt32(yearToComboBox.SelectedItem)) {
                var temp = yearToComboBox.SelectedItem;
                yearToComboBox.SelectedItem = yearFromComboBox.SelectedItem;
                yearFromComboBox.SelectedItem = temp;
            }
        }

        private void yearFromComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            if (yearFromComboBox.SelectedItem == null || yearToComboBox.SelectedItem == null) return;
            if (Convert.ToInt32(yearFromComboBox.SelectedItem) > Convert.ToInt32(yearToComboBox.SelectedItem)) {
                var temp = yearToComboBox.SelectedItem;
                yearToComboBox.SelectedItem = yearFromComboBox.SelectedItem;
                yearFromComboBox.SelectedItem = temp;
            }
        }

        //These two swap engine capacity values if the first one is higher than the second one.
        private void engCapFromComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            if (engCapFromComboBox.SelectedItem == null || engCapToComboBox.SelectedItem == null) return;

            if (Convert.ToDouble(engCapFromComboBox.SelectedItem.ToString()) > Convert.ToDouble(engCapToComboBox.SelectedItem.ToString())) {
                var temp = engCapToComboBox.SelectedItem;
                engCapToComboBox.SelectedItem = engCapFromComboBox.SelectedItem;
                engCapFromComboBox.SelectedItem = temp;

            }
        }

        private void engCapToComboBox_SelectedValueChanged(object sender, EventArgs e) {
            if (engCapFromComboBox.SelectedItem == null || engCapToComboBox.SelectedItem == null) return;

            if (Convert.ToDouble(engCapFromComboBox.SelectedItem.ToString()) > Convert.ToDouble(engCapToComboBox.SelectedItem.ToString())) {
                var temp = engCapToComboBox.SelectedItem;
                engCapToComboBox.SelectedItem = engCapFromComboBox.SelectedItem;
                engCapFromComboBox.SelectedItem = temp;
            }
        }

        private void filterButton_Click(object sender, EventArgs e) {
            carsDataGrid.DataSource = HandleCarFilters(
                //TODO: Handle exceptions when inputting data manually
                brand: brandComboBox.Text,
                model: modelComboBox.Text,
                startYear: yearFromComboBox.Text,
                endYear: yearToComboBox.Text,
                engCapFrom: engCapFromComboBox.Text,
                engCapTo: engCapToComboBox.Text,
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

        private void UC_Cars_Load(object sender, EventArgs e) {

        }

        private void clearFilters_Click(object sender, EventArgs e) {
            foreach (var box in filterBoxes) {
                box.Text = null;
            }
        }

        public List<Car>? HandleCarFilters(string brand, string model, string startYear, string endYear, string engCapFrom,
            string engCapTo, string fuel, string drivetrain, string transmission, string bodyType, string color, string steeringWheel, string condition) {
            //TODO: Add correct values to all the filter comboboxes
            var filteredCars = cars;

            if (!string.IsNullOrEmpty(brand)) {
                filteredCars = filteredCars.Where(x => x.Brand.ToLower().Contains(brand.ToLower())).ToList();
            }

            if (!string.IsNullOrEmpty(model)) {
                filteredCars = filteredCars.Where(x => x.Model.ToLower().Contains(model.ToLower())).ToList();
            }

            if (!string.IsNullOrEmpty(startYear) && !string.IsNullOrEmpty(endYear)) {
                //TODO: Make this so it doesn't require both values
                filteredCars = filteredCars.Where(x => x.ProductionYear >= Convert.ToInt32(startYear) && x.ProductionYear <= Convert.ToInt32(endYear)).ToList();
            }

            if (!string.IsNullOrEmpty(engCapFrom) && !string.IsNullOrEmpty(engCapTo)) {
                //TODO: Make this so it doesn't require both values
                filteredCars = filteredCars.Where(x => x.EngineCapacity >= Convert.ToInt32(engCapFrom) && x.EngineCapacity <= Convert.ToInt32(engCapTo)).ToList();
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
                filteredCars = filteredCars.Where(x => x.TechnicalCondition.ToLower().Contains(condition.ToLower())).ToList();
            }

            return filteredCars;
        }

        private void carsDataGrid_DataSourceChanged(object sender, EventArgs e) {
            resultLabel.Text = $"Result ({carsDataGrid.RowCount} entries)";
        }
    }
}
