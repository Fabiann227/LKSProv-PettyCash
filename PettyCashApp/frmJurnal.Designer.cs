
namespace PettyCashApp
{
    partial class frmJurnal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.GetDataByDateBetweenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.smkn4DataSet = new PettyCashApp.smkn4DataSet();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DTto = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.DTfrom = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnload = new Guna.UI2.WinForms.Guna2Button();
            this.GetDataByDateBetweenTableAdapter = new PettyCashApp.smkn4DataSetTableAdapters.GetDataByDateBetweenTableAdapter();
            this.smkn4DataSet1 = new PettyCashApp.smkn4DataSet();
            ((System.ComponentModel.ISupportInitialize)(this.GetDataByDateBetweenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smkn4DataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.smkn4DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // GetDataByDateBetweenBindingSource
            // 
            this.GetDataByDateBetweenBindingSource.DataMember = "GetDataByDateBetween";
            this.GetDataByDateBetweenBindingSource.DataSource = this.smkn4DataSet;
            // 
            // smkn4DataSet
            // 
            this.smkn4DataSet.DataSetName = "smkn4DataSet";
            this.smkn4DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.reportViewer1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DimGray;
            this.groupBox1.Location = new System.Drawing.Point(13, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(636, 364);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Laporan";
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.GetDataByDateBetweenBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PettyCashApp.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 19);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(630, 342);
            this.reportViewer1.TabIndex = 0;
            // 
            // DTto
            // 
            this.DTto.BorderRadius = 10;
            this.DTto.Checked = true;
            this.DTto.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DTto.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTto.Location = new System.Drawing.Point(368, 23);
            this.DTto.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DTto.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DTto.Name = "DTto";
            this.DTto.Size = new System.Drawing.Size(118, 28);
            this.DTto.TabIndex = 11;
            this.DTto.Value = new System.DateTime(2023, 7, 24, 21, 24, 53, 985);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(286, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "s.d    Tanggal";
            // 
            // DTfrom
            // 
            this.DTfrom.BorderRadius = 10;
            this.DTfrom.Checked = true;
            this.DTfrom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DTfrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTfrom.Location = new System.Drawing.Point(159, 23);
            this.DTfrom.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DTfrom.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DTfrom.Name = "DTfrom";
            this.DTfrom.Size = new System.Drawing.Size(118, 28);
            this.DTfrom.TabIndex = 9;
            this.DTfrom.Value = new System.DateTime(2023, 7, 24, 21, 24, 53, 985);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Data dari Tanggal";
            // 
            // btnload
            // 
            this.btnload.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.btnload.BorderRadius = 12;
            this.btnload.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnload.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnload.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnload.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnload.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnload.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnload.ForeColor = System.Drawing.Color.White;
            this.btnload.Image = global::PettyCashApp.Properties.Resources.icons8_Update_Left_Rotation_50px;
            this.btnload.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnload.Location = new System.Drawing.Point(500, 23);
            this.btnload.Name = "btnload";
            this.btnload.Size = new System.Drawing.Size(77, 28);
            this.btnload.TabIndex = 12;
            this.btnload.Text = "Load";
            this.btnload.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnload.Click += new System.EventHandler(this.btnload_Click);
            // 
            // GetDataByDateBetweenTableAdapter
            // 
            this.GetDataByDateBetweenTableAdapter.ClearBeforeFill = true;
            // 
            // smkn4DataSet1
            // 
            this.smkn4DataSet1.DataSetName = "smkn4DataSet";
            this.smkn4DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // frmJurnal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 538);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnload);
            this.Controls.Add(this.DTto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DTfrom);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmJurnal";
            this.Text = "frmJurnal";
            this.Load += new System.EventHandler(this.frmJurnal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GetDataByDateBetweenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smkn4DataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.smkn4DataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2Button btnload;
        private Guna.UI2.WinForms.Guna2DateTimePicker DTto;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DateTimePicker DTfrom;
        private System.Windows.Forms.Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource GetDataByDateBetweenBindingSource;
        private smkn4DataSet smkn4DataSet;
        private smkn4DataSetTableAdapters.GetDataByDateBetweenTableAdapter GetDataByDateBetweenTableAdapter;
        private smkn4DataSet smkn4DataSet1;
    }
}