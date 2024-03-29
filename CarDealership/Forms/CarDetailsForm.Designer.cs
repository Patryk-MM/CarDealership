﻿namespace CarDealership {
    partial class CarDetailsForm {
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarDetailsForm));
            carNameLabel = new Label();
            topPanel = new Panel();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            exitPicture = new PictureBox();
            carBindingSource = new BindingSource(components);
            carPropertyGrid = new PropertyGrid();
            optionComboBox = new ComboBox();
            detailsDataGrid = new DataGridView();
            reservationBindingSource = new BindingSource(components);
            label1 = new Label();
            cancelButton = new Button();
            saveButton = new Button();
            topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)exitPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)carBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)detailsDataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)reservationBindingSource).BeginInit();
            SuspendLayout();
            // 
            // carNameLabel
            // 
            carNameLabel.AutoSize = true;
            carNameLabel.Font = new Font("Tahoma", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            carNameLabel.ImageAlign = ContentAlignment.MiddleLeft;
            carNameLabel.Location = new Point(46, 49);
            carNameLabel.Name = "carNameLabel";
            carNameLabel.Size = new Size(103, 35);
            carNameLabel.TabIndex = 0;
            carNameLabel.Text = "label1";
            // 
            // topPanel
            // 
            topPanel.BackColor = Color.DarkSlateBlue;
            topPanel.Controls.Add(pictureBox1);
            topPanel.Controls.Add(pictureBox2);
            topPanel.Controls.Add(exitPicture);
            topPanel.Dock = DockStyle.Top;
            topPanel.Location = new Point(0, 0);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(1000, 33);
            topPanel.TabIndex = 26;
            topPanel.MouseMove += topPanel_MouseMove;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.close;
            pictureBox1.Location = new Point(968, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 27;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1536, 1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 30);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // exitPicture
            // 
            exitPicture.Image = Properties.Resources.close;
            exitPicture.Location = new Point(1569, 2);
            exitPicture.Name = "exitPicture";
            exitPicture.Size = new Size(30, 30);
            exitPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            exitPicture.TabIndex = 0;
            exitPicture.TabStop = false;
            // 
            // carBindingSource
            // 
            carBindingSource.DataSource = typeof(Models.Car);
            // 
            // carPropertyGrid
            // 
            carPropertyGrid.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            carPropertyGrid.HelpVisible = false;
            carPropertyGrid.Location = new Point(46, 87);
            carPropertyGrid.Name = "carPropertyGrid";
            carPropertyGrid.PropertySort = PropertySort.NoSort;
            carPropertyGrid.Size = new Size(907, 155);
            carPropertyGrid.TabIndex = 27;
            carPropertyGrid.ToolbarVisible = false;
            carPropertyGrid.PropertyValueChanged += carPropertyGrid_PropertyValueChanged;
            // 
            // optionComboBox
            // 
            optionComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            optionComboBox.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            optionComboBox.FormattingEnabled = true;
            optionComboBox.Items.AddRange(new object[] { "Insurances", "Repairs", "Reservations" });
            optionComboBox.Location = new Point(46, 314);
            optionComboBox.Name = "optionComboBox";
            optionComboBox.Size = new Size(121, 26);
            optionComboBox.TabIndex = 28;
            optionComboBox.SelectedValueChanged += optionComboBox_SelectedValueChanged;
            // 
            // detailsDataGrid
            // 
            detailsDataGrid.AllowUserToAddRows = false;
            detailsDataGrid.AllowUserToDeleteRows = false;
            detailsDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            detailsDataGrid.Location = new Point(46, 378);
            detailsDataGrid.Name = "detailsDataGrid";
            detailsDataGrid.ReadOnly = true;
            detailsDataGrid.Size = new Size(907, 150);
            detailsDataGrid.TabIndex = 29;
            detailsDataGrid.CellMouseDoubleClick += detailsDataGrid_CellMouseDoubleClick;
            // 
            // reservationBindingSource
            // 
            reservationBindingSource.DataSource = typeof(Models.Reservation);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(46, 286);
            label1.Name = "label1";
            label1.Size = new Size(296, 25);
            label1.TabIndex = 30;
            label1.Text = "Select an option to display:";
            // 
            // cancelButton
            // 
            cancelButton.BackColor = Color.Transparent;
            cancelButton.FlatAppearance.BorderSize = 0;
            cancelButton.FlatAppearance.MouseOverBackColor = Color.MediumSlateBlue;
            cancelButton.FlatStyle = FlatStyle.Flat;
            cancelButton.Font = new Font("Tahoma", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            cancelButton.Location = new Point(737, 568);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(216, 78);
            cancelButton.TabIndex = 60;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = false;
            cancelButton.Click += cancelButton_Click;
            // 
            // saveButton
            // 
            saveButton.BackColor = Color.Transparent;
            saveButton.FlatAppearance.BorderSize = 0;
            saveButton.FlatAppearance.MouseOverBackColor = Color.MediumSlateBlue;
            saveButton.FlatStyle = FlatStyle.Flat;
            saveButton.Font = new Font("Tahoma", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            saveButton.Location = new Point(515, 568);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(216, 78);
            saveButton.TabIndex = 61;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = false;
            saveButton.Click += saveButton_Click;
            // 
            // CarDetailsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 667);
            Controls.Add(saveButton);
            Controls.Add(cancelButton);
            Controls.Add(label1);
            Controls.Add(detailsDataGrid);
            Controls.Add(optionComboBox);
            Controls.Add(carPropertyGrid);
            Controls.Add(topPanel);
            Controls.Add(carNameLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CarDetailsForm";
            Text = "CarDetails";
            topPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)exitPicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)carBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)detailsDataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)reservationBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label carNameLabel;
        private Panel topPanel;
        private PictureBox pictureBox2;
        private PictureBox exitPicture;
        private PictureBox pictureBox1;
        private BindingSource carBindingSource;
        private PropertyGrid carPropertyGrid;
        private ComboBox optionComboBox;
        private DataGridView detailsDataGrid;
        private BindingSource reservationBindingSource;
        private Label label1;
        private Button cancelButton;
        private Button saveButton;
    }
}