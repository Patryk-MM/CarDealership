using CarDealership.Models;

namespace CarDealership
{
    public partial class CarsForm : Form {
        private NewCarForm newCarForm;

        public List<Car> cars = new List<Car>();


        public CarsForm() {
            InitializeComponent();

            newCarForm = new NewCarForm();
            //tabPage1.Controls.Add(newCarForm);
        }

        private void button1_Click(object sender, EventArgs e) {
            //var result = Queries.GetFirstCar(chooseBrandTextBox.Text);
            //if (result != null) {
            //    infoLabel.Text = "";
            //    brandTextBox.Text = result.Brand;
            //    modelTextBox.Text = result.Model;
            //    yearTextBox.Text = result.ProductionYear.ToString();
            //} else {
            //    infoLabel.Text = "Car not found.";
            //}

            cars = Queries.GetCarsByBrand(chooseBrandTextBox.Text);
            if (cars == null) {
                infoLabel.Text = "Car not found.";
            } else {
                //foreach (Car car in cars) {
                //carsListBox.Items.Add($"{car.CarID,3} | {car.Brand} | {car.Model}");
                carsGrid.DataSource = cars;
                //}
            }
        }

        //private void carsListBox_SelectedIndexChanged(object sender, EventArgs e) {
        //    var index = carsListBox.SelectedIndex;
        //    brandTextBox.Text = cars[index].Brand;
        //    modelTextBox.Text = cars[index].Model;
        //    yearTextBox.Text = cars[index].ProductionYear.ToString();
        //}

        private void carsGrid_SelectionChanged(object sender, EventArgs e) {
            if (carsGrid.Rows.Count == 0) {
                carsGrid.Enabled = false;
            } else { carsGrid.Enabled = true; }

            //try {
                brandTextBox.Text = carsGrid.CurrentRow.Cells[1].Value.ToString();
                modelTextBox.Text = carsGrid.CurrentRow.Cells[2].Value.ToString();
                yearTextBox.Text = carsGrid.CurrentRow.Cells[3].Value.ToString();
            //} catch (NullReferenceException) { }
        }




        public List<Car>? HandleCarFilters(string model, string startYear, string endYear) {

            var filteredCars = cars;

            if (!string.IsNullOrEmpty(model)) {
                filteredCars = filteredCars.Where(x => x.Model.ToLower().Contains(model.ToLower())).ToList();
            }

            if (!string.IsNullOrEmpty(startYear) && !string.IsNullOrEmpty(endYear)) {
                filteredCars = filteredCars.Where(x => x.ProductionYear >= Convert.ToInt32(startYear) && x.ProductionYear <= Convert.ToInt32(endYear)).ToList();
            }

            return filteredCars;
        }

        private void filterButton_Click(object sender, EventArgs e) {
            carsGrid.ClearSelection();
            carsGrid.DataSource = HandleCarFilters(modelFilterTextBox.Text, startYearTextBox.Text, endYearTextBox.Text);
        }

        private void ClientsChangeForm_Click(object sender, EventArgs e) {
            //Hide();
            ClientsForm c = new ClientsForm();
            c.ShowDialog();
        }

        private void carsGrid_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e) {
            CarDetailsForm cd = new CarDetailsForm((int)carsGrid.CurrentRow.Cells[0].Value);
            cd.Show();
        }

        private void addANewCarButton_Click(object sender, EventArgs e) {
            NewCarForm nc = new();
            nc.Show();
        }

        private void refreshButton_Click(object sender, EventArgs e) {
            carsGrid.DataSource = cars;
        }
    }
}
