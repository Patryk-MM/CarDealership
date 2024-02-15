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
using CsvHelper;
using System.Globalization;
using CsvHelper.Configuration;
using CarDealership.Forms;
using System.Runtime.InteropServices;

namespace CarDealership {
    public partial class NewCarForm : Form {

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

        private Car? newCar = new();
        private List<Control> controls = new List<Control>();
        private List<TextBox> textBoxes = new List<TextBox>();
        private List<ComboBox> dropDowns = new List<ComboBox>();
        public NewCarForm() {
            InitializeComponent();
            controls.AddRange(new List<Control>() { brandTextBox, modelTextBox, yearTextBox, engineCapacityTextBox, powerTextBox, mileageTextBox, fuelTypeDropDown, transmissionDropDown, drivetrainDropDown, bodyTypeDropDown, colorTextBox, steeringWheelDropDown, conditionDropDown, dealershipIDDropDown });
            textBoxes.AddRange(new List<TextBox>() { brandTextBox, modelTextBox, yearTextBox, engineCapacityTextBox, powerTextBox, mileageTextBox, colorTextBox });
            dropDowns.AddRange(new List<ComboBox>() { fuelTypeDropDown, drivetrainDropDown, transmissionDropDown, bodyTypeDropDown, steeringWheelDropDown, conditionDropDown, dealershipIDDropDown });
        }

        private void confirmButton_Click(object sender, EventArgs e) {
            bool isNullPresent = false;
            foreach (TextBox textbox in textBoxes) {
                if (textbox.Text == "" && isNullPresent == false) {
                    MessageBox.Show("There are empty fields in the form.");
                    isNullPresent = true;
                    return;
                }
            }
            foreach (ComboBox dropdown in dropDowns) {
                if (dropdown.Text == "" && isNullPresent == false) {
                    MessageBox.Show("There are empty fields in the form.");
                    isNullPresent = true;
                    return;
                }
                
            }

            if (!isNullPresent) {
                newCar.Brand = brandTextBox.Text;
                newCar.Model = modelTextBox.Text;
                newCar.ProductionYear = Convert.ToInt32(yearTextBox.Text);
                newCar.EngineCapacity = Convert.ToInt32(engineCapacityTextBox.Text);
                newCar.Power = Convert.ToInt32(powerTextBox.Text);
                newCar.Mileage = Convert.ToInt32(mileageTextBox.Text);
                newCar.FuelType = fuelTypeDropDown.Text.ToString();
                newCar.Drivetrain = drivetrainDropDown.Text.ToString();
                newCar.Transmission = transmissionDropDown.Text.ToString();
                newCar.BodyType = bodyTypeDropDown.Text.ToString();
                newCar.Color = colorTextBox.Text;
                newCar.SteeringWheelPosition = steeringWheelDropDown.Text.ToString();
                newCar.TechnicalCondition = conditionDropDown.Text.ToString();
                newCar.DealershipID = Convert.ToInt32(dealershipIDDropDown.Text);


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

        private void importFromCSVButton_Click(object sender, EventArgs e) {
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
                            using (CsvReader csv = new(reader, config)) {
                                csv.Read();
                                var record = csv.GetRecord<Car>();
                                var properties = record.GetType().GetProperties();
                                for (int i = 1; i < properties.Length; i++) {
                                    var value = properties[i].GetValue(record);
                                    controls[i - 1].Text = value != null ? value.ToString() : string.Empty;
                                }
                            }
                        }
                    } catch (Exception ex) { MessageBox.Show($"{ex.Message}"); }
                }
            }
        }

        private void exitPicture_Click(object sender, EventArgs e) {
            Hide();
        }

        private void yearTextBox_KeyPress(object sender, KeyPressEventArgs e) {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) {
                e.Handled = true;
            }
        }

        private void engineCapacityTextBox_KeyPress(object sender, KeyPressEventArgs e) {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) {
                e.Handled = true;
            }
        }

        private void powerTextBox_KeyPress(object sender, KeyPressEventArgs e) {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) {
                e.Handled = true;
            }
        }

        private void mileageTextBox_KeyPress(object sender, KeyPressEventArgs e) {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) {
                e.Handled = true;
            }
        }
    }
}

