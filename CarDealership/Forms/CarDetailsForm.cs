using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarDealership.Forms;
using CarDealership.Models;

namespace CarDealership {
    public partial class CarDetailsForm : Form {

        private Car car = new();
        private Insurance? insurance = new();
        List<TextBox> editableTextBoxes = new List<TextBox>();
        public CarDetailsForm(int CarID) {
            InitializeComponent();
            car = Queries.GetCarsByID(CarID);
            insurance = Queries.GetInsuranceByCarID(CarID);
            carNameLabel.Text = $"{car.Brand} {car.Model}";
            carIDTextBox.Text = car.CarID.ToString();
            carBrandTextBox.Text = car.Brand.ToString();
            carModelTextBox.Text = car.Model.ToString();
            carYearTextBox.Text = car.ProductionYear.ToString();

            if (insurance is not null) {
                InsuranceIDTextBox.Text = insurance.InsuranceID.ToString();
                InsuranceNumberTextBox.Text = insurance.InsuranceNumber.ToString();
                InsuranceTypeTextBox.Text = insurance.InsuranceType.ToString();
                InsurerTextBox.Text = insurance.Insurer.ToString();
                InsuranceInsCountTextBox.Text = insurance.InstallmentCount.ToString();
            }

            editableTextBoxes.AddRange(new List<TextBox>() { carBrandTextBox, carModelTextBox, carYearTextBox });
        }
        private void InsuranceInsCountTextBox_MouseDoubleClick(object sender, MouseEventArgs e) {
            if (insurance is not null) {
                InstallmentsForm i = new(insurance.InsuranceID);
                i.Show();
            }
        }

        private void editButton_Click(object sender, EventArgs e) {
            editButton.Visible = false;
            saveButton.Visible = true;
            cancelButton.Visible = true;
            foreach (var textbox in editableTextBoxes) {
                textbox.ReadOnly = false;
            }
        }

        private void saveButton_Click(object sender, EventArgs e) {
            using (Database db = new Database()) {
                Car? c = db.Cars.Single(c => c.CarID == car.CarID);
                c.Brand = carBrandTextBox.Text;
                c.Model = carModelTextBox.Text;
                db.SaveChanges();

                this.Hide();
                CarDetailsForm cd = new CarDetailsForm(car.CarID);
                cd.Show();
            }

            editButton.Enabled = true;
            saveButton.Visible = false;
            cancelButton.Visible = false;
        }

        private void cancelButton_Click(object sender, EventArgs e) {
            this.Hide();
            CarDetailsForm cd = new CarDetailsForm(car.CarID);
            cd.Show();

            editButton.Visible = true;
            saveButton.Visible = false;
            cancelButton.Visible = false;
        }

        private void CarDetailsForm_FormClosed(object sender, FormClosedEventArgs e) {
            
        }
    }
}
