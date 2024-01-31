namespace CarDealership.UserControls {
    partial class UC_Cars {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            components = new System.ComponentModel.Container();
            carsChangeForm = new Label();
            label1 = new Label();
            brandComboBox = new ComboBox();
            modelComboBox = new ComboBox();
            label2 = new Label();
            yearFromComboBox = new ComboBox();
            yearToComboBox = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            engCapToComboBox = new ComboBox();
            engCapFromComboBox = new ComboBox();
            label5 = new Label();
            mileageToComboBox = new ComboBox();
            mileageFromComboBox = new ComboBox();
            label6 = new Label();
            engPowToComboBox = new ComboBox();
            engPowFromComboBox = new ComboBox();
            label7 = new Label();
            fuelComboBox = new ComboBox();
            label8 = new Label();
            comboBox1 = new ComboBox();
            label9 = new Label();
            comboBox2 = new ComboBox();
            label10 = new Label();
            comboBox3 = new ComboBox();
            label11 = new Label();
            comboBox4 = new ComboBox();
            label12 = new Label();
            comboBox5 = new ComboBox();
            label13 = new Label();
            carsDataGrid = new DataGridView();
            carIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            brandDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            modelDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productionYearDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            engineCapacityDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            powerDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            mileageDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fuelTypeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            drivetrainDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            transmissionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bodyTypeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            colorDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            steeringWheelPositionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            technicalConditionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dealershipIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            carBindingSource = new BindingSource(components);
            filterButton = new Button();
            clearFilters = new Button();
            ((System.ComponentModel.ISupportInitialize)carsDataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)carBindingSource).BeginInit();
            SuspendLayout();
            // 
            // carsChangeForm
            // 
            carsChangeForm.AutoSize = true;
            carsChangeForm.Font = new Font("Tahoma", 36F, FontStyle.Bold, GraphicsUnit.Point, 238);
            carsChangeForm.Location = new Point(0, 0);
            carsChangeForm.Name = "carsChangeForm";
            carsChangeForm.Size = new Size(176, 58);
            carsChangeForm.TabIndex = 24;
            carsChangeForm.Text = "Filters";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.Location = new Point(30, 75);
            label1.Name = "label1";
            label1.Size = new Size(68, 25);
            label1.TabIndex = 25;
            label1.Text = "Brand";
            // 
            // brandComboBox
            // 
            brandComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            brandComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            brandComboBox.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            brandComboBox.FormattingEnabled = true;
            brandComboBox.Location = new Point(30, 103);
            brandComboBox.Name = "brandComboBox";
            brandComboBox.Size = new Size(163, 33);
            brandComboBox.TabIndex = 26;
            brandComboBox.SelectedValueChanged += brandComboBox_SelectedValueChanged;
            // 
            // modelComboBox
            // 
            modelComboBox.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            modelComboBox.FormattingEnabled = true;
            modelComboBox.Location = new Point(208, 103);
            modelComboBox.Name = "modelComboBox";
            modelComboBox.Size = new Size(163, 33);
            modelComboBox.TabIndex = 27;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label2.Location = new Point(208, 75);
            label2.Name = "label2";
            label2.Size = new Size(67, 25);
            label2.TabIndex = 28;
            label2.Text = "Model";
            // 
            // yearFromComboBox
            // 
            yearFromComboBox.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            yearFromComboBox.FormattingEnabled = true;
            yearFromComboBox.Items.AddRange(new object[] { "1900", "1930", "1960", "1980", "1990", "1995", "2000", "2001", "2002", "2003", "2004", "2005", "2006", "2007", "2008", "2009", "2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020", "2021", "2022", "2023", "2024" });
            yearFromComboBox.Location = new Point(387, 103);
            yearFromComboBox.Name = "yearFromComboBox";
            yearFromComboBox.Size = new Size(80, 33);
            yearFromComboBox.TabIndex = 29;
            yearFromComboBox.SelectedIndexChanged += yearFromComboBox_SelectedIndexChanged;
            // 
            // yearToComboBox
            // 
            yearToComboBox.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            yearToComboBox.FormattingEnabled = true;
            yearToComboBox.Items.AddRange(new object[] { "1900", "1930", "1960", "1980", "1990", "1995", "2000", "2001", "2002", "2003", "2004", "2005", "2006", "2007", "2008", "2009", "2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020", "2021", "2022", "2023", "2024" });
            yearToComboBox.Location = new Point(473, 103);
            yearToComboBox.Name = "yearToComboBox";
            yearToComboBox.Size = new Size(80, 33);
            yearToComboBox.TabIndex = 30;
            yearToComboBox.SelectedIndexChanged += yearToComboBox_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label3.Location = new Point(387, 75);
            label3.Name = "label3";
            label3.Size = new Size(159, 25);
            label3.TabIndex = 31;
            label3.Text = "Production year";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label4.Location = new Point(569, 75);
            label4.Name = "label4";
            label4.Size = new Size(159, 25);
            label4.TabIndex = 34;
            label4.Text = "Engine capacity";
            // 
            // engCapToComboBox
            // 
            engCapToComboBox.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            engCapToComboBox.FormattingEnabled = true;
            engCapToComboBox.Items.AddRange(new object[] { "1,0", "1,2", "1,4", "1,6", "1,8", "2,0", "2,2", "2,4", "2,6", "2,8", "3,0" });
            engCapToComboBox.Location = new Point(655, 103);
            engCapToComboBox.Name = "engCapToComboBox";
            engCapToComboBox.Size = new Size(80, 33);
            engCapToComboBox.TabIndex = 33;
            engCapToComboBox.SelectedValueChanged += engCapToComboBox_SelectedValueChanged;
            // 
            // engCapFromComboBox
            // 
            engCapFromComboBox.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            engCapFromComboBox.FormattingEnabled = true;
            engCapFromComboBox.Items.AddRange(new object[] { "1,0", "1,2", "1,4", "1,6", "1,8", "2,0", "2,2", "2,4", "2,6", "2,8", "3,0" });
            engCapFromComboBox.Location = new Point(569, 103);
            engCapFromComboBox.Name = "engCapFromComboBox";
            engCapFromComboBox.Size = new Size(80, 33);
            engCapFromComboBox.TabIndex = 32;
            engCapFromComboBox.SelectedIndexChanged += engCapFromComboBox_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label5.Location = new Point(750, 75);
            label5.Name = "label5";
            label5.Size = new Size(83, 25);
            label5.TabIndex = 37;
            label5.Text = "Mileage";
            // 
            // mileageToComboBox
            // 
            mileageToComboBox.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            mileageToComboBox.FormattingEnabled = true;
            mileageToComboBox.Items.AddRange(new object[] { "1000", "1200", "1400", "1600", "1800", "2000", "2200", "2400", "2600", "2800", "3000" });
            mileageToComboBox.Location = new Point(866, 103);
            mileageToComboBox.Name = "mileageToComboBox";
            mileageToComboBox.Size = new Size(110, 33);
            mileageToComboBox.TabIndex = 36;
            // 
            // mileageFromComboBox
            // 
            mileageFromComboBox.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            mileageFromComboBox.FormattingEnabled = true;
            mileageFromComboBox.Items.AddRange(new object[] { "1000", "1200", "1400", "1600", "1800", "2000", "2200", "2400", "2600", "2800", "3000" });
            mileageFromComboBox.Location = new Point(750, 103);
            mileageFromComboBox.Name = "mileageFromComboBox";
            mileageFromComboBox.Size = new Size(110, 33);
            mileageFromComboBox.TabIndex = 35;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label6.Location = new Point(991, 75);
            label6.Name = "label6";
            label6.Size = new Size(141, 25);
            label6.TabIndex = 40;
            label6.Text = "Engine power";
            // 
            // engPowToComboBox
            // 
            engPowToComboBox.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            engPowToComboBox.FormattingEnabled = true;
            engPowToComboBox.Items.AddRange(new object[] { "1000", "1200", "1400", "1600", "1800", "2000", "2200", "2400", "2600", "2800", "3000" });
            engPowToComboBox.Location = new Point(1077, 103);
            engPowToComboBox.Name = "engPowToComboBox";
            engPowToComboBox.Size = new Size(80, 33);
            engPowToComboBox.TabIndex = 39;
            // 
            // engPowFromComboBox
            // 
            engPowFromComboBox.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            engPowFromComboBox.FormattingEnabled = true;
            engPowFromComboBox.Items.AddRange(new object[] { "1000", "1200", "1400", "1600", "1800", "2000", "2200", "2400", "2600", "2800", "3000" });
            engPowFromComboBox.Location = new Point(991, 103);
            engPowFromComboBox.Name = "engPowFromComboBox";
            engPowFromComboBox.Size = new Size(80, 33);
            engPowFromComboBox.TabIndex = 38;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label7.Location = new Point(1172, 75);
            label7.Name = "label7";
            label7.Size = new Size(51, 25);
            label7.TabIndex = 42;
            label7.Text = "Fuel";
            // 
            // fuelComboBox
            // 
            fuelComboBox.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            fuelComboBox.FormattingEnabled = true;
            fuelComboBox.Location = new Point(1172, 103);
            fuelComboBox.Name = "fuelComboBox";
            fuelComboBox.Size = new Size(163, 33);
            fuelComboBox.TabIndex = 41;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label8.Location = new Point(1351, 75);
            label8.Name = "label8";
            label8.Size = new Size(103, 25);
            label8.TabIndex = 44;
            label8.Text = "Drivetrain";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(1351, 103);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(163, 33);
            comboBox1.TabIndex = 43;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label9.Location = new Point(30, 144);
            label9.Name = "label9";
            label9.Size = new Size(133, 25);
            label9.TabIndex = 46;
            label9.Text = "Transmission";
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(30, 172);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(163, 33);
            comboBox2.TabIndex = 45;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label10.Location = new Point(208, 144);
            label10.Name = "label10";
            label10.Size = new Size(60, 25);
            label10.TabIndex = 48;
            label10.Text = "Color";
            // 
            // comboBox3
            // 
            comboBox3.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(208, 172);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(163, 33);
            comboBox3.TabIndex = 47;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label11.Location = new Point(387, 144);
            label11.Name = "label11";
            label11.Size = new Size(152, 25);
            label11.TabIndex = 50;
            label11.Text = "Steering wheel";
            // 
            // comboBox4
            // 
            comboBox4.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(387, 172);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(163, 33);
            comboBox4.TabIndex = 49;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label12.Location = new Point(572, 144);
            label12.Name = "label12";
            label12.Size = new Size(100, 25);
            label12.TabIndex = 52;
            label12.Text = "Condition";
            // 
            // comboBox5
            // 
            comboBox5.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            comboBox5.FormattingEnabled = true;
            comboBox5.Location = new Point(572, 172);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(163, 33);
            comboBox5.TabIndex = 51;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Tahoma", 36F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label13.Location = new Point(0, 254);
            label13.Name = "label13";
            label13.Size = new Size(179, 58);
            label13.TabIndex = 53;
            label13.Text = "Result";
            // 
            // carsDataGrid
            // 
            carsDataGrid.AutoGenerateColumns = false;
            carsDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            carsDataGrid.Columns.AddRange(new DataGridViewColumn[] { carIDDataGridViewTextBoxColumn, brandDataGridViewTextBoxColumn, modelDataGridViewTextBoxColumn, productionYearDataGridViewTextBoxColumn, engineCapacityDataGridViewTextBoxColumn, powerDataGridViewTextBoxColumn, mileageDataGridViewTextBoxColumn, fuelTypeDataGridViewTextBoxColumn, drivetrainDataGridViewTextBoxColumn, transmissionDataGridViewTextBoxColumn, bodyTypeDataGridViewTextBoxColumn, colorDataGridViewTextBoxColumn, steeringWheelPositionDataGridViewTextBoxColumn, technicalConditionDataGridViewTextBoxColumn, dealershipIDDataGridViewTextBoxColumn });
            carsDataGrid.DataSource = carBindingSource;
            carsDataGrid.Location = new Point(30, 332);
            carsDataGrid.Name = "carsDataGrid";
            carsDataGrid.Size = new Size(1484, 323);
            carsDataGrid.TabIndex = 54;
            carsDataGrid.CellMouseDoubleClick += carsDataGrid_CellMouseDoubleClick;
            // 
            // carIDDataGridViewTextBoxColumn
            // 
            carIDDataGridViewTextBoxColumn.DataPropertyName = "CarID";
            carIDDataGridViewTextBoxColumn.HeaderText = "CarID";
            carIDDataGridViewTextBoxColumn.Name = "carIDDataGridViewTextBoxColumn";
            // 
            // brandDataGridViewTextBoxColumn
            // 
            brandDataGridViewTextBoxColumn.DataPropertyName = "Brand";
            brandDataGridViewTextBoxColumn.HeaderText = "Brand";
            brandDataGridViewTextBoxColumn.Name = "brandDataGridViewTextBoxColumn";
            // 
            // modelDataGridViewTextBoxColumn
            // 
            modelDataGridViewTextBoxColumn.DataPropertyName = "Model";
            modelDataGridViewTextBoxColumn.HeaderText = "Model";
            modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            // 
            // productionYearDataGridViewTextBoxColumn
            // 
            productionYearDataGridViewTextBoxColumn.DataPropertyName = "ProductionYear";
            productionYearDataGridViewTextBoxColumn.HeaderText = "ProductionYear";
            productionYearDataGridViewTextBoxColumn.Name = "productionYearDataGridViewTextBoxColumn";
            // 
            // engineCapacityDataGridViewTextBoxColumn
            // 
            engineCapacityDataGridViewTextBoxColumn.DataPropertyName = "EngineCapacity";
            engineCapacityDataGridViewTextBoxColumn.HeaderText = "EngineCapacity";
            engineCapacityDataGridViewTextBoxColumn.Name = "engineCapacityDataGridViewTextBoxColumn";
            // 
            // powerDataGridViewTextBoxColumn
            // 
            powerDataGridViewTextBoxColumn.DataPropertyName = "Power";
            powerDataGridViewTextBoxColumn.HeaderText = "Power";
            powerDataGridViewTextBoxColumn.Name = "powerDataGridViewTextBoxColumn";
            // 
            // mileageDataGridViewTextBoxColumn
            // 
            mileageDataGridViewTextBoxColumn.DataPropertyName = "Mileage";
            mileageDataGridViewTextBoxColumn.HeaderText = "Mileage";
            mileageDataGridViewTextBoxColumn.Name = "mileageDataGridViewTextBoxColumn";
            // 
            // fuelTypeDataGridViewTextBoxColumn
            // 
            fuelTypeDataGridViewTextBoxColumn.DataPropertyName = "FuelType";
            fuelTypeDataGridViewTextBoxColumn.HeaderText = "FuelType";
            fuelTypeDataGridViewTextBoxColumn.Name = "fuelTypeDataGridViewTextBoxColumn";
            // 
            // drivetrainDataGridViewTextBoxColumn
            // 
            drivetrainDataGridViewTextBoxColumn.DataPropertyName = "Drivetrain";
            drivetrainDataGridViewTextBoxColumn.HeaderText = "Drivetrain";
            drivetrainDataGridViewTextBoxColumn.Name = "drivetrainDataGridViewTextBoxColumn";
            // 
            // transmissionDataGridViewTextBoxColumn
            // 
            transmissionDataGridViewTextBoxColumn.DataPropertyName = "Transmission";
            transmissionDataGridViewTextBoxColumn.HeaderText = "Transmission";
            transmissionDataGridViewTextBoxColumn.Name = "transmissionDataGridViewTextBoxColumn";
            // 
            // bodyTypeDataGridViewTextBoxColumn
            // 
            bodyTypeDataGridViewTextBoxColumn.DataPropertyName = "BodyType";
            bodyTypeDataGridViewTextBoxColumn.HeaderText = "BodyType";
            bodyTypeDataGridViewTextBoxColumn.Name = "bodyTypeDataGridViewTextBoxColumn";
            // 
            // colorDataGridViewTextBoxColumn
            // 
            colorDataGridViewTextBoxColumn.DataPropertyName = "Color";
            colorDataGridViewTextBoxColumn.HeaderText = "Color";
            colorDataGridViewTextBoxColumn.Name = "colorDataGridViewTextBoxColumn";
            // 
            // steeringWheelPositionDataGridViewTextBoxColumn
            // 
            steeringWheelPositionDataGridViewTextBoxColumn.DataPropertyName = "SteeringWheelPosition";
            steeringWheelPositionDataGridViewTextBoxColumn.HeaderText = "SteeringWheelPosition";
            steeringWheelPositionDataGridViewTextBoxColumn.Name = "steeringWheelPositionDataGridViewTextBoxColumn";
            // 
            // technicalConditionDataGridViewTextBoxColumn
            // 
            technicalConditionDataGridViewTextBoxColumn.DataPropertyName = "TechnicalCondition";
            technicalConditionDataGridViewTextBoxColumn.HeaderText = "TechnicalCondition";
            technicalConditionDataGridViewTextBoxColumn.Name = "technicalConditionDataGridViewTextBoxColumn";
            // 
            // dealershipIDDataGridViewTextBoxColumn
            // 
            dealershipIDDataGridViewTextBoxColumn.DataPropertyName = "DealershipID";
            dealershipIDDataGridViewTextBoxColumn.HeaderText = "DealershipID";
            dealershipIDDataGridViewTextBoxColumn.Name = "dealershipIDDataGridViewTextBoxColumn";
            // 
            // carBindingSource
            // 
            carBindingSource.DataSource = typeof(Models.Car);
            // 
            // filterButton
            // 
            filterButton.BackColor = Color.Transparent;
            filterButton.FlatAppearance.BorderSize = 0;
            filterButton.FlatAppearance.MouseOverBackColor = Color.MediumSlateBlue;
            filterButton.FlatStyle = FlatStyle.Flat;
            filterButton.Font = new Font("Tahoma", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            filterButton.Location = new Point(1298, 172);
            filterButton.Name = "filterButton";
            filterButton.Size = new Size(216, 78);
            filterButton.TabIndex = 55;
            filterButton.Text = "Apply filters";
            filterButton.UseVisualStyleBackColor = false;
            filterButton.Click += filterButton_Click;
            // 
            // clearFilters
            // 
            clearFilters.BackColor = Color.Transparent;
            clearFilters.FlatAppearance.BorderSize = 0;
            clearFilters.FlatAppearance.MouseOverBackColor = Color.MediumSlateBlue;
            clearFilters.FlatStyle = FlatStyle.Flat;
            clearFilters.Font = new Font("Tahoma", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            clearFilters.Location = new Point(1076, 172);
            clearFilters.Name = "clearFilters";
            clearFilters.Size = new Size(216, 78);
            clearFilters.TabIndex = 56;
            clearFilters.Text = "Clear filters";
            clearFilters.UseVisualStyleBackColor = false;
            clearFilters.Click += clearFilters_Click;
            // 
            // UC_Cars
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(clearFilters);
            Controls.Add(filterButton);
            Controls.Add(carsDataGrid);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(comboBox5);
            Controls.Add(label11);
            Controls.Add(comboBox4);
            Controls.Add(label10);
            Controls.Add(comboBox3);
            Controls.Add(label9);
            Controls.Add(comboBox2);
            Controls.Add(label8);
            Controls.Add(comboBox1);
            Controls.Add(label7);
            Controls.Add(fuelComboBox);
            Controls.Add(label6);
            Controls.Add(engPowToComboBox);
            Controls.Add(engPowFromComboBox);
            Controls.Add(label5);
            Controls.Add(mileageToComboBox);
            Controls.Add(mileageFromComboBox);
            Controls.Add(label4);
            Controls.Add(engCapToComboBox);
            Controls.Add(engCapFromComboBox);
            Controls.Add(label3);
            Controls.Add(yearToComboBox);
            Controls.Add(yearFromComboBox);
            Controls.Add(label2);
            Controls.Add(modelComboBox);
            Controls.Add(brandComboBox);
            Controls.Add(label1);
            Controls.Add(carsChangeForm);
            Name = "UC_Cars";
            Size = new Size(1600, 989);
            Load += UC_Cars_Load;
            ((System.ComponentModel.ISupportInitialize)carsDataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)carBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label carsChangeForm;
        private Label label1;
        private ComboBox brandComboBox;
        private ComboBox modelComboBox;
        private Label label2;
        private ComboBox yearFromComboBox;
        private ComboBox yearToComboBox;
        private Label label3;
        private Label label4;
        private ComboBox engCapToComboBox;
        private ComboBox engCapFromComboBox;
        private Label label5;
        private ComboBox mileageToComboBox;
        private ComboBox mileageFromComboBox;
        private Label label6;
        private ComboBox engPowToComboBox;
        private ComboBox engPowFromComboBox;
        private Label label7;
        private ComboBox fuelComboBox;
        private Label label8;
        private ComboBox comboBox1;
        private Label label9;
        private ComboBox comboBox2;
        private Label label10;
        private ComboBox comboBox3;
        private Label label11;
        private ComboBox comboBox4;
        private Label label12;
        private ComboBox comboBox5;
        private Label label13;
        private DataGridView carsDataGrid;
        private DataGridViewTextBoxColumn carIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn brandDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productionYearDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn engineCapacityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn powerDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn mileageDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fuelTypeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn drivetrainDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn transmissionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn bodyTypeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn colorDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn steeringWheelPositionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn technicalConditionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dealershipIDDataGridViewTextBoxColumn;
        private BindingSource carBindingSource;
        private Button filterButton;
        private Button clearFilters;
    }
}
