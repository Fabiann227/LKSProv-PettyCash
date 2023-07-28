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
    public partial class frmDaftarUser : Form
    {
        private string SelectedID;
        private string SaveSection;

        public frmDaftarUser()
        {
            InitializeComponent();
        }

        private void frmDaftarUser_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        void resetText()
        {
            tboxKodeUser.Text = "";
            tboxUsername.Text = "";
            tboxPassword.Text = "";
            tboxLevel.Text = "";
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
                string kueri = "SELECT * FROM tbl_user WHERE username LIKE '%" + tboxSearch.Text + "%' OR kode_user LIKE '%" + tboxSearch.Text + "%'";

                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(kueri, Conn);
                da.Fill(ds, "tbl_user");

                tblDataUser.DataSource = ds;
                tblDataUser.DataMember = "tbl_user";
                tblDataUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
        void LoadData()
        {
            sqlserver con = new sqlserver();
            SqlConnection Con = con.GetConn();

            try
            {
                Con.Open();

                string query = "SELECT * FROM tbl_user";
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(query, Con);

                da.Fill(ds, "tbl_user");
                tblDataUser.DataSource = ds;
                tblDataUser.DataMember = "tbl_user";
                tblDataUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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

            string tbox1 = tboxKodeUser.Text.Trim();
            string tbox2 = tboxUsername.Text.Trim();
            string tbox3 = tboxPassword.Text.Trim();
            string tbox4 = tboxLevel.Text.Trim();

            if (string.IsNullOrEmpty(tbox1) || string.IsNullOrEmpty(tbox2) || string.IsNullOrEmpty(tbox3) || string.IsNullOrEmpty(tbox4))
            {
                MessageBox.Show("Isi Semua data!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    Conn.Open();
                    string kueri = "INSERT INTO tbl_user (kode_user, username, password, role) VALUES ('" + tboxKodeUser.Text + "','" + tboxUsername.Text + "','" + tboxPassword.Text + "','" + tboxLevel.Text + "')";

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
                    string kueri = "DELETE FROM tbl_user WHERE id_user = '" + SelectedID + "'";

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

            string tbox1 = tboxKodeUser.Text.Trim();
            string tbox2 = tboxUsername.Text.Trim();
            string tbox3 = tboxPassword.Text.Trim();
            string tbox4 = tboxLevel.Text.Trim();

            if (string.IsNullOrEmpty(tbox1) || string.IsNullOrEmpty(tbox2) || string.IsNullOrEmpty(tbox3) || string.IsNullOrEmpty(tbox4))
            {
                MessageBox.Show("Isi Semua data!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    Conn.Open();
                    string kueri = "UPDATE tbl_user SET kode_user = '" + tboxKodeUser.Text + "', username = '" + tboxUsername.Text + "', password = '" + tboxPassword.Text + "', role = '" + tboxLevel.Text + "' WHERE id_user = '" + SelectedID + "'";

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

        private void tblDataUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (SaveSection != "insert")
                {
                    DataGridViewRow row = this.tblDataUser.Rows[e.RowIndex];
                    SelectedID = row.Cells["id_user"].Value.ToString();
                    btnUpdate.Enabled = true;
                    btnDelete.Enabled = true;
                    tboxKodeUser.Text = row.Cells["kode_user"].Value.ToString();
                    tboxUsername.Text = row.Cells["username"].Value.ToString();
                    tboxPassword.Text = row.Cells["password"].Value.ToString();
                    tboxLevel.Text = row.Cells["role"].Value.ToString();
                }
                
            }
        }

        private void tboxSearch_TextChanged(object sender, EventArgs e)
        {
            SearchData();
        }
    }
}
