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
    public partial class frmKasKeluar : Form
    {
        private string SelectedID;
        private string SaveSection;

        public frmKasKeluar()
        {
            InitializeComponent();
        }

        private void frmKasKeluar_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        void resetText()
        {
            tboxNoBukti.Text = "";
            tboxUntuk.Text = "";
            tboxTipe.Text = "";
            tboxJumlah.Text = "";
        }

        void ShowTextBox()
        {
            tboxGroup.Visible = true;

            btnInsert.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            resetText();
        }

        void ShowTextBoxNores()
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
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            resetText();
        }

        void SearchData()
        {
            sqlserver Con = new sqlserver();
            SqlConnection Conn = Con.GetConn();

            try
            {
                Conn.Open();
                string kueri = "SELECT id_trans, tgl, no_bukti, keterangan, tipe, jumlah FROM tbl_transaksi WHERE tgl = '" + DTsearchData.Text + "'";

                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(kueri, Conn);
                da.Fill(ds, "tbl_transaksi");

                tblDatakas.DataSource = ds;
                tblDatakas.DataMember = "tbl_transaksi";
                tblDatakas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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

                string query = "SELECT id_trans, tgl, no_bukti, keterangan, tipe, jumlah FROM tbl_transaksi";
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(query, Con);

                da.Fill(ds, "tbl_transaksi");
                tblDatakas.DataSource = ds;
                tblDatakas.DataMember = "tbl_transaksi";
                tblDatakas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
            string tbox2 = tboxUntuk.Text.Trim();
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
                    string kueri = "INSERT INTO tbl_transaksi (no_bukti, keterangan, tgl, jumlah, tipe) VALUES ('" + tboxNoBukti.Text + "','" + tboxUntuk.Text + "','" + DTtanggal.Value + "','" + tboxJumlah.Text + "', '" + tboxTipe.Text + "')";

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
                    string kueri = "DELETE FROM tbl_transaksi WHERE id_trans = '" + SelectedID + "'";

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
            string tbox2 = tboxUntuk.Text.Trim();
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
                    string kueri = "UPDATE tbl_transaksi SET no_bukti = '" + tboxNoBukti.Text + "', keterangan = '" + tboxUntuk.Text + "', jumlah = '" + tboxJumlah.Text + "', tgl = '" + DTtanggal.Text + ", tipe = '" + tboxTipe.Text + "' WHERE id = '" + SelectedID + "' WHERE id_trans = '" + SelectedID + "'";

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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            HideTextBox();
            SaveSection = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            tboxGroup.Text = "Update";
            ShowTextBoxNores();
            SaveSection = "Update";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteData();
        }


        private void DTsearchData_ValueChanged_1(object sender, EventArgs e)
        {
            SearchData();
        }

        private void tboxTipe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tboxTipe.SelectedItem == "Kas Masuk")
            {
                tboxUntuk.Enabled = false;
            }
            else
            {
                tboxUntuk.Enabled = true;
            }
        }

        private void tblDatakas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (SaveSection != "insert")
                {
                    DataGridViewRow row = this.tblDatakas.Rows[e.RowIndex];
                    SelectedID = row.Cells["id_trans"].Value.ToString();
                    btnUpdate.Enabled = true;
                    btnDelete.Enabled = true;
                    tboxNoBukti.Text = row.Cells["no_bukti"].Value.ToString();
                    tboxTipe.Text = row.Cells["tipe"].Value.ToString();
                    tboxUntuk.Text = row.Cells["keterangan"].Value.ToString();
                    tboxJumlah.Text = row.Cells["jumlah"].Value.ToString();
                }
            }
        }
    }
}
