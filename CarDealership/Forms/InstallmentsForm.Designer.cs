namespace CarDealership.Forms {
    partial class InstallmentsForm {
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
            installmentsGrid = new DataGridView();
            installmentBindingSource = new BindingSource(components);
            installmentIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            insuranceIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            installmentDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)installmentsGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)installmentBindingSource).BeginInit();
            SuspendLayout();
            // 
            // installmentsGrid
            // 
            installmentsGrid.AutoGenerateColumns = false;
            installmentsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            installmentsGrid.Columns.AddRange(new DataGridViewColumn[] { installmentIDDataGridViewTextBoxColumn, insuranceIDDataGridViewTextBoxColumn, installmentDateDataGridViewTextBoxColumn });
            installmentsGrid.DataSource = installmentBindingSource;
            installmentsGrid.Location = new Point(12, 12);
            installmentsGrid.Name = "installmentsGrid";
            installmentsGrid.Size = new Size(443, 227);
            installmentsGrid.TabIndex = 0;
            // 
            // installmentBindingSource
            // 
            installmentBindingSource.DataSource = typeof(Models.Installment);
            // 
            // installmentIDDataGridViewTextBoxColumn
            // 
            installmentIDDataGridViewTextBoxColumn.DataPropertyName = "InstallmentID";
            installmentIDDataGridViewTextBoxColumn.HeaderText = "InstallmentID";
            installmentIDDataGridViewTextBoxColumn.Name = "installmentIDDataGridViewTextBoxColumn";
            // 
            // insuranceIDDataGridViewTextBoxColumn
            // 
            insuranceIDDataGridViewTextBoxColumn.DataPropertyName = "InsuranceID";
            insuranceIDDataGridViewTextBoxColumn.HeaderText = "InsuranceID";
            insuranceIDDataGridViewTextBoxColumn.Name = "insuranceIDDataGridViewTextBoxColumn";
            // 
            // installmentDateDataGridViewTextBoxColumn
            // 
            installmentDateDataGridViewTextBoxColumn.DataPropertyName = "InstallmentDate";
            installmentDateDataGridViewTextBoxColumn.HeaderText = "InstallmentDate";
            installmentDateDataGridViewTextBoxColumn.Name = "installmentDateDataGridViewTextBoxColumn";
            // 
            // InstallmentsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(480, 251);
            Controls.Add(installmentsGrid);
            Name = "InstallmentsForm";
            Text = "InstallmentsForm";
            ((System.ComponentModel.ISupportInitialize)installmentsGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)installmentBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView installmentsGrid;
        private DataGridViewTextBoxColumn installmentIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn insuranceIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn installmentDateDataGridViewTextBoxColumn;
        private BindingSource installmentBindingSource;
    }
}