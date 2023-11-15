namespace DoAn_Nhom7_QuanLySinhVien
{
    partial class frmDiem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDiem));
            this.Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.dgvDiem = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblDiem = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblMaMH = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblMaSV = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnSuaDiem = new Guna.UI2.WinForms.Guna2Button();
            this.btnNhapDiem = new Guna.UI2.WinForms.Guna2Button();
            this.txtDiem = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMaMH = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtMaSV = new Guna.UI2.WinForms.Guna2ComboBox();
            this.Panel1.SuspendLayout();
            this.Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiem)).BeginInit();
            this.Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.Controls.Add(this.Panel3);
            this.Panel1.Controls.Add(this.Panel2);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Margin = new System.Windows.Forms.Padding(2);
            this.Panel1.Name = "Panel1";
            this.Panel1.ShadowDecoration.Parent = this.Panel1;
            this.Panel1.Size = new System.Drawing.Size(1026, 597);
            this.Panel1.TabIndex = 1;
            // 
            // Panel3
            // 
            this.Panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel3.BorderColor = System.Drawing.Color.DodgerBlue;
            this.Panel3.BorderRadius = 10;
            this.Panel3.BorderThickness = 1;
            this.Panel3.Controls.Add(this.dgvDiem);
            this.Panel3.Location = new System.Drawing.Point(496, 17);
            this.Panel3.Name = "Panel3";
            this.Panel3.ShadowDecoration.Parent = this.Panel3;
            this.Panel3.Size = new System.Drawing.Size(518, 552);
            this.Panel3.TabIndex = 31;
            // 
            // dgvDiem
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvDiem.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDiem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDiem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDiem.BackgroundColor = System.Drawing.Color.White;
            this.dgvDiem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDiem.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDiem.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDiem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDiem.ColumnHeadersHeight = 4;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDiem.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvDiem.EnableHeadersVisualStyles = false;
            this.dgvDiem.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDiem.Location = new System.Drawing.Point(22, 21);
            this.dgvDiem.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDiem.Name = "dgvDiem";
            this.dgvDiem.RowHeadersVisible = false;
            this.dgvDiem.RowHeadersWidth = 51;
            this.dgvDiem.RowTemplate.Height = 24;
            this.dgvDiem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDiem.Size = new System.Drawing.Size(474, 508);
            this.dgvDiem.TabIndex = 1;
            this.dgvDiem.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgvDiem.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDiem.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvDiem.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvDiem.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvDiem.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvDiem.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvDiem.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDiem.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvDiem.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDiem.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvDiem.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDiem.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvDiem.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvDiem.ThemeStyle.ReadOnly = false;
            this.dgvDiem.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDiem.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDiem.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvDiem.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvDiem.ThemeStyle.RowsStyle.Height = 24;
            this.dgvDiem.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDiem.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // Panel2
            // 
            this.Panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Panel2.BorderColor = System.Drawing.Color.DodgerBlue;
            this.Panel2.BorderRadius = 10;
            this.Panel2.BorderThickness = 1;
            this.Panel2.Controls.Add(this.lblDiem);
            this.Panel2.Controls.Add(this.lblMaMH);
            this.Panel2.Controls.Add(this.lblMaSV);
            this.Panel2.Controls.Add(this.btnSuaDiem);
            this.Panel2.Controls.Add(this.btnNhapDiem);
            this.Panel2.Controls.Add(this.txtDiem);
            this.Panel2.Controls.Add(this.txtMaMH);
            this.Panel2.Controls.Add(this.txtMaSV);
            this.Panel2.Location = new System.Drawing.Point(22, 17);
            this.Panel2.Name = "Panel2";
            this.Panel2.ShadowDecoration.Parent = this.Panel2;
            this.Panel2.Size = new System.Drawing.Size(456, 552);
            this.Panel2.TabIndex = 30;
            // 
            // lblDiem
            // 
            this.lblDiem.BackColor = System.Drawing.Color.Transparent;
            this.lblDiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiem.Location = new System.Drawing.Point(85, 162);
            this.lblDiem.Margin = new System.Windows.Forms.Padding(2);
            this.lblDiem.Name = "lblDiem";
            this.lblDiem.Size = new System.Drawing.Size(33, 17);
            this.lblDiem.TabIndex = 39;
            this.lblDiem.Text = "Điểm";
            // 
            // lblMaMH
            // 
            this.lblMaMH.BackColor = System.Drawing.Color.Transparent;
            this.lblMaMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaMH.Location = new System.Drawing.Point(85, 99);
            this.lblMaMH.Margin = new System.Windows.Forms.Padding(2);
            this.lblMaMH.Name = "lblMaMH";
            this.lblMaMH.Size = new System.Drawing.Size(72, 17);
            this.lblMaMH.TabIndex = 39;
            this.lblMaMH.Text = "Mã môn học";
            // 
            // lblMaSV
            // 
            this.lblMaSV.BackColor = System.Drawing.Color.Transparent;
            this.lblMaSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaSV.Location = new System.Drawing.Point(85, 32);
            this.lblMaSV.Margin = new System.Windows.Forms.Padding(2);
            this.lblMaSV.Name = "lblMaSV";
            this.lblMaSV.Size = new System.Drawing.Size(72, 17);
            this.lblMaSV.TabIndex = 39;
            this.lblMaSV.Text = "Mã sinh viên";
            // 
            // btnSuaDiem
            // 
            this.btnSuaDiem.AutoRoundedCorners = true;
            this.btnSuaDiem.BorderColor = System.Drawing.Color.Transparent;
            this.btnSuaDiem.BorderRadius = 25;
            this.btnSuaDiem.BorderThickness = 1;
            this.btnSuaDiem.CheckedState.Parent = this.btnSuaDiem;
            this.btnSuaDiem.CustomImages.Parent = this.btnSuaDiem;
            this.btnSuaDiem.FillColor = System.Drawing.Color.DarkSeaGreen;
            this.btnSuaDiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaDiem.ForeColor = System.Drawing.Color.Black;
            this.btnSuaDiem.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(48)))), ((int)(((byte)(100)))));
            this.btnSuaDiem.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnSuaDiem.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(48)))), ((int)(((byte)(100)))));
            this.btnSuaDiem.HoverState.Parent = this.btnSuaDiem;
            this.btnSuaDiem.ImageSize = new System.Drawing.Size(30, 30);
            this.btnSuaDiem.Location = new System.Drawing.Point(245, 264);
            this.btnSuaDiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSuaDiem.Name = "btnSuaDiem";
            this.btnSuaDiem.ShadowDecoration.Parent = this.btnSuaDiem;
            this.btnSuaDiem.Size = new System.Drawing.Size(174, 53);
            this.btnSuaDiem.TabIndex = 37;
            this.btnSuaDiem.Text = "Sửa Điểm";
            // 
            // btnNhapDiem
            // 
            this.btnNhapDiem.AutoRoundedCorners = true;
            this.btnNhapDiem.BorderColor = System.Drawing.Color.Transparent;
            this.btnNhapDiem.BorderRadius = 25;
            this.btnNhapDiem.BorderThickness = 1;
            this.btnNhapDiem.CheckedState.Parent = this.btnNhapDiem;
            this.btnNhapDiem.CustomImages.Parent = this.btnNhapDiem;
            this.btnNhapDiem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(94)))), ((int)(((byte)(121)))));
            this.btnNhapDiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhapDiem.ForeColor = System.Drawing.Color.Black;
            this.btnNhapDiem.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(48)))), ((int)(((byte)(100)))));
            this.btnNhapDiem.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnNhapDiem.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(48)))), ((int)(((byte)(100)))));
            this.btnNhapDiem.HoverState.Parent = this.btnNhapDiem;
            this.btnNhapDiem.Image = ((System.Drawing.Image)(resources.GetObject("btnNhapDiem.Image")));
            this.btnNhapDiem.ImageSize = new System.Drawing.Size(30, 30);
            this.btnNhapDiem.Location = new System.Drawing.Point(37, 264);
            this.btnNhapDiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNhapDiem.Name = "btnNhapDiem";
            this.btnNhapDiem.ShadowDecoration.Parent = this.btnNhapDiem;
            this.btnNhapDiem.Size = new System.Drawing.Size(177, 53);
            this.btnNhapDiem.TabIndex = 38;
            this.btnNhapDiem.Text = "Cập Nhật Điểm";
            // 
            // txtDiem
            // 
            this.txtDiem.AutoRoundedCorners = true;
            this.txtDiem.BorderRadius = 17;
            this.txtDiem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiem.DefaultText = "";
            this.txtDiem.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiem.DisabledState.Parent = this.txtDiem;
            this.txtDiem.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiem.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiem.FocusedState.Parent = this.txtDiem;
            this.txtDiem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiem.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiem.HoverState.Parent = this.txtDiem;
            this.txtDiem.Location = new System.Drawing.Point(112, 184);
            this.txtDiem.Margin = new System.Windows.Forms.Padding(11, 7, 11, 7);
            this.txtDiem.Name = "txtDiem";
            this.txtDiem.PasswordChar = '\0';
            this.txtDiem.PlaceholderText = "Nhập điểm số";
            this.txtDiem.SelectedText = "";
            this.txtDiem.ShadowDecoration.Parent = this.txtDiem;
            this.txtDiem.Size = new System.Drawing.Size(245, 36);
            this.txtDiem.TabIndex = 36;
            this.txtDiem.TextOffset = new System.Drawing.Point(8, 0);
            // 
            // txtMaMH
            // 
            this.txtMaMH.BackColor = System.Drawing.Color.Transparent;
            this.txtMaMH.BorderRadius = 20;
            this.txtMaMH.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtMaMH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtMaMH.FocusedColor = System.Drawing.Color.Empty;
            this.txtMaMH.FocusedState.Parent = this.txtMaMH;
            this.txtMaMH.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaMH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.txtMaMH.FormattingEnabled = true;
            this.txtMaMH.HoverState.Parent = this.txtMaMH;
            this.txtMaMH.ItemHeight = 30;
            this.txtMaMH.ItemsAppearance.Parent = this.txtMaMH;
            this.txtMaMH.Location = new System.Drawing.Point(112, 120);
            this.txtMaMH.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaMH.Name = "txtMaMH";
            this.txtMaMH.ShadowDecoration.Parent = this.txtMaMH;
            this.txtMaMH.Size = new System.Drawing.Size(245, 36);
            this.txtMaMH.TabIndex = 34;
            // 
            // txtMaSV
            // 
            this.txtMaSV.BackColor = System.Drawing.Color.Transparent;
            this.txtMaSV.BorderRadius = 20;
            this.txtMaSV.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtMaSV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtMaSV.FocusedColor = System.Drawing.Color.Empty;
            this.txtMaSV.FocusedState.Parent = this.txtMaSV;
            this.txtMaSV.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaSV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.txtMaSV.FormattingEnabled = true;
            this.txtMaSV.HoverState.Parent = this.txtMaSV;
            this.txtMaSV.ItemHeight = 30;
            this.txtMaSV.ItemsAppearance.Parent = this.txtMaSV;
            this.txtMaSV.Location = new System.Drawing.Point(112, 52);
            this.txtMaSV.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.ShadowDecoration.Parent = this.txtMaSV;
            this.txtMaSV.Size = new System.Drawing.Size(245, 36);
            this.txtMaSV.TabIndex = 35;
            // 
            // frmDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 597);
            this.Controls.Add(this.Panel1);
            this.Name = "frmDiem";
            this.Text = "frmDiem";
            this.Panel1.ResumeLayout(false);
            this.Panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiem)).EndInit();
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel Panel1;
        internal Guna.UI2.WinForms.Guna2Panel Panel2;
        private Guna.UI2.WinForms.Guna2Button btnSuaDiem;
        private Guna.UI2.WinForms.Guna2Button btnNhapDiem;
        private Guna.UI2.WinForms.Guna2TextBox txtDiem;
        private Guna.UI2.WinForms.Guna2ComboBox txtMaMH;
        private Guna.UI2.WinForms.Guna2ComboBox txtMaSV;
        internal Guna.UI2.WinForms.Guna2Panel Panel3;
        private Guna.UI2.WinForms.Guna2DataGridView dgvDiem;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblDiem;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblMaMH;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblMaSV;
    }
}