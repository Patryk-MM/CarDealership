using CarDealership.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarDealership {
    public partial class NewCarForm : Form {

        private Car? newCar = new();
        private List<TextBox> textBoxes = new List<TextBox>();
        private List<ComboBox> dropDowns = new List<ComboBox>();
        public NewCarForm() {
            InitializeComponent();
            textBoxes.AddRange(new List<TextBox>() { brandTextBox, modelTextBox, yearTextBox, engineCapacityTextBox, powerTextBox, mileageTextBox, colorTextBox });
            dropDowns.AddRange(new List<ComboBox>() { fuelTypeDropDown, drivetrainDropDown, transmissionDropDown, bodyTypeDropDown, steeringWheelDropDown, conditionDropDown, dealershipIDDropDown });
        }

        private void addButton_Click(object sender, EventArgs e) {
            bool isNullPresent = false;
            foreach (TextBox textbox in textBoxes) {
                if (textbox.Text == "" && isNullPresent == false) {
                    MessageBox.Show("null");
                    isNullPresent = true;
                }
            }
            foreach (ComboBox dropdown in dropDowns) {
                if (dropdown.Text == "" && isNullPresent == false) {
                    MessageBox.Show("comboBox null");
                    isNullPresent = true;
                }
            }

            if(!isNullPresent) {
                newCar.Brand = brandTextBox.Text;
                newCar.Model = modelTextBox.Text;
                newCar.ProductionYear = Convert.ToInt32(yearTextBox.Text);
                newCar.EngineCapacity = Convert.ToDecimal(engineCapacityTextBox.Text);
                newCar.Power = Convert.ToInt32(powerTextBox.Text);
                newCar.Mileage = Convert.ToInt32(mileageTextBox.Text);
                newCar.FuelType = fuelTypeDropDown.SelectedItem.ToString();
                newCar.Drivetrain = drivetrainDropDown.SelectedItem.ToString();
                newCar.Transmission = transmissionDropDown.SelectedItem.ToString();
                newCar.BodyType = bodyTypeDropDown.SelectedItem.ToString();
                newCar.Color = colorTextBox.Text;
                newCar.SteeringWheelPosition = steeringWheelDropDown.SelectedItem.ToString();
                newCar.TechnicalCondition = conditionDropDown.SelectedItem.ToString();
                newCar.DealershipID = Convert.ToInt32(dealershipIDDropDown.SelectedItem);


                using (Database db = new Database()) {
                    db.Add(newCar);
                    db.SaveChanges();
                };
            }

            this.Hide();
        }

        private void cancelButton_Click(object sender, EventArgs e) {
            this.Hide();
        }
    }
}

