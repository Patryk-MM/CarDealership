namespace CarDealership {
    partial class ClientsForm {
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
            ClientsChangeForm = new Label();
            carsChangeForm = new Label();
            SuspendLayout();
            // 
            // ClientsChangeForm
            // 
            ClientsChangeForm.AutoSize = true;
            ClientsChangeForm.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            ClientsChangeForm.Location = new Point(130, 19);
            ClientsChangeForm.Name = "ClientsChangeForm";
            ClientsChangeForm.Size = new Size(79, 30);
            ClientsChangeForm.TabIndex = 24;
            ClientsChangeForm.Text = "Clients";
            // 
            // carsChangeForm
            // 
            carsChangeForm.AutoSize = true;
            carsChangeForm.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            carsChangeForm.Location = new Point(33, 19);
            carsChangeForm.Name = "carsChangeForm";
            carsChangeForm.Size = new Size(54, 30);
            carsChangeForm.TabIndex = 23;
            carsChangeForm.Text = "Cars";
            carsChangeForm.Click += carsChangeForm_Click;
            // 
            // Clients
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1799, 826);
            Controls.Add(ClientsChangeForm);
            Controls.Add(carsChangeForm);
            Name = "Clients";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Clients";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ClientsChangeForm;
        private Label carsChangeForm;
    }
}