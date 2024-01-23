using CarDealership.Models;

namespace CarDealership
{
    partial class CarsForm {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            chooseBrandTextBox = new TextBox();
            button1 = new Button();
            brandTextBox = new TextBox();
            modelTextBox = new TextBox();
            yearTextBox = new TextBox();
            infoLabel = new Label();
            carsGrid = new DataGridView();
            carIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            brandDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            modelDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productionYearDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            carBindingSource = new BindingSource(components);
            label4 = new Label();
            label6 = new Label();
            modelFilterTextBox = new TextBox();
            filterButton = new Button();
            label7 = new Label();
            startYearTextBox = new TextBox();
            label8 = new Label();
            endYearTextBox = new TextBox();
            carsChangeForm = new Label();
            ClientsChangeForm = new Label();
            addANewCarButton = new Button();
            ((System.ComponentModel.ISupportInitialize)carsGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)carBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.Location = new Point(76, 224);
            label1.Name = "label1";
            label1.Size = new Size(62, 25);
            label1.TabIndex = 0;
            label1.Text = "Brand";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label2.Location = new Point(72, 263);
            label2.Name = "label2";
            label2.Size = new Size(66, 25);
            label2.TabIndex = 1;
            label2.Text = "Model";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label3.Location = new Point(90, 302);
            label3.Name = "label3";
            label3.Size = new Size(48, 25);
            label3.TabIndex = 2;
            label3.Text = "Year";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label5.Location = new Point(72, 84);
            label5.Name = "label5";
            label5.Size = new Size(149, 25);
            label5.TabIndex = 4;
            label5.Text = "Choose a brand:";
            // 
            // chooseBrandTextBox
            // 
            chooseBrandTextBox.Location = new Point(227, 86);
            chooseBrandTextBox.Name = "chooseBrandTextBox";
            chooseBrandTextBox.Size = new Size(191, 23);
            chooseBrandTextBox.TabIndex = 5;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            button1.Location = new Point(72, 128);
            button1.Name = "button1";
            button1.Size = new Size(166, 41);
            button1.TabIndex = 6;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // brandTextBox
            // 
            brandTextBox.Location = new Point(169, 229);
            brandTextBox.Name = "brandTextBox";
            brandTextBox.Size = new Size(156, 23);
            brandTextBox.TabIndex = 7;
            // 
            // modelTextBox
            // 
            modelTextBox.Location = new Point(169, 268);
            modelTextBox.Name = "modelTextBox";
            modelTextBox.Size = new Size(156, 23);
            modelTextBox.TabIndex = 8;
            // 
            // yearTextBox
            // 
            yearTextBox.Location = new Point(169, 307);
            yearTextBox.Name = "yearTextBox";
            yearTextBox.Size = new Size(156, 23);
            yearTextBox.TabIndex = 9;
            // 
            // infoLabel
            // 
            infoLabel.AutoSize = true;
            infoLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            infoLabel.Location = new Point(169, 364);
            infoLabel.Name = "infoLabel";
            infoLabel.Size = new Size(0, 25);
            infoLabel.TabIndex = 10;
            // 
            // carsGrid
            // 
            carsGrid.AutoGenerateColumns = false;
            carsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            carsGrid.Columns.AddRange(new DataGridViewColumn[] { carIDDataGridViewTextBoxColumn, brandDataGridViewTextBoxColumn, modelDataGridViewTextBoxColumn, productionYearDataGridViewTextBoxColumn });
            carsGrid.DataSource = carBindingSource;
            carsGrid.Enabled = false;
            carsGrid.Location = new Point(545, 84);
            carsGrid.Name = "carsGrid";
            carsGrid.Size = new Size(517, 689);
            carsGrid.TabIndex = 12;
            carsGrid.CellMouseDoubleClick += carsGrid_CellMouseDoubleClick;
            carsGrid.SelectionChanged += carsGrid_SelectionChanged;
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
            // carBindingSource
            // 
            carBindingSource.DataSource = typeof(Car);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label4.Location = new Point(72, 405);
            label4.Name = "label4";
            label4.Size = new Size(66, 25);
            label4.TabIndex = 13;
            label4.Text = "Filters:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label6.Location = new Point(72, 464);
            label6.Name = "label6";
            label6.Size = new Size(66, 25);
            label6.TabIndex = 14;
            label6.Text = "Model";
            // 
            // modelFilterTextBox
            // 
            modelFilterTextBox.Location = new Point(169, 464);
            modelFilterTextBox.Name = "modelFilterTextBox";
            modelFilterTextBox.Size = new Size(156, 23);
            modelFilterTextBox.TabIndex = 15;
            // 
            // filterButton
            // 
            filterButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            filterButton.Location = new Point(72, 586);
            filterButton.Name = "filterButton";
            filterButton.Size = new Size(166, 41);
            filterButton.TabIndex = 16;
            filterButton.Text = "Filter";
            filterButton.UseVisualStyleBackColor = true;
            filterButton.Click += filterButton_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label7.Location = new Point(90, 506);
            label7.Name = "label7";
            label7.Size = new Size(48, 25);
            label7.TabIndex = 17;
            label7.Text = "Year";
            // 
            // startYearTextBox
            // 
            startYearTextBox.Location = new Point(169, 506);
            startYearTextBox.Name = "startYearTextBox";
            startYearTextBox.Size = new Size(52, 23);
            startYearTextBox.TabIndex = 18;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label8.Location = new Point(228, 506);
            label8.Name = "label8";
            label8.Size = new Size(20, 25);
            label8.TabIndex = 19;
            label8.Text = "-";
            // 
            // endYearTextBox
            // 
            endYearTextBox.Location = new Point(254, 508);
            endYearTextBox.Name = "endYearTextBox";
            endYearTextBox.Size = new Size(52, 23);
            endYearTextBox.TabIndex = 20;
            // 
            // carsChangeForm
            // 
            carsChangeForm.AutoSize = true;
            carsChangeForm.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            carsChangeForm.Location = new Point(72, 23);
            carsChangeForm.Name = "carsChangeForm";
            carsChangeForm.Size = new Size(54, 30);
            carsChangeForm.TabIndex = 21;
            carsChangeForm.Text = "Cars";
            // 
            // ClientsChangeForm
            // 
            ClientsChangeForm.AutoSize = true;
            ClientsChangeForm.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            ClientsChangeForm.Location = new Point(169, 23);
            ClientsChangeForm.Name = "ClientsChangeForm";
            ClientsChangeForm.Size = new Size(79, 30);
            ClientsChangeForm.TabIndex = 22;
            ClientsChangeForm.Text = "Clients";
            ClientsChangeForm.Click += ClientsChangeForm_Click;
            // 
            // addANewCarButton
            // 
            addANewCarButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            addANewCarButton.Location = new Point(1099, 84);
            addANewCarButton.Name = "addANewCarButton";
            addANewCarButton.Size = new Size(166, 41);
            addANewCarButton.TabIndex = 23;
            addANewCarButton.Text = "Add a new car";
            addANewCarButton.UseVisualStyleBackColor = true;
            addANewCarButton.Click += addANewCarButton_Click;
            // 
            // CarsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1799, 826);
            Controls.Add(addANewCarButton);
            Controls.Add(ClientsChangeForm);
            Controls.Add(carsChangeForm);
            Controls.Add(endYearTextBox);
            Controls.Add(label8);
            Controls.Add(startYearTextBox);
            Controls.Add(label7);
            Controls.Add(filterButton);
            Controls.Add(modelFilterTextBox);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(carsGrid);
            Controls.Add(infoLabel);
            Controls.Add(yearTextBox);
            Controls.Add(modelTextBox);
            Controls.Add(brandTextBox);
            Controls.Add(button1);
            Controls.Add(chooseBrandTextBox);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CarsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)carsGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)carBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private TextBox chooseBrandTextBox;
        private Button button1;
        private TextBox brandTextBox;
        private TextBox modelTextBox;
        private TextBox yearTextBox;
        private Label infoLabel;
        private ListBox carsListBox;
        private DataGridView carsGrid;
        private DataGridViewTextBoxColumn carIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn brandDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productionYearDataGridViewTextBoxColumn;
        private BindingSource carBindingSource;
        private Label label4;
        private Label label6;
        private TextBox modelFilterTextBox;
        private Button filterButton;
        private Label label7;
        private TextBox startYearTextBox;
        private Label label8;
        private TextBox endYearTextBox;
        private Label carsChangeForm;
        private Label ClientsChangeForm;
        private Button addANewCarButton;
    }
}
