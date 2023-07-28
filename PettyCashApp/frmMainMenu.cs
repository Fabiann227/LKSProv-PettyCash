using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PettyCashApp
{
    public partial class frmMainMenu : Form
    {
        Button currentButton;

        public frmMainMenu()
        {
            InitializeComponent();
            MouveForm.Mouve.Go(panelHeader);

            chartHari();
        }

        void chartHari()
        {
            chart.Reset();
            chart.YAxes.GridLines.Display = false;
            chart.Legend.Display = false;
            chart.Title.Text = "Pengeluaran";

            var dataset = new Guna.Charts.WinForms.GunaBarDataset();

            dataset.DataPoints.Add("Senin", 0);
            dataset.DataPoints.Add("Selasa", 200.000);
            dataset.DataPoints.Add("Rabu", 100.000);
            dataset.DataPoints.Add("Kamis", 0);
            dataset.DataPoints.Add("Jumat", 0);
            dataset.DataPoints.Add("Sabtu", 0);
            dataset.DataPoints.Add("Minggu", 0);

            chart.Datasets.Add(dataset);

            chart.Update();
        }

        void chartBulan()
        {
            chart.Reset();

            chart.YAxes.GridLines.Display = false;
            chart.Legend.Display = false;
            chart.Title.Text = "Pengeluaran";

            var dataset = new Guna.Charts.WinForms.GunaBarDataset();

            dataset.DataPoints.Add("January", 8000000);
            dataset.DataPoints.Add("February", 1900000);
            dataset.DataPoints.Add("March", 2800000);
            dataset.DataPoints.Add("April", 4400000);
            dataset.DataPoints.Add("May", 3600000);
            dataset.DataPoints.Add("June", 5000000);
            dataset.DataPoints.Add("July", 6000000);

            chart.Datasets.Add(dataset);

            chart.Update();
        }

        void chartTahun()
        {
            chart.Reset();
            chart.YAxes.GridLines.Display = false;
            chart.Legend.Display = false;
            chart.Title.Text = "Pengeluaran";

            var dataset = new Guna.Charts.WinForms.GunaBarDataset();

            dataset.DataPoints.Add("2019", 1300000);
            dataset.DataPoints.Add("2020", 2300000);
            dataset.DataPoints.Add("2021", 5700000);
            dataset.DataPoints.Add("2022", 6400000);
            dataset.DataPoints.Add("2023", 11300000);

            chart.Datasets.Add(dataset);

            chart.Update();
        }

        public void Autentication(string username, string lvl)
        {
            if (lvl == "Admin")
            {

            }
            else if (lvl == "Super Admin")
            {

            }

            lblUsername.Text = "Hi, " + username;
        }

        void LoadForm(object Form)
        {
            if (this.mainPanel.Controls.Count > 0)
                this.mainPanel.Controls.RemoveAt(0);

            mainPanel.Visible = true;
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(f);

            f.Show();
        }

        void activebutton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    resetbutton();
                    currentButton = (Button)btnSender;
                    activeNavBar.Height = currentButton.Height;
                    activeNavBar.Top = currentButton.Top;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        void resetbutton()
        {
            btnDashboard.BackColor = Color.FromArgb(31, 31, 56);
            btnDashboard.ForeColor = Color.Gainsboro;
            btnDashboard.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            btnDaftarUser.BackColor = Color.FromArgb(31, 31, 56);
            btnDaftarUser.ForeColor = Color.Gainsboro;
            btnDaftarUser.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            btnLaporan.BackColor = Color.FromArgb(31, 31, 56);
            btnLaporan.ForeColor = Color.Gainsboro;
            btnLaporan.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            btnDaftarAkun.BackColor = Color.FromArgb(31, 31, 56);
            btnDaftarAkun.ForeColor = Color.Gainsboro;
            btnDaftarAkun.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            btnKasKeluar.BackColor = Color.FromArgb(31, 31, 56);
            btnKasKeluar.ForeColor = Color.Gainsboro;
            btnKasKeluar.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            activebutton(sender);
            mainPanel.Visible = false;
        }

        private void btnDaftarUser_Click(object sender, EventArgs e)
        {
            activebutton(sender);
            LoadForm(new frmDaftarUser());
        }

        private void btnDaftarAkun_Click(object sender, EventArgs e)
        {
            activebutton(sender);
            LoadForm(new frmDataAkun());
        }

        private void btnKasKeluar_Click(object sender, EventArgs e)
        {
            activebutton(sender);
            LoadForm(new frmKasKeluar());
        }

        private void btnLaporan_Click(object sender, EventArgs e)
        {
            activebutton(sender);
            LoadForm(new frmLaporan());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah kamu yakin ingin keluar dari akun ini?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                frmLogin login = new frmLogin();
                login.Show();
                this.Hide();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah kamu yakin ingin keluar dari app?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        void resetBtn()
        {
            btnHari.FillColor = System.Drawing.Color.White;
            btnHari.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));

            btnBulan.FillColor = System.Drawing.Color.White;
            btnBulan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));

            btnTahun.FillColor = System.Drawing.Color.White;
            btnTahun.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
        }

        private void btnHari_Click(object sender, EventArgs e)
        {
            resetBtn();
            btnHari.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            btnHari.ForeColor = System.Drawing.Color.White;

            lblMasuk.Text = "Rp 300.000";
            lblKeluar.Text = "Rp 100.000";
            lblSaldo.Text = "Rp 500.000";
            chartHari();

        }

        private void btnBulan_Click(object sender, EventArgs e)
        {
            resetBtn();
            btnBulan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            btnBulan.ForeColor = System.Drawing.Color.White;

            lblMasuk.Text = "Rp 2.000.000";
            lblKeluar.Text = "Rp 900.000";
            lblSaldo.Text = "Rp 3.000.000";

            
            chartBulan();
        }

        private void btnTahun_Click(object sender, EventArgs e)
        {
            resetBtn();
            btnTahun.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            btnTahun.ForeColor = System.Drawing.Color.White;

            lblMasuk.Text = "Rp 17.000.000";
            lblKeluar.Text = "Rp 10.900.000";
            lblSaldo.Text = "Rp 19.000.000";

            chartTahun();
        }
    }

}
