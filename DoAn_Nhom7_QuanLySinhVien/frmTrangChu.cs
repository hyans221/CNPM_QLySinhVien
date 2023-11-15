using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_Nhom7_QuanLySinhVien
{
    public partial class frmTrangChu : Form
    {
        public frmTrangChu()
        {
            InitializeComponent();
        }

        private void frmTrangChu_Load(object sender, EventArgs e)
        {
            ShadowForm1.SetShadowForm(this);
        }

        private void container(object _form)
        {

            if (Panel_container.Controls.Count > 0) Panel_container.Controls.Clear();

            Form frm = _form as Form;
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            Panel_container.Controls.Add(frm);
            Panel_container.Tag = frm;
            frm.Show();

        }

        private void btnQL_SinhVien_Click(object sender, EventArgs e)
        {
            labelTitleFrm.Text = "QUẢN LÝ SINH VIÊN";
            container(new frmSinhVien());   
        }

        private void btnQL_GiangVien_Click(object sender, EventArgs e)
        {
            labelTitleFrm.Text = "QUẢN LÝ GIẢNG VIÊN";
            container(new frmGiangVien());
        }

        private void btnDangkyHoc_Click(object sender, EventArgs e)
        {
            labelTitleFrm.Text = "QUẢN LÝ ĐĂNG KÝ HỌC";
            container(new frmDangKyHoc());
        }

        private void btnQL_Diem_Click(object sender, EventArgs e)
        {
            labelTitleFrm.Text = "QUẢN LÝ ĐIỂM";
            container(new frmDiem());
        }

        private void btnQL_MonHoc_Click(object sender, EventArgs e)
        {
            labelTitleFrm.Text = "QUẢN LÝ MÔN HỌC";
            container(new frmMonHoc());
        }

        private void btnQL_Khoa_Click(object sender, EventArgs e)
        {
            labelTitleFrm.Text = "QUẢN LÝ KHOA";
            container(new frmKhoa());
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            labelTitleFrm.Text = "QUẢN LÝ BÁO CÁO";
            container(new frmReport());
        }

        private void btnToggle_Click(object sender, EventArgs e)
        {
            ToggleSidebar();
        }

        private const int SidebarMinWidth = 50; 
        private const int SidebarMaxWidth = 205; 

        private void ToggleSidebar()
        {
            if (panelSidebar.Width > SidebarMinWidth)
            {
                panelSidebar.Width = SidebarMinWidth;
            }
            else
            {
                panelSidebar.Width = SidebarMaxWidth;
            }

            AdjustFormSize(); 
        }


        private void AdjustFormSize()
        {
            foreach (Form frm in this.Controls.OfType<Form>())
            {
                frm.Location = new Point(panelSidebar.Width, frm.Location.Y);
                frm.Width = this.ClientSize.Width - panelSidebar.Width;
                frm.Height = this.ClientSize.Height; 
            }
        }

        
    }
}
