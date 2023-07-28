
namespace PettyCashApp
{
    partial class frmKasKeluar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tblDatakas = new Guna.UI2.WinForms.Guna2DataGridView();
            this.tboxGroup = new System.Windows.Forms.GroupBox();
            this.tboxTipe = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tboxJumlah = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tboxUntuk = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DTtanggal = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.tboxNoBukti = new Guna.UI2.WinForms.Guna2TextBox();
            this.DTsearchData = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.btnInsert = new Guna.UI2.WinForms.Guna2Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblDatakas)).BeginInit();
            this.tboxGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tblDatakas);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DimGray;
            this.groupBox1.Location = new System.Drawing.Point(13, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(635, 321);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data";
            // 
            // tblDatakas
            // 
            this.tblDatakas.AllowUserToAddRows = false;
            this.tblDatakas.AllowUserToDeleteRows = false;
            this.tblDatakas.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.tblDatakas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblDatakas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tblDatakas.ColumnHeadersHeight = 35;
            this.tblDatakas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tblDatakas.DefaultCellStyle = dataGridViewCellStyle3;
            this.tblDatakas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblDatakas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tblDatakas.Location = new System.Drawing.Point(3, 19);
            this.tblDatakas.Name = "tblDatakas";
            this.tblDatakas.ReadOnly = true;
            this.tblDatakas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblDatakas.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.tblDatakas.RowHeadersVisible = false;
            this.tblDatakas.RowTemplate.Height = 28;
            this.tblDatakas.Size = new System.Drawing.Size(629, 299);
            this.tblDatakas.TabIndex = 0;
            this.tblDatakas.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.tblDatakas.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblDatakas.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tblDatakas.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tblDatakas.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.tblDatakas.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.tblDatakas.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tblDatakas.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(56)))));
            this.tblDatakas.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tblDatakas.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblDatakas.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.tblDatakas.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.tblDatakas.ThemeStyle.HeaderStyle.Height = 35;
            this.tblDatakas.ThemeStyle.ReadOnly = true;
            this.tblDatakas.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.tblDatakas.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tblDatakas.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblDatakas.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.DimGray;
            this.tblDatakas.ThemeStyle.RowsStyle.Height = 28;
            this.tblDatakas.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tblDatakas.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.tblDatakas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblDatakas_CellClick);
            // 
            // tboxGroup
            // 
            this.tboxGroup.Controls.Add(this.tboxTipe);
            this.tboxGroup.Controls.Add(this.btnCancel);
            this.tboxGroup.Controls.Add(this.label4);
            this.tboxGroup.Controls.Add(this.tboxJumlah);
            this.tboxGroup.Controls.Add(this.btnSave);
            this.tboxGroup.Controls.Add(this.label3);
            this.tboxGroup.Controls.Add(this.tboxUntuk);
            this.tboxGroup.Controls.Add(this.label2);
            this.tboxGroup.Controls.Add(this.DTtanggal);
            this.tboxGroup.Controls.Add(this.label1);
            this.tboxGroup.Controls.Add(this.tboxNoBukti);
            this.tboxGroup.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxGroup.ForeColor = System.Drawing.Color.DimGray;
            this.tboxGroup.Location = new System.Drawing.Point(12, 389);
            this.tboxGroup.Name = "tboxGroup";
            this.tboxGroup.Size = new System.Drawing.Size(505, 137);
            this.tboxGroup.TabIndex = 3;
            this.tboxGroup.TabStop = false;
            this.tboxGroup.Text = "Update";
            this.tboxGroup.Visible = false;
            // 
            // tboxTipe
            // 
            this.tboxTipe.BackColor = System.Drawing.Color.Transparent;
            this.tboxTipe.BorderRadius = 8;
            this.tboxTipe.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.tboxTipe.DropDownHeight = 90;
            this.tboxTipe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tboxTipe.DropDownWidth = 120;
            this.tboxTipe.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tboxTipe.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tboxTipe.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tboxTipe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.tboxTipe.IntegralHeight = false;
            this.tboxTipe.ItemHeight = 20;
            this.tboxTipe.Items.AddRange(new object[] {
            "Kas Masuk",
            "Kas Keluar"});
            this.tboxTipe.Location = new System.Drawing.Point(244, 21);
            this.tboxTipe.Name = "tboxTipe";
            this.tboxTipe.Size = new System.Drawing.Size(149, 26);
            this.tboxTipe.StartIndex = 0;
            this.tboxTipe.TabIndex = 10;
            this.tboxTipe.SelectedIndexChanged += new System.EventHandler(this.tboxTipe_SelectedIndexChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.BorderRadius = 8;
            this.btnCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancel.FillColor = System.Drawing.Color.Maroon;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Image = global::PettyCashApp.Properties.Resources.icons8_cancel_26px;
            this.btnCancel.Location = new System.Drawing.Point(450, 23);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(39, 28);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(209, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Jumlah";
            // 
            // tboxJumlah
            // 
            this.tboxJumlah.BorderRadius = 8;
            this.tboxJumlah.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tboxJumlah.DefaultText = "";
            this.tboxJumlah.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tboxJumlah.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tboxJumlah.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tboxJumlah.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tboxJumlah.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tboxJumlah.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tboxJumlah.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tboxJumlah.Location = new System.Drawing.Point(276, 101);
            this.tboxJumlah.Name = "tboxJumlah";
            this.tboxJumlah.PasswordChar = '\0';
            this.tboxJumlah.PlaceholderText = "";
            this.tboxJumlah.SelectedText = "";
            this.tboxJumlah.Size = new System.Drawing.Size(117, 23);
            this.tboxJumlah.TabIndex = 7;
            // 
            // btnSave
            // 
            this.btnSave.BorderRadius = 8;
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(56)))));
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = global::PettyCashApp.Properties.Resources.icons8_save_as_24px;
            this.btnSave.Location = new System.Drawing.Point(405, 23);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(39, 28);
            this.btnSave.TabIndex = 4;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(209, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Untuk Keperluan";
            // 
            // tboxUntuk
            // 
            this.tboxUntuk.BorderRadius = 8;
            this.tboxUntuk.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tboxUntuk.DefaultText = "";
            this.tboxUntuk.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tboxUntuk.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tboxUntuk.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tboxUntuk.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tboxUntuk.Enabled = false;
            this.tboxUntuk.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tboxUntuk.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tboxUntuk.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tboxUntuk.Location = new System.Drawing.Point(310, 61);
            this.tboxUntuk.Name = "tboxUntuk";
            this.tboxUntuk.PasswordChar = '\0';
            this.tboxUntuk.PlaceholderText = "";
            this.tboxUntuk.SelectedText = "";
            this.tboxUntuk.Size = new System.Drawing.Size(83, 23);
            this.tboxUntuk.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(209, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tipe";
            // 
            // DTtanggal
            // 
            this.DTtanggal.BorderRadius = 8;
            this.DTtanggal.Checked = true;
            this.DTtanggal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DTtanggal.ForeColor = System.Drawing.Color.Black;
            this.DTtanggal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTtanggal.Location = new System.Drawing.Point(21, 61);
            this.DTtanggal.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DTtanggal.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DTtanggal.Name = "DTtanggal";
            this.DTtanggal.Size = new System.Drawing.Size(177, 27);
            this.DTtanggal.TabIndex = 2;
            this.DTtanggal.Value = new System.DateTime(2023, 7, 24, 19, 33, 26, 702);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(18, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "No Bukti";
            // 
            // tboxNoBukti
            // 
            this.tboxNoBukti.BorderRadius = 8;
            this.tboxNoBukti.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tboxNoBukti.DefaultText = "";
            this.tboxNoBukti.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tboxNoBukti.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tboxNoBukti.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tboxNoBukti.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tboxNoBukti.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tboxNoBukti.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tboxNoBukti.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tboxNoBukti.Location = new System.Drawing.Point(78, 21);
            this.tboxNoBukti.Name = "tboxNoBukti";
            this.tboxNoBukti.PasswordChar = '\0';
            this.tboxNoBukti.PlaceholderText = "";
            this.tboxNoBukti.SelectedText = "";
            this.tboxNoBukti.Size = new System.Drawing.Size(120, 23);
            this.tboxNoBukti.TabIndex = 0;
            // 
            // DTsearchData
            // 
            this.DTsearchData.BorderRadius = 10;
            this.DTsearchData.Checked = true;
            this.DTsearchData.CustomFormat = "yyyy-m-dd";
            this.DTsearchData.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DTsearchData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTsearchData.Location = new System.Drawing.Point(524, 17);
            this.DTsearchData.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DTsearchData.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DTsearchData.Name = "DTsearchData";
            this.DTsearchData.Size = new System.Drawing.Size(121, 28);
            this.DTsearchData.TabIndex = 1;
            this.DTsearchData.Value = new System.DateTime(2023, 7, 24, 20, 8, 23, 606);
            this.DTsearchData.ValueChanged += new System.EventHandler(this.DTsearchData_ValueChanged_1);
            // 
            // btnDelete
            // 
            this.btnDelete.BorderRadius = 8;
            this.btnDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDelete.Enabled = false;
            this.btnDelete.FillColor = System.Drawing.Color.Maroon;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Image = global::PettyCashApp.Properties.Resources.icons8_delete_26px;
            this.btnDelete.ImageSize = new System.Drawing.Size(18, 18);
            this.btnDelete.Location = new System.Drawing.Point(103, 15);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(39, 28);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BorderRadius = 8;
            this.btnUpdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdate.Enabled = false;
            this.btnUpdate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(56)))));
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Image = global::PettyCashApp.Properties.Resources.icons8_up_circular_26px;
            this.btnUpdate.ImageSize = new System.Drawing.Size(18, 18);
            this.btnUpdate.Location = new System.Drawing.Point(58, 15);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(39, 28);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.BorderRadius = 8;
            this.btnInsert.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnInsert.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnInsert.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnInsert.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnInsert.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(56)))));
            this.btnInsert.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnInsert.ForeColor = System.Drawing.Color.White;
            this.btnInsert.Image = global::PettyCashApp.Properties.Resources.icons8_add_database_26px;
            this.btnInsert.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnInsert.ImageSize = new System.Drawing.Size(18, 18);
            this.btnInsert.Location = new System.Drawing.Point(13, 15);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(39, 28);
            this.btnInsert.TabIndex = 6;
            this.btnInsert.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // frmKasKeluar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 538);
            this.Controls.Add(this.DTsearchData);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.tboxGroup);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmKasKeluar";
            this.Text = "frmKasKeluar";
            this.Load += new System.EventHandler(this.frmKasKeluar_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tblDatakas)).EndInit();
            this.tboxGroup.ResumeLayout(false);
            this.tboxGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox tboxGroup;
        private Guna.UI2.WinForms.Guna2TextBox tboxNoBukti;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox tboxJumlah;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox tboxUntuk;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DateTimePicker DTtanggal;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Guna.UI2.WinForms.Guna2Button btnInsert;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2DataGridView tblDatakas;
        private Guna.UI2.WinForms.Guna2DateTimePicker DTsearchData;
        private Guna.UI2.WinForms.Guna2ComboBox tboxTipe;
    }
}