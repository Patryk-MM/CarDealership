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
            SuspendLayout();
            // 
            // carsChangeForm
            // 
            carsChangeForm.AutoSize = true;
            carsChangeForm.Font = new Font("Tahoma", 36F, FontStyle.Bold, GraphicsUnit.Point, 238);
            carsChangeForm.Location = new Point(0, 0);
            carsChangeForm.Name = "carsChangeForm";
            carsChangeForm.Size = new Size(193, 58);
            carsChangeForm.TabIndex = 24;
            carsChangeForm.Text = "Filters:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.Location = new Point(125, 75);
            label1.Name = "label1";
            label1.Size = new Size(68, 25);
            label1.TabIndex = 25;
            label1.Text = "Brand";
            // 
            // brandComboBox
            // 
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
            label2.Location = new Point(304, 75);
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
            label3.Location = new Point(394, 75);
            label3.Name = "label3";
            label3.Size = new Size(159, 25);
            label3.TabIndex = 31;
            label3.Text = "Production year";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label4.Location = new Point(576, 75);
            label4.Name = "label4";
            label4.Size = new Size(159, 25);
            label4.TabIndex = 34;
            label4.Text = "Engine capacity";
            // 
            // engCapToComboBox
            // 
            engCapToComboBox.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            engCapToComboBox.FormattingEnabled = true;
            engCapToComboBox.Items.AddRange(new object[] { "1.0", "1.2", "1.4", "1.6", "1.8", "2.0", "2.2", "2.4", "2.6", "2.8", "3.0" });
            engCapToComboBox.Location = new Point(655, 103);
            engCapToComboBox.Name = "engCapToComboBox";
            engCapToComboBox.Size = new Size(80, 33);
            engCapToComboBox.TabIndex = 33;
            // 
            // engCapFromComboBox
            // 
            engCapFromComboBox.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            engCapFromComboBox.FormattingEnabled = true;
            engCapFromComboBox.Items.AddRange(new object[] { "1.0", "1.2", "1.4", "1.6", "1.8", "2.0", "2.2", "2.4", "2.6", "2.8", "3.0" });
            engCapFromComboBox.Location = new Point(569, 103);
            engCapFromComboBox.Name = "engCapFromComboBox";
            engCapFromComboBox.Size = new Size(80, 33);
            engCapFromComboBox.TabIndex = 32;
            // 
            // UC_Cars
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
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
    }
}
