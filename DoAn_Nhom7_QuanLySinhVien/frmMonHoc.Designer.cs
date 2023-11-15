namespace DoAn_Nhom7_QuanLySinhVien
{
    partial class frmMonHoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMonHoc));
            this.Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.dgvMonHoc = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTenGiangVien = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblNgayKetThuc = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblHocPhi = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblTenMH = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblMaMH = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblNgayBatDau = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnXoa = new Guna.UI2.WinForms.Guna2Button();
            this.btnSua = new Guna.UI2.WinForms.Guna2Button();
            this.btnThem = new Guna.UI2.WinForms.Guna2Button();
            this.cmbTenGiangVien = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dtPickerNgayKetThuc = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtPickerNgayBatDau = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnHocPhi = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnTenMH = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnMaMH = new Guna.UI2.WinForms.Guna2TextBox();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonHoc)).BeginInit();
            this.Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel1.BorderColor = System.Drawing.Color.DodgerBlue;
            this.Panel1.BorderRadius = 10;
            this.Panel1.BorderThickness = 1;
            this.Panel1.Controls.Add(this.dgvMonHoc);
            this.Panel1.Location = new System.Drawing.Point(25, 281);
            this.Panel1.Name = "Panel1";
            this.Panel1.ShadowDecoration.Parent = this.Panel1;
            this.Panel1.Size = new System.Drawing.Size(797, 290);
            this.Panel1.TabIndex = 28;
            // 
            // dgvMonHoc
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvMonHoc.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMonHoc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMonHoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMonHoc.BackgroundColor = System.Drawing.Color.White;
            this.dgvMonHoc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMonHoc.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvMonHoc.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMonHoc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMonHoc.ColumnHeadersHeight = 4;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMonHoc.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMonHoc.EnableHeadersVisualStyles = false;
            this.dgvMonHoc.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvMonHoc.Location = new System.Drawing.Point(24, 17);
            this.dgvMonHoc.Margin = new System.Windows.Forms.Padding(2);
            this.dgvMonHoc.Name = "dgvMonHoc";
            this.dgvMonHoc.RowHeadersVisible = false;
            this.dgvMonHoc.RowHeadersWidth = 51;
            this.dgvMonHoc.RowTemplate.Height = 24;
            this.dgvMonHoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMonHoc.Size = new System.Drawing.Size(753, 258);
            this.dgvMonHoc.TabIndex = 31;
            this.dgvMonHoc.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgvMonHoc.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvMonHoc.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvMonHoc.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvMonHoc.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvMonHoc.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvMonHoc.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvMonHoc.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvMonHoc.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvMonHoc.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvMonHoc.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvMonHoc.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvMonHoc.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvMonHoc.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvMonHoc.ThemeStyle.ReadOnly = false;
            this.dgvMonHoc.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvMonHoc.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvMonHoc.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvMonHoc.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvMonHoc.ThemeStyle.RowsStyle.Height = 24;
            this.dgvMonHoc.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvMonHoc.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // Panel2
            // 
            this.Panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel2.BorderColor = System.Drawing.Color.DodgerBlue;
            this.Panel2.BorderRadius = 10;
            this.Panel2.BorderThickness = 1;
            this.Panel2.Controls.Add(this.lblTenGiangVien);
            this.Panel2.Controls.Add(this.lblNgayKetThuc);
            this.Panel2.Controls.Add(this.lblHocPhi);
            this.Panel2.Controls.Add(this.lblTenMH);
            this.Panel2.Controls.Add(this.lblMaMH);
            this.Panel2.Controls.Add(this.lblNgayBatDau);
            this.Panel2.Controls.Add(this.btnXoa);
            this.Panel2.Controls.Add(this.btnSua);
            this.Panel2.Controls.Add(this.btnThem);
            this.Panel2.Controls.Add(this.cmbTenGiangVien);
            this.Panel2.Controls.Add(this.dtPickerNgayKetThuc);
            this.Panel2.Controls.Add(this.dtPickerNgayBatDau);
            this.Panel2.Controls.Add(this.btnHocPhi);
            this.Panel2.Controls.Add(this.btnTenMH);
            this.Panel2.Controls.Add(this.btnMaMH);
            this.Panel2.Location = new System.Drawing.Point(25, 12);
            this.Panel2.Name = "Panel2";
            this.Panel2.ShadowDecoration.Parent = this.Panel2;
            this.Panel2.Size = new System.Drawing.Size(797, 250);
            this.Panel2.TabIndex = 29;
            // 
            // lblTenGiangVien
            // 
            this.lblTenGiangVien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTenGiangVien.BackColor = System.Drawing.Color.Transparent;
            this.lblTenGiangVien.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenGiangVien.Location = new System.Drawing.Point(400, 92);
            this.lblTenGiangVien.Name = "lblTenGiangVien";
            this.lblTenGiangVien.Size = new System.Drawing.Size(72, 17);
            this.lblTenGiangVien.TabIndex = 42;
            this.lblTenGiangVien.Text = "Tên giảng viên";
            // 
            // lblNgayKetThuc
            // 
            this.lblNgayKetThuc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNgayKetThuc.BackColor = System.Drawing.Color.Transparent;
            this.lblNgayKetThuc.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayKetThuc.Location = new System.Drawing.Point(568, 14);
            this.lblNgayKetThuc.Name = "lblNgayKetThuc";
            this.lblNgayKetThuc.Size = new System.Drawing.Size(71, 17);
            this.lblNgayKetThuc.TabIndex = 42;
            this.lblNgayKetThuc.Text = "Ngày kết thúc";
            // 
            // lblHocPhi
            // 
            this.lblHocPhi.BackColor = System.Drawing.Color.Transparent;
            this.lblHocPhi.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHocPhi.Location = new System.Drawing.Point(22, 172);
            this.lblHocPhi.Name = "lblHocPhi";
            this.lblHocPhi.Size = new System.Drawing.Size(42, 17);
            this.lblHocPhi.TabIndex = 42;
            this.lblHocPhi.Text = "Học phí";
            // 
            // lblTenMH
            // 
            this.lblTenMH.BackColor = System.Drawing.Color.Transparent;
            this.lblTenMH.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenMH.Location = new System.Drawing.Point(22, 95);
            this.lblTenMH.Name = "lblTenMH";
            this.lblTenMH.Size = new System.Drawing.Size(66, 17);
            this.lblTenMH.TabIndex = 42;
            this.lblTenMH.Text = "Tên môn học";
            // 
            // lblMaMH
            // 
            this.lblMaMH.BackColor = System.Drawing.Color.Transparent;
            this.lblMaMH.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaMH.Location = new System.Drawing.Point(22, 18);
            this.lblMaMH.Name = "lblMaMH";
            this.lblMaMH.Size = new System.Drawing.Size(64, 17);
            this.lblMaMH.TabIndex = 42;
            this.lblMaMH.Text = "Mã môn học";
            // 
            // lblNgayBatDau
            // 
            this.lblNgayBatDau.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNgayBatDau.BackColor = System.Drawing.Color.Transparent;
            this.lblNgayBatDau.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayBatDau.Location = new System.Drawing.Point(361, 14);
            this.lblNgayBatDau.Name = "lblNgayBatDau";
            this.lblNgayBatDau.Size = new System.Drawing.Size(67, 17);
            this.lblNgayBatDau.TabIndex = 42;
            this.lblNgayBatDau.Text = "Ngày bắt đầu";
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoa.BorderRadius = 20;
            this.btnXoa.CheckedState.Parent = this.btnXoa;
            this.btnXoa.CustomImages.Parent = this.btnXoa;
            this.btnXoa.FillColor = System.Drawing.Color.Firebrick;
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.HoverState.Parent = this.btnXoa;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnXoa.ImageSize = new System.Drawing.Size(30, 30);
            this.btnXoa.Location = new System.Drawing.Point(662, 185);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ShadowDecoration.Parent = this.btnXoa;
            this.btnXoa.Size = new System.Drawing.Size(102, 41);
            this.btnXoa.TabIndex = 41;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnSua
            // 
            this.btnSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSua.BorderRadius = 20;
            this.btnSua.CheckedState.Parent = this.btnSua;
            this.btnSua.CustomImages.Parent = this.btnSua;
            this.btnSua.FillColor = System.Drawing.Color.DarkSeaGreen;
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.HoverState.Parent = this.btnSua;
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSua.ImageSize = new System.Drawing.Size(30, 30);
            this.btnSua.Location = new System.Drawing.Point(517, 185);
            this.btnSua.Name = "btnSua";
            this.btnSua.ShadowDecoration.Parent = this.btnSua;
            this.btnSua.Size = new System.Drawing.Size(102, 41);
            this.btnSua.TabIndex = 40;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnThem
            // 
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThem.BorderRadius = 20;
            this.btnThem.CheckedState.Parent = this.btnThem;
            this.btnThem.CustomImages.Parent = this.btnThem;
            this.btnThem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(94)))), ((int)(((byte)(121)))));
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.HoverState.Parent = this.btnThem;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnThem.ImageSize = new System.Drawing.Size(30, 30);
            this.btnThem.Location = new System.Drawing.Point(372, 185);
            this.btnThem.Name = "btnThem";
            this.btnThem.ShadowDecoration.Parent = this.btnThem;
            this.btnThem.Size = new System.Drawing.Size(102, 41);
            this.btnThem.TabIndex = 39;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cmbTenGiangVien
            // 
            this.cmbTenGiangVien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbTenGiangVien.BackColor = System.Drawing.Color.Transparent;
            this.cmbTenGiangVien.BorderRadius = 20;
            this.cmbTenGiangVien.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbTenGiangVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTenGiangVien.FocusedColor = System.Drawing.Color.Empty;
            this.cmbTenGiangVien.FocusedState.Parent = this.cmbTenGiangVien;
            this.cmbTenGiangVien.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTenGiangVien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbTenGiangVien.FormattingEnabled = true;
            this.cmbTenGiangVien.HoverState.Parent = this.cmbTenGiangVien;
            this.cmbTenGiangVien.ItemHeight = 30;
            this.cmbTenGiangVien.ItemsAppearance.Parent = this.cmbTenGiangVien;
            this.cmbTenGiangVien.Location = new System.Drawing.Point(423, 112);
            this.cmbTenGiangVien.Margin = new System.Windows.Forms.Padding(2);
            this.cmbTenGiangVien.Name = "cmbTenGiangVien";
            this.cmbTenGiangVien.ShadowDecoration.Parent = this.cmbTenGiangVien;
            this.cmbTenGiangVien.Size = new System.Drawing.Size(282, 36);
            this.cmbTenGiangVien.TabIndex = 38;
            // 
            // dtPickerNgayKetThuc
            // 
            this.dtPickerNgayKetThuc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtPickerNgayKetThuc.BorderColor = System.Drawing.Color.DodgerBlue;
            this.dtPickerNgayKetThuc.BorderRadius = 10;
            this.dtPickerNgayKetThuc.BorderThickness = 1;
            this.dtPickerNgayKetThuc.CheckedState.Parent = this.dtPickerNgayKetThuc;
            this.dtPickerNgayKetThuc.FillColor = System.Drawing.Color.White;
            this.dtPickerNgayKetThuc.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPickerNgayKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPickerNgayKetThuc.HoverState.Parent = this.dtPickerNgayKetThuc;
            this.dtPickerNgayKetThuc.Location = new System.Drawing.Point(607, 35);
            this.dtPickerNgayKetThuc.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtPickerNgayKetThuc.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtPickerNgayKetThuc.Name = "dtPickerNgayKetThuc";
            this.dtPickerNgayKetThuc.ShadowDecoration.Parent = this.dtPickerNgayKetThuc;
            this.dtPickerNgayKetThuc.Size = new System.Drawing.Size(124, 36);
            this.dtPickerNgayKetThuc.TabIndex = 36;
            this.dtPickerNgayKetThuc.Value = new System.DateTime(2021, 7, 5, 12, 52, 33, 197);
            // 
            // dtPickerNgayBatDau
            // 
            this.dtPickerNgayBatDau.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtPickerNgayBatDau.BorderColor = System.Drawing.Color.DodgerBlue;
            this.dtPickerNgayBatDau.BorderRadius = 10;
            this.dtPickerNgayBatDau.BorderThickness = 1;
            this.dtPickerNgayBatDau.CheckedState.Parent = this.dtPickerNgayBatDau;
            this.dtPickerNgayBatDau.FillColor = System.Drawing.Color.White;
            this.dtPickerNgayBatDau.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPickerNgayBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPickerNgayBatDau.HoverState.Parent = this.dtPickerNgayBatDau;
            this.dtPickerNgayBatDau.Location = new System.Drawing.Point(385, 35);
            this.dtPickerNgayBatDau.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtPickerNgayBatDau.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtPickerNgayBatDau.Name = "dtPickerNgayBatDau";
            this.dtPickerNgayBatDau.ShadowDecoration.Parent = this.dtPickerNgayBatDau;
            this.dtPickerNgayBatDau.Size = new System.Drawing.Size(124, 36);
            this.dtPickerNgayBatDau.TabIndex = 37;
            this.dtPickerNgayBatDau.Value = new System.DateTime(2021, 7, 5, 12, 52, 33, 197);
            // 
            // btnHocPhi
            // 
            this.btnHocPhi.AutoRoundedCorners = true;
            this.btnHocPhi.BorderRadius = 21;
            this.btnHocPhi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btnHocPhi.DefaultText = "";
            this.btnHocPhi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.btnHocPhi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.btnHocPhi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.btnHocPhi.DisabledState.Parent = this.btnHocPhi;
            this.btnHocPhi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.btnHocPhi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnHocPhi.FocusedState.Parent = this.btnHocPhi;
            this.btnHocPhi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHocPhi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnHocPhi.HoverState.Parent = this.btnHocPhi;
            this.btnHocPhi.Location = new System.Drawing.Point(50, 189);
            this.btnHocPhi.Margin = new System.Windows.Forms.Padding(11, 9, 11, 9);
            this.btnHocPhi.Name = "btnHocPhi";
            this.btnHocPhi.PasswordChar = '\0';
            this.btnHocPhi.PlaceholderText = "Nhập Học Phí";
            this.btnHocPhi.SelectedText = "";
            this.btnHocPhi.ShadowDecoration.Parent = this.btnHocPhi;
            this.btnHocPhi.Size = new System.Drawing.Size(255, 44);
            this.btnHocPhi.TabIndex = 34;
            this.btnHocPhi.TextOffset = new System.Drawing.Point(8, 0);
            // 
            // btnTenMH
            // 
            this.btnTenMH.AutoRoundedCorners = true;
            this.btnTenMH.BorderRadius = 21;
            this.btnTenMH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btnTenMH.DefaultText = "";
            this.btnTenMH.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.btnTenMH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.btnTenMH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.btnTenMH.DisabledState.Parent = this.btnTenMH;
            this.btnTenMH.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.btnTenMH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnTenMH.FocusedState.Parent = this.btnTenMH;
            this.btnTenMH.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTenMH.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnTenMH.HoverState.Parent = this.btnTenMH;
            this.btnTenMH.Location = new System.Drawing.Point(50, 112);
            this.btnTenMH.Margin = new System.Windows.Forms.Padding(11, 9, 11, 9);
            this.btnTenMH.Name = "btnTenMH";
            this.btnTenMH.PasswordChar = '\0';
            this.btnTenMH.PlaceholderText = "Nhập Tên Môn Học";
            this.btnTenMH.SelectedText = "";
            this.btnTenMH.ShadowDecoration.Parent = this.btnTenMH;
            this.btnTenMH.Size = new System.Drawing.Size(255, 44);
            this.btnTenMH.TabIndex = 35;
            this.btnTenMH.TextOffset = new System.Drawing.Point(8, 0);
            // 
            // btnMaMH
            // 
            this.btnMaMH.AutoRoundedCorners = true;
            this.btnMaMH.BorderRadius = 21;
            this.btnMaMH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btnMaMH.DefaultText = "";
            this.btnMaMH.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.btnMaMH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.btnMaMH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.btnMaMH.DisabledState.Parent = this.btnMaMH;
            this.btnMaMH.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.btnMaMH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnMaMH.FocusedState.Parent = this.btnMaMH;
            this.btnMaMH.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaMH.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnMaMH.HoverState.Parent = this.btnMaMH;
            this.btnMaMH.Location = new System.Drawing.Point(50, 35);
            this.btnMaMH.Margin = new System.Windows.Forms.Padding(11, 9, 11, 9);
            this.btnMaMH.Name = "btnMaMH";
            this.btnMaMH.PasswordChar = '\0';
            this.btnMaMH.PlaceholderText = "Nhập Mã Môn Học";
            this.btnMaMH.SelectedText = "";
            this.btnMaMH.ShadowDecoration.Parent = this.btnMaMH;
            this.btnMaMH.Size = new System.Drawing.Size(255, 44);
            this.btnMaMH.TabIndex = 33;
            this.btnMaMH.TextOffset = new System.Drawing.Point(8, 0);
            // 
            // frmMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 581);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.Panel2);
            this.Name = "frmMonHoc";
            this.Text = "frmMonHoc";
            this.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonHoc)).EndInit();
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Guna.UI2.WinForms.Guna2Panel Panel1;
        internal Guna.UI2.WinForms.Guna2Panel Panel2;
        private Guna.UI2.WinForms.Guna2DataGridView dgvMonHoc;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblNgayBatDau;
        internal Guna.UI2.WinForms.Guna2Button btnXoa;
        internal Guna.UI2.WinForms.Guna2Button btnSua;
        internal Guna.UI2.WinForms.Guna2Button btnThem;
        private Guna.UI2.WinForms.Guna2ComboBox cmbTenGiangVien;
        internal Guna.UI2.WinForms.Guna2DateTimePicker dtPickerNgayKetThuc;
        internal Guna.UI2.WinForms.Guna2DateTimePicker dtPickerNgayBatDau;
        private Guna.UI2.WinForms.Guna2TextBox btnHocPhi;
        private Guna.UI2.WinForms.Guna2TextBox btnTenMH;
        private Guna.UI2.WinForms.Guna2TextBox btnMaMH;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTenGiangVien;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblNgayKetThuc;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblHocPhi;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTenMH;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblMaMH;
    }
}