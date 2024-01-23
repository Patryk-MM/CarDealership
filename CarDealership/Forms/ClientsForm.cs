using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarDealership {
    public partial class ClientsForm : Form {
        public ClientsForm() {
            InitializeComponent();
        }

        private void carsChangeForm_Click(object sender, EventArgs e) {
            this.Hide();    
            CarsForm c = new CarsForm();
            c.Show();
        }
    }
}
