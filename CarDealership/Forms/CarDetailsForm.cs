using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarDealership.Forms;
using CarDealership.Models;

namespace CarDealership {
    public partial class CarDetailsForm : Form {

        private Car car = new();
        private Car carBackup = new Car();
        private BindingList<Reservation>? reservations = new();
        private BindingList<Insurance>? insurances = new();
        private List<ServiceRepair> repairs = new List<ServiceRepair>();
        List<TextBox> editableTextBoxes = new List<TextBox>();

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void topPanel_MouseMove(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        public CarDetailsForm(int CarID) {
            InitializeComponent();
            car = Queries.GetCarsByID(CarID);
            insurances = Queries.GetInsurancesByCarID(CarID);
            reservations = Queries.GetReservationsByCarID(CarID);
            repairs = Queries.GetServicesRepairsByCarID(CarID);
            carNameLabel.Text = $"{car.Brand} {car.Model}";
            carPropertyGrid.SelectedObject = car;
            carBackup = car;
            detailsDataGrid.Columns.Clear();
            detailsDataGrid.DataSource = null;
            detailsDataGrid.AutoGenerateColumns = true;

            //if (insurance is not null) {
            //    InsuranceIDTextBox.Text = insurance.InsuranceID.ToString();
            //    InsuranceNumberTextBox.Text = insurance.InsuranceNumber.ToString();
            //    InsuranceTypeTextBox.Text = insurance.InsuranceType.ToString();
            //    InsurerTextBox.Text = insurance.Insurer.ToString();
            //    InsuranceInsCountTextBox.Text = insurance.InstallmentCount.ToString();
            //}

            //editableTextBoxes.AddRange(new List<TextBox>() { carBrandTextBox, carModelTextBox, carYearTextBox });
        }
        private void InsuranceInsCountTextBox_MouseDoubleClick(object sender, MouseEventArgs e) {
            if (insurances is not null) {
                InstallmentsForm i = new(insurances[0].InsuranceID);
                i.Show();
            }
        }


        private void saveButton_Click(object sender, EventArgs e) {
            using (Database db = new Database()) {
                // Assuming car is a property or variable available in your form
                Car? c = db.Cars.SingleOrDefault(c => c.CarID == car.CarID);

                if (c != null) {
                    // Get all public properties of the Car class excluding CarID and DealershipID
                    var properties = typeof(Car).GetProperties()
                        .Where(prop => prop.Name != "CarID" && prop.Name != "DealershipID");

                    // Iterate through each property and update the values
                    foreach (var property in properties) {
                        // Check if the property is writable
                        if (property.CanWrite) {
                            // Update the property value from car to c
                            property.SetValue(c, property.GetValue(car));
                        }
                    }

                    // Save the changes to the database
                    db.SaveChanges();

                    this.Hide();
                    CarDetailsForm cd = new CarDetailsForm(car.CarID);
                    cd.Show();
                }
            }
        }

        private void cancelButton_Click(object sender, EventArgs e) {
            this.Hide();
            CarDetailsForm cd = new CarDetailsForm(car.CarID);
            cd.Show();

        }

        private void CarDetailsForm_FormClosed(object sender, FormClosedEventArgs e) {

        }

        private void pictureBox1_Click(object sender, EventArgs e) {
            Close();
        }

        private void carPropertyGrid_PropertyValueChanged(object s, PropertyValueChangedEventArgs e) {
            MessageBox.Show(car.Model);
        }

        private void topPanel_MouseMove_1(object sender, MouseEventArgs e) {

        }

        private void optionComboBox_SelectedValueChanged(object sender, EventArgs e) {
            detailsDataGrid.Columns.Clear();
            detailsDataGrid.DataSource = null;
            switch (optionComboBox.Text) {
                case "Reservations":
                    detailsDataGrid.DataSource = reservations;
                    break;
                case "Insurances":
                    detailsDataGrid.DataSource = insurances;
                    break;
                case "Repairs":
                    detailsDataGrid.DataSource = repairs;
                    break;
            }
            if(detailsDataGrid.DataSource == null) {
                MessageBox.Show("No data to display.");
            }
        }

        private void ConfigureDataGrid(Object obj) {
            if(obj is not null) {
                detailsDataGrid.Columns.Clear();
                foreach (PropertyInfo p in obj.GetType().GetProperties()) {
                    detailsDataGrid.Columns.Add(null, p.ToString());
                }
            } 
        }

    }
}
