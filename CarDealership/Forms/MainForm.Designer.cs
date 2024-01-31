namespace CarDealership.Forms {
    partial class MainForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            topPanel = new Panel();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            exitPicture = new PictureBox();
            panel2 = new Panel();
            clientsChangeForm = new Button();
            carsChangeForm = new Button();
            panelContainer = new Panel();
            topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)exitPicture).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // topPanel
            // 
            topPanel.BackColor = Color.DarkSlateBlue;
            topPanel.Controls.Add(label1);
            topPanel.Controls.Add(pictureBox2);
            topPanel.Controls.Add(exitPicture);
            topPanel.Dock = DockStyle.Top;
            topPanel.Location = new Point(0, 0);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(1600, 33);
            topPanel.TabIndex = 25;
            topPanel.MouseMove += topPanel_MouseMove;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.Location = new Point(678, 5);
            label1.Name = "label1";
            label1.Size = new Size(165, 25);
            label1.TabIndex = 0;
            label1.Text = "Car Dealership";
            label1.MouseDown += topPanel_MouseMove;
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
            pictureBox2.Click += pictureBox2_Click;
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
            exitPicture.Click += exitPicture_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SlateBlue;
            panel2.Controls.Add(clientsChangeForm);
            panel2.Controls.Add(carsChangeForm);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 33);
            panel2.Name = "panel2";
            panel2.Size = new Size(1600, 78);
            panel2.TabIndex = 26;
            // 
            // clientsChangeForm
            // 
            clientsChangeForm.BackColor = Color.Transparent;
            clientsChangeForm.FlatAppearance.BorderSize = 0;
            clientsChangeForm.FlatAppearance.MouseOverBackColor = Color.MediumSlateBlue;
            clientsChangeForm.FlatStyle = FlatStyle.Flat;
            clientsChangeForm.Font = new Font("Tahoma", 24F, FontStyle.Bold, GraphicsUnit.Point, 238);
            clientsChangeForm.Location = new Point(189, 0);
            clientsChangeForm.Name = "clientsChangeForm";
            clientsChangeForm.Size = new Size(183, 78);
            clientsChangeForm.TabIndex = 1;
            clientsChangeForm.Text = "Clients";
            clientsChangeForm.UseVisualStyleBackColor = false;
            clientsChangeForm.Click += ClientsChangeForm_Click;
            // 
            // carsChangeForm
            // 
            carsChangeForm.BackColor = Color.Transparent;
            carsChangeForm.FlatAppearance.BorderSize = 0;
            carsChangeForm.FlatAppearance.MouseOverBackColor = Color.MediumSlateBlue;
            carsChangeForm.FlatStyle = FlatStyle.Flat;
            carsChangeForm.Font = new Font("Tahoma", 24F, FontStyle.Bold, GraphicsUnit.Point, 238);
            carsChangeForm.Location = new Point(0, 0);
            carsChangeForm.Name = "carsChangeForm";
            carsChangeForm.Size = new Size(183, 78);
            carsChangeForm.TabIndex = 0;
            carsChangeForm.Text = "Cars";
            carsChangeForm.UseVisualStyleBackColor = false;
            carsChangeForm.Click += carsChangeForm_Click;
            // 
            // panelContainer
            // 
            panelContainer.Dock = DockStyle.Fill;
            panelContainer.Location = new Point(0, 111);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(1600, 989);
            panelContainer.TabIndex = 27;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1600, 1100);
            Controls.Add(panelContainer);
            Controls.Add(panel2);
            Controls.Add(topPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            Text = "MainForm";
            topPanel.ResumeLayout(false);
            topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)exitPicture).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel topPanel;
        private Panel panel2;
        private Panel panelContainer;
        private Button button1;
        private PictureBox exitPicture;
        private Button carsChangeForm;
        private Button clientsChangeForm;
        private PictureBox pictureBox2;
        private Label label1;
    }
}