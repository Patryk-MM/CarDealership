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
        public UC_Cars() {
            InitializeComponent();
            brandComboBox.DataSource = carBrands;
            brandComboBox.SelectedItem = null;
        }

        private void brandComboBox_SelectedValueChanged(object sender, EventArgs e) {
            try {
                modelComboBox.DataSource = Queries.GetCarModelsByBrand(brandComboBox.SelectedValue.ToString());
            } catch (Exception) { modelComboBox.DataSource = null; }
        }

        private void yearToComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            if (Convert.ToInt32(yearFromComboBox.SelectedItem) > Convert.ToInt32(yearToComboBox.SelectedItem)) {
                var temp = yearToComboBox.SelectedItem;
                yearToComboBox.SelectedItem = yearFromComboBox.SelectedItem;
                yearFromComboBox.SelectedItem = temp;
            }
        }

        private void yearFromComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            if (Convert.ToInt32(yearFromComboBox.SelectedItem) > Convert.ToInt32(yearToComboBox.SelectedItem)) {
                var temp = yearToComboBox.SelectedItem;
                yearToComboBox.SelectedItem = yearFromComboBox.SelectedItem;
                yearFromComboBox.SelectedItem = temp;
            }
        }

    }
}
