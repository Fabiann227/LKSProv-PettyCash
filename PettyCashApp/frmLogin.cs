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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            sqlserver con = new sqlserver();
            SqlConnection Conn = con.GetConn();

            try
            {
                Conn.Open();
                string kueri = "SELECT role FROM tbl_user WHERE username = '" + tboxUsername.Text + "' AND password = '" + tboxPassword.Text + "'";
                SqlCommand cmd = new SqlCommand(kueri, Conn);

                string role = (string)cmd.ExecuteScalar();
                if (role != null)
                {
                    frmMainMenu main = new frmMainMenu();
                    main.Autentication(tboxUsername.Text, role);
                    main.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Username atau Password salah!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Apakah kamu yakin ingin keluar dari app?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
