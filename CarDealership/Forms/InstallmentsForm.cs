using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarDealership.Models;

namespace CarDealership.Forms {
    public partial class InstallmentsForm : Form {
        public List<Installment>? installments = new();
        public InstallmentsForm(int InsuranceID) {
            InitializeComponent();
            installments = Queries.GetInstallmentsByInsuranceID(InsuranceID);

            installmentsGrid.DataSource = installments;
        }
    }
}
