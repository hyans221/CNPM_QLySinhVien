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
    public partial class frmDangNhap : Form
    {
        DBConnect dbConnect = new DBConnect();
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            ShadowForm1.SetShadowForm(this);
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            string password = txtPassword.Text;

            string sql = $"SELECT Quyen FROM TAIKHOAN WHERE TenDangNhap = '{username}' AND MatKhau = '{password}'";
            object result = dbConnect.getScalar(sql);

            if (result != null)
            {
                this.Hide();

                string role = result.ToString();

                if (role == "Admin")
                {
                    frmAdmin adminForm = new frmAdmin();
                    adminForm.FormClosed += (s, args) => this.Show();
                    adminForm.Show();
                }
                else if (role == "User")
                {
                    frmTrangChu homeForm = new frmTrangChu();
                    homeForm.FormClosed += (s, args) => this.Show();
                    homeForm.Show();
                }
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
        }
    }
}
