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

namespace Dashboard
{
    public partial class Form1 : Form
    {



        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
    (
        int nLeftRect,
        int nTopRect,
        int nRightRect,
        int nBottomRect,
        int nWidthEllipse,
        int nHeightEllipse
    );
        public Form1()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));

            lblTitle.Text = "Dashbord";
            this.pnlFormLoader.Controls.Clear();
            formMain frmDashboard_vrb = new formMain() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmDashboard_vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(frmDashboard_vrb);
            frmDashboard_vrb.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnHeaters.Height;
            pnlNav.Top = btnHeaters.Top;
            pnlNav.Left = btnHeaters.Left;
            btnHeaters.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Heaters";
            this.pnlFormLoader.Controls.Clear();
            FormHeaters frmDashboard_vrb = new FormHeaters() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmDashboard_vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(frmDashboard_vrb);
            frmDashboard_vrb.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnCyan.Height;
            pnlNav.Top = btnCyan.Top;
            pnlNav.Left = btnCyan.Left;
            btnCyan.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Cyan";
            this.pnlFormLoader.Controls.Clear();
            FormCyan frmDashboard_vrb = new FormCyan() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmDashboard_vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(frmDashboard_vrb);
            frmDashboard_vrb.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            
                pnlNav.Height = btnMain.Height;
                pnlNav.Top = btnMain.Top;
                pnlNav.Left = btnMain.Left;
                btnMain.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Main";
            this.pnlFormLoader.Controls.Clear();
            formMain frmDashboard_vrb = new formMain() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmDashboard_vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(frmDashboard_vrb);
            frmDashboard_vrb.Show();

        }

        private void btnYellow_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnYellow.Height;
            pnlNav.Top = btnYellow.Top;
            pnlNav.Left = btnYellow.Left;
            btnYellow.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Yellow";
            this.pnlFormLoader.Controls.Clear();
            FormYellow frmDashboard_vrb = new FormYellow() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmDashboard_vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(frmDashboard_vrb);
            frmDashboard_vrb.Show();

        }

        private void btnMagenta_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnMagenta.Height;
            pnlNav.Top = btnMagenta.Top;
            pnlNav.Left = btnMagenta.Left;
            btnMagenta.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Magenta";
            this.pnlFormLoader.Controls.Clear();
            FormMagenta frmDashboard_vrb = new FormMagenta() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmDashboard_vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(frmDashboard_vrb);
            frmDashboard_vrb.Show();
        }

        private void btnBlack_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnBlack.Height;
            pnlNav.Top = btnBlack.Top;
            pnlNav.Left = btnBlack.Left;
            btnBlack.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Black";
            this.pnlFormLoader.Controls.Clear();
            FormBlack frmDashboard_vrb = new FormBlack() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmDashboard_vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(frmDashboard_vrb);
            frmDashboard_vrb.Show();
        }

        private void btnRobot_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnRobot.Height;
            pnlNav.Top = btnRobot.Top;
            pnlNav.Left = btnRobot.Left;
            btnRobot.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Robot";
            this.pnlFormLoader.Controls.Clear();
            FormRobot frmDashboard_vrb = new FormRobot() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmDashboard_vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(frmDashboard_vrb);
            frmDashboard_vrb.Show();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnSettings.Height;
            pnlNav.Top = btnSettings.Top;
            pnlNav.Left = btnSettings.Left;
            btnSettings.BackColor = Color.FromArgb(46, 51, 73);


            lblTitle.Text = "Settings";
            this.pnlFormLoader.Controls.Clear();
            FormSettings frmDashboard_vrb = new FormSettings() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmDashboard_vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(frmDashboard_vrb);
            frmDashboard_vrb.Show();
        }

        private void btnMain_Leave(object sender, EventArgs e)
        {
            btnMain.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnYellow_Leave(object sender, EventArgs e)
        {
            btnYellow.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnMagenta_Leave(object sender, EventArgs e)
        {
            btnMagenta.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnCyan_Leave(object sender, EventArgs e)
        {
            btnCyan.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnBlack_Leave(object sender, EventArgs e)
        {
            btnBlack.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnHeaters_Leave(object sender, EventArgs e)
        {
            btnHeaters.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnRobot_Leave(object sender, EventArgs e)
        {
            btnRobot.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnSettings_Leave(object sender, EventArgs e)
        {
            btnSettings.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
