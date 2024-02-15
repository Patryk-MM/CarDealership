using CarDealership.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace CarDealership.Forms {
    public partial class MainForm : Form {

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void topPanel_MouseMove(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        public MainForm() {
            InitializeComponent();
            UC_Cars uc = new UC_Cars();
            addUserControl(uc);
        }
        private void addUserControl(UserControl userControl) {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void carsChangeForm_Click(object sender, EventArgs e) {
            UC_Cars uc = new UC_Cars();
            addUserControl(uc);
        }

        private void exitPicture_Click(object sender, EventArgs e) {
            Close();
        }

        

        private void pictureBox2_Click(object sender, EventArgs e) {
            WindowState = FormWindowState.Minimized;
        }

        private void carsChangeForm_Click_1(object sender, EventArgs e) {

        }
    }
}
