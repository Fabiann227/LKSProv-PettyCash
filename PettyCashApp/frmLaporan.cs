using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PettyCashApp
{
    public partial class frmLaporan : Form
    {
        private string SelectedID;
        private string SaveSection;

        public frmLaporan()
        {
            InitializeComponent();
        }

        void LoadData2()
        {
            sqlserver con = new sqlserver();
            SqlConnection Conn = con.GetConn();

            try
            {
                using (DataTable dt = new DataTable("tbl_laporan"))
                {
                    using (SqlCommand cmd = new SqlCommand("select * from tbl_laporan where tgl between @fromdate and @todate", Conn))
                    {
                        cmd.Parameters.AddWithValue("@fromdate", DTtanggal.Value);
                        cmd.Parameters.AddWithValue("@todate", DTtanggal.Value);
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        da.Fill(dt);
                        tblLaporan.DataSource = dt;
                    }
                }
                Conn.Open();
            }
            catch (Exception g)
            {


                MessageBox.Show(g.Message, "Error");
            }
        }

        private void frmLaporan_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        void resetText()
        {
            tboxNoBukti.Text = "";
            tboxKeterangan.Text = "";
            tboxTipe.Text = "";
            tboxJumlah.Text = "";
        }

        void ShowTextBoxNores()
        {
            tboxGroup.Visible = true;

            btnInsert.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        void ShowTextBox()
        {
            tboxGroup.Visible = true;

            btnInsert.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            resetText();
        }

        void HideTextBox()
        {
            tboxGroup.Visible = false;

            btnInsert.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            resetText();
        }

        void SearchData()
        {
            sqlserver Con = new sqlserver();
            SqlConnection Conn = Con.GetConn();

            try
            {
                Conn.Open();
                string kueri = "SELECT * FROM tbl_laporan WHERE no_bukti LIKE '%" + tboxSearch.Text + "%'";

                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(kueri, Conn);
                da.Fill(ds, "tbl_laporan");

                tblLaporan.DataSource = ds;
                tblLaporan.DataMember = "tbl_laporan";
                tblLaporan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception g)
            {
                MessageBox.Show(g.ToString(), "Error");
            }
            finally
            {
                Conn.Close();
            }
        }
        private void LoadData()
        {
            sqlserver con = new sqlserver();
            SqlConnection Con = con.GetConn();

            try
            {
                Con.Open();

                string query = "SELECT * FROM tbl_laporan";
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(query, Con);

                da.Fill(ds, "tbl_laporan");
                tblLaporan.DataSource = ds;
                tblLaporan.DataMember = "tbl_laporan";
                tblLaporan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                
            }
            catch (Exception g)
            {
                MessageBox.Show(g.ToString(), "Error");

            }
            finally
            {
                Con.Close();
            }
        }

        void InsertData()
        {
            sqlserver con = new sqlserver();
            SqlConnection Conn = con.GetConn();

            string tbox1 = tboxNoBukti.Text.Trim();
            string tbox2 = tboxKeterangan.Text.Trim();
            string tbox3 = tboxJumlah.Text.Trim();
            string tbox4 = tboxTipe.Text.Trim();

            if (string.IsNullOrEmpty(tbox1) || string.IsNullOrEmpty(tbox2) || string.IsNullOrEmpty(tbox3) || string.IsNullOrEmpty(tbox4))
            {
                MessageBox.Show("Isi Semua data!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    Conn.Open();
                    string kueri = "INSERT INTO tbl_laporan (tgl, keterangan, no_bukti, tipe, jumlah) VALUES ('" + DTtanggal.Value + "','" + tboxKeterangan.Text + "','" + tboxNoBukti.Text + "','" + tboxTipe.Text + "', '" + tboxJumlah.Text + "')";

                    SqlCommand cmd = new SqlCommand(kueri, Conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data berhasil di tambahkan", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    HideTextBox();
                }
                catch (Exception g)
                {
                    MessageBox.Show(g.ToString(), "ERROR");
                }
                finally
                {
                    Conn.Close();
                }
            }
        }

        void DeleteData()
        {
            string msg = "Apakah kamu yakin untuk menghapus data ID " + SelectedID + "";

            if (MessageBox.Show(msg, "Delete Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sqlserver con = new sqlserver();
                SqlConnection Conn = con.GetConn();

                try
                {
                    Conn.Open();
                    string kueri = "DELETE FROM tbl_laporan WHERE id = '" + SelectedID + "'";

                    SqlCommand cmd = new SqlCommand(kueri, Conn);
                    cmd.ExecuteNonQuery();
                    LoadData();
                    MessageBox.Show("Data berhasil dihapus", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception g)
                {

                    MessageBox.Show(g.ToString(), "Error");
                }
                finally
                {
                    Conn.Close();
                }
            }
        }

        void UpdateData()
        {
            sqlserver con = new sqlserver();
            SqlConnection Conn = con.GetConn();

            string tbox1 = tboxNoBukti.Text.Trim();
            string tbox2 = tboxKeterangan.Text.Trim();
            string tbox3 = tboxJumlah.Text.Trim();
            string tbox4 = tboxTipe.Text.Trim();

            if (string.IsNullOrEmpty(tbox1) || string.IsNullOrEmpty(tbox2) || string.IsNullOrEmpty(tbox3) || string.IsNullOrEmpty(tbox4))
            {
                MessageBox.Show("Isi Semua data!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    Conn.Open();
                    string kueri = "UPDATE tbl_laporan SET no_bukti = '" + tboxNoBukti.Text + "', keterangan = '" + tboxKeterangan.Text + "', jumlah = '" + tboxJumlah.Text + "', tgl = '" + DTtanggal.Text + "', tipe = '" + tboxTipe.Text + "' WHERE id = '" + SelectedID + "'";

                    SqlCommand cmd = new SqlCommand(kueri, Conn);
                    cmd.ExecuteNonQuery();
                    LoadData();
                    MessageBox.Show("Data berhasil di ubah");
                    HideTextBox();
                }
                catch (Exception g)
                {
                    MessageBox.Show(g.ToString(), "Error");
                }
                finally
                {
                    Conn.Close();
                }
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            tboxGroup.Text = "Insert";
            ShowTextBox();
            SaveSection = "insert";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            tboxGroup.Text = "Update";
            ShowTextBoxNores();
            SaveSection = "Update";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (SaveSection == "insert")
            {
                InsertData();
            }
            else if (SaveSection == "Update")
            {
                UpdateData();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteData();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            HideTextBox();
            SaveSection = "";
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

        private void btnCetakData_Click(object sender, EventArgs e)
        {
            LoadForm(new frmJurnal());
        }

        private void tblLaporan_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                if (SaveSection != "insert")
                {
                    DataGridViewRow row = this.tblLaporan.Rows[e.RowIndex];
                    SelectedID = row.Cells["id"].Value.ToString();
                    btnUpdate.Enabled = true;
                    btnDelete.Enabled = true;
                    tboxNoBukti.Text = row.Cells["no_bukti"].Value.ToString();
                    tboxTipe.Text = row.Cells["tipe"].Value.ToString();
                    tboxKeterangan.Text = row.Cells["keterangan"].Value.ToString();
                    tboxJumlah.Text = row.Cells["jumlah"].Value.ToString();
                }
            }
        }

        private void tboxSearch_TextChanged(object sender, EventArgs e)
        {
            SearchData();
        }
    }
}
