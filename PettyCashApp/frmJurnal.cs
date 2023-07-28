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
    public partial class frmJurnal : Form
    {
        public frmJurnal()
        {
            InitializeComponent();
        }

        private void frmJurnal_Load(object sender, EventArgs e)
        {
            
        }

        private void btnload_Click(object sender, EventArgs e)
        {
            this.GetDataByDateBetweenTableAdapter.Fill(this.smkn4DataSet.GetDataByDateBetween, DTfrom.Value, DTto.Value);

            this.reportViewer1.RefreshReport();
        }
    }
}
