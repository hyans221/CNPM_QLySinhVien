namespace DoAn_Nhom7_QuanLySinhVien
{
    partial class frmDangKyHoc
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.dgvDangKyHoc = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.btn_HuyDangKy = new Guna.UI2.WinForms.Guna2Button();
            this.btn_DangKy = new Guna.UI2.WinForms.Guna2Button();
            this.lblNgayDK = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dtPickNgayDangKy = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblMonHocID = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblSinhVienID = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cmbMonHocID = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbSinhVienID = new Guna.UI2.WinForms.Guna2ComboBox();
            this.Panel1.SuspendLayout();
            this.Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDangKyHoc)).BeginInit();
            this.Panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.Controls.Add(this.Panel2);
            this.Panel1.Controls.Add(this.Panel3);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Name = "Panel1";
            this.Panel1.ShadowDecoration.Parent = this.Panel1;
            this.Panel1.Size = new System.Drawing.Size(777, 598);
            this.Panel1.TabIndex = 0;
            // 
            // Panel2
            // 
            this.Panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel2.BorderColor = System.Drawing.Color.DodgerBlue;
            this.Panel2.BorderRadius = 10;
            this.Panel2.BorderThickness = 1;
            this.Panel2.Controls.Add(this.dgvDangKyHoc);
            this.Panel2.Location = new System.Drawing.Point(18, 288);
            this.Panel2.Name = "Panel2";
            this.Panel2.ShadowDecoration.Parent = this.Panel2;
            this.Panel2.Size = new System.Drawing.Size(741, 295);
            this.Panel2.TabIndex = 29;
            // 
            // dgvDangKyHoc
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(203)))), ((int)(((byte)(232)))));
            this.dgvDangKyHoc.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDangKyHoc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDangKyHoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDangKyHoc.BackgroundColor = System.Drawing.Color.White;
            this.dgvDangKyHoc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDangKyHoc.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDangKyHoc.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDangKyHoc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDangKyHoc.ColumnHeadersHeight = 52;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(139)))), ((int)(((byte)(205)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDangKyHoc.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvDangKyHoc.EnableHeadersVisualStyles = false;
            this.dgvDangKyHoc.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(201)))), ((int)(((byte)(231)))));
            this.dgvDangKyHoc.Location = new System.Drawing.Point(20, 16);
            this.dgvDangKyHoc.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDangKyHoc.Name = "dgvDangKyHoc";
            this.dgvDangKyHoc.RowHeadersVisible = false;
            this.dgvDangKyHoc.RowHeadersWidth = 30;
            this.dgvDangKyHoc.RowTemplate.Height = 24;
            this.dgvDangKyHoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDangKyHoc.Size = new System.Drawing.Size(704, 264);
            this.dgvDangKyHoc.TabIndex = 27;
            this.dgvDangKyHoc.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Indigo;
            this.dgvDangKyHoc.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(203)))), ((int)(((byte)(232)))));
            this.dgvDangKyHoc.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvDangKyHoc.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvDangKyHoc.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvDangKyHoc.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvDangKyHoc.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvDangKyHoc.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(201)))), ((int)(((byte)(231)))));
            this.dgvDangKyHoc.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.dgvDangKyHoc.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDangKyHoc.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvDangKyHoc.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDangKyHoc.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvDangKyHoc.ThemeStyle.HeaderStyle.Height = 52;
            this.dgvDangKyHoc.ThemeStyle.ReadOnly = false;
            this.dgvDangKyHoc.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            this.dgvDangKyHoc.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDangKyHoc.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvDangKyHoc.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvDangKyHoc.ThemeStyle.RowsStyle.Height = 24;
            this.dgvDangKyHoc.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(139)))), ((int)(((byte)(205)))));
            this.dgvDangKyHoc.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // Panel3
            // 
            this.Panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel3.BorderColor = System.Drawing.Color.DodgerBlue;
            this.Panel3.BorderRadius = 10;
            this.Panel3.BorderThickness = 1;
            this.Panel3.Controls.Add(this.btn_HuyDangKy);
            this.Panel3.Controls.Add(this.btn_DangKy);
            this.Panel3.Controls.Add(this.lblNgayDK);
            this.Panel3.Controls.Add(this.dtPickNgayDangKy);
            this.Panel3.Controls.Add(this.lblMonHocID);
            this.Panel3.Controls.Add(this.lblSinhVienID);
            this.Panel3.Controls.Add(this.cmbMonHocID);
            this.Panel3.Controls.Add(this.cmbSinhVienID);
            this.Panel3.Location = new System.Drawing.Point(18, 12);
            this.Panel3.Name = "Panel3";
            this.Panel3.ShadowDecoration.Parent = this.Panel3;
            this.Panel3.Size = new System.Drawing.Size(741, 244);
            this.Panel3.TabIndex = 28;
            // 
            // btn_HuyDangKy
            // 
            this.btn_HuyDangKy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_HuyDangKy.BorderRadius = 20;
            this.btn_HuyDangKy.CheckedState.Parent = this.btn_HuyDangKy;
            this.btn_HuyDangKy.CustomImages.Parent = this.btn_HuyDangKy;
            this.btn_HuyDangKy.FillColor = System.Drawing.Color.Firebrick;
            this.btn_HuyDangKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_HuyDangKy.ForeColor = System.Drawing.Color.White;
            this.btn_HuyDangKy.HoverState.Parent = this.btn_HuyDangKy;
            this.btn_HuyDangKy.Location = new System.Drawing.Point(530, 130);
            this.btn_HuyDangKy.Margin = new System.Windows.Forms.Padding(2);
            this.btn_HuyDangKy.Name = "btn_HuyDangKy";
            this.btn_HuyDangKy.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btn_HuyDangKy.ShadowDecoration.Parent = this.btn_HuyDangKy;
            this.btn_HuyDangKy.Size = new System.Drawing.Size(137, 63);
            this.btn_HuyDangKy.TabIndex = 42;
            this.btn_HuyDangKy.Text = "Huỷ Đăng Ký";
            // 
            // btn_DangKy
            // 
            this.btn_DangKy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_DangKy.BorderRadius = 20;
            this.btn_DangKy.CheckedState.Parent = this.btn_DangKy;
            this.btn_DangKy.CustomImages.Parent = this.btn_DangKy;
            this.btn_DangKy.FillColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_DangKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DangKy.ForeColor = System.Drawing.Color.White;
            this.btn_DangKy.HoverState.Parent = this.btn_DangKy;
            this.btn_DangKy.Location = new System.Drawing.Point(530, 53);
            this.btn_DangKy.Margin = new System.Windows.Forms.Padding(2);
            this.btn_DangKy.Name = "btn_DangKy";
            this.btn_DangKy.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btn_DangKy.ShadowDecoration.Parent = this.btn_DangKy;
            this.btn_DangKy.Size = new System.Drawing.Size(137, 63);
            this.btn_DangKy.TabIndex = 41;
            this.btn_DangKy.Text = "Đăng Ký";
            // 
            // lblNgayDK
            // 
            this.lblNgayDK.BackColor = System.Drawing.Color.Transparent;
            this.lblNgayDK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayDK.Location = new System.Drawing.Point(73, 173);
            this.lblNgayDK.Margin = new System.Windows.Forms.Padding(2);
            this.lblNgayDK.Name = "lblNgayDK";
            this.lblNgayDK.Size = new System.Drawing.Size(80, 17);
            this.lblNgayDK.TabIndex = 40;
            this.lblNgayDK.Text = "Ngày Đăng Ký";
            // 
            // dtPickNgayDangKy
            // 
            this.dtPickNgayDangKy.BorderRadius = 20;
            this.dtPickNgayDangKy.CheckedState.Parent = this.dtPickNgayDangKy;
            this.dtPickNgayDangKy.FillColor = System.Drawing.Color.White;
            this.dtPickNgayDangKy.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtPickNgayDangKy.HoverState.Parent = this.dtPickNgayDangKy;
            this.dtPickNgayDangKy.Location = new System.Drawing.Point(177, 165);
            this.dtPickNgayDangKy.Margin = new System.Windows.Forms.Padding(2);
            this.dtPickNgayDangKy.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtPickNgayDangKy.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtPickNgayDangKy.Name = "dtPickNgayDangKy";
            this.dtPickNgayDangKy.ShadowDecoration.Parent = this.dtPickNgayDangKy;
            this.dtPickNgayDangKy.Size = new System.Drawing.Size(219, 35);
            this.dtPickNgayDangKy.TabIndex = 39;
            this.dtPickNgayDangKy.Value = new System.DateTime(2023, 11, 10, 20, 45, 56, 216);
            // 
            // lblMonHocID
            // 
            this.lblMonHocID.BackColor = System.Drawing.Color.Transparent;
            this.lblMonHocID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonHocID.Location = new System.Drawing.Point(73, 114);
            this.lblMonHocID.Margin = new System.Windows.Forms.Padding(2);
            this.lblMonHocID.Name = "lblMonHocID";
            this.lblMonHocID.Size = new System.Drawing.Size(68, 17);
            this.lblMonHocID.TabIndex = 38;
            this.lblMonHocID.Text = "Môn Học ID";
            // 
            // lblSinhVienID
            // 
            this.lblSinhVienID.BackColor = System.Drawing.Color.Transparent;
            this.lblSinhVienID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSinhVienID.Location = new System.Drawing.Point(73, 55);
            this.lblSinhVienID.Margin = new System.Windows.Forms.Padding(2);
            this.lblSinhVienID.Name = "lblSinhVienID";
            this.lblSinhVienID.Size = new System.Drawing.Size(70, 17);
            this.lblSinhVienID.TabIndex = 36;
            this.lblSinhVienID.Text = "Sinh Viên ID";
            // 
            // cmbMonHocID
            // 
            this.cmbMonHocID.BackColor = System.Drawing.Color.Transparent;
            this.cmbMonHocID.BorderRadius = 20;
            this.cmbMonHocID.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbMonHocID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMonHocID.FocusedColor = System.Drawing.Color.Empty;
            this.cmbMonHocID.FocusedState.Parent = this.cmbMonHocID;
            this.cmbMonHocID.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbMonHocID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbMonHocID.FormattingEnabled = true;
            this.cmbMonHocID.HoverState.Parent = this.cmbMonHocID;
            this.cmbMonHocID.ItemHeight = 30;
            this.cmbMonHocID.ItemsAppearance.Parent = this.cmbMonHocID;
            this.cmbMonHocID.Location = new System.Drawing.Point(177, 105);
            this.cmbMonHocID.Margin = new System.Windows.Forms.Padding(2);
            this.cmbMonHocID.Name = "cmbMonHocID";
            this.cmbMonHocID.ShadowDecoration.Parent = this.cmbMonHocID;
            this.cmbMonHocID.Size = new System.Drawing.Size(220, 36);
            this.cmbMonHocID.TabIndex = 37;
            // 
            // cmbSinhVienID
            // 
            this.cmbSinhVienID.BackColor = System.Drawing.Color.Transparent;
            this.cmbSinhVienID.BorderRadius = 20;
            this.cmbSinhVienID.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbSinhVienID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSinhVienID.FocusedColor = System.Drawing.Color.Empty;
            this.cmbSinhVienID.FocusedState.Parent = this.cmbSinhVienID;
            this.cmbSinhVienID.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbSinhVienID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbSinhVienID.FormattingEnabled = true;
            this.cmbSinhVienID.HoverState.Parent = this.cmbSinhVienID;
            this.cmbSinhVienID.ItemHeight = 30;
            this.cmbSinhVienID.ItemsAppearance.Parent = this.cmbSinhVienID;
            this.cmbSinhVienID.Location = new System.Drawing.Point(177, 45);
            this.cmbSinhVienID.Margin = new System.Windows.Forms.Padding(2);
            this.cmbSinhVienID.Name = "cmbSinhVienID";
            this.cmbSinhVienID.ShadowDecoration.Parent = this.cmbSinhVienID;
            this.cmbSinhVienID.Size = new System.Drawing.Size(220, 36);
            this.cmbSinhVienID.TabIndex = 35;
            // 
            // frmDangKyHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 598);
            this.Controls.Add(this.Panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmDangKyHoc";
            this.Text = "Đăng ký học";
            this.Load += new System.EventHandler(this.frmDangKyHoc_Load);
            this.Panel1.ResumeLayout(false);
            this.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDangKyHoc)).EndInit();
            this.Panel3.ResumeLayout(false);
            this.Panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel Panel1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvDangKyHoc;
        internal Guna.UI2.WinForms.Guna2Panel Panel3;
        internal Guna.UI2.WinForms.Guna2Panel Panel2;
        private Guna.UI2.WinForms.Guna2Button btn_HuyDangKy;
        private Guna.UI2.WinForms.Guna2Button btn_DangKy;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblNgayDK;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtPickNgayDangKy;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblMonHocID;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblSinhVienID;
        private Guna.UI2.WinForms.Guna2ComboBox cmbMonHocID;
        private Guna.UI2.WinForms.Guna2ComboBox cmbSinhVienID;
    }
}