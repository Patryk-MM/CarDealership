namespace CarDealership.UserControls {
    partial class UC_Clients {
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
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // carsChangeForm
            // 
            carsChangeForm.AutoSize = true;
            carsChangeForm.Font = new Font("Segoe UI", 72F, FontStyle.Bold, GraphicsUnit.Point, 238);
            carsChangeForm.Location = new Point(501, 198);
            carsChangeForm.Name = "carsChangeForm";
            carsChangeForm.Size = new Size(357, 128);
            carsChangeForm.TabIndex = 23;
            carsChangeForm.Text = "Clients";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(653, 368);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 24;
            // 
            // UC_Clients
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(textBox1);
            Controls.Add(carsChangeForm);
            Name = "UC_Clients";
            Size = new Size(1384, 551);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label carsChangeForm;
        private TextBox textBox1;
    }
}
