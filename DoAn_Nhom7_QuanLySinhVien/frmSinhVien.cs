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
    public partial class frmSinhVien : Form
    {
        DBConnect dbConnect = new DBConnect();
        public frmSinhVien()
        {
            InitializeComponent();
            LoadSinhVienData();
            LoadLopData();
        }

        private void LoadSinhVienData()
        {
            string sql = "SELECT * FROM SINHVIEN";
            DataTable dt = dbConnect.getDatatable(sql);
            dgvSinhVien.DataSource = dt;
        }

        private void LoadLopData()
        {
            // Replace this with your code to load class data from your database.
            // For example, you can fetch class names from a "Lop" table.
            string sql = "SELECT DISTINCT Lop FROM SINHVIEN";
            DataTable dt = dbConnect.getDatatable(sql);

            // Bind the DataTable to the ComboBox.
            cmbLop.DataSource = dt;
            cmbLop.DisplayMember = "Lop"; // Display the class names.
            cmbLop.ValueMember = "Lop"; // Set the underlying value.
            cmbLop.SelectedIndex = -1; // Clear the selection.
        }


        private void btnSua_Click(object sender, EventArgs e)
        {
            string maSV = txtSinhVienID.Text.Trim();
            string hoTen = txtHoTen.Text.Trim().Replace("'", "''");
            string ngaySinh = dtPickerNgaySinh.Value.ToString("yyyy-MM-dd");
            string gioiTinh = radNam.Checked ? "Nam" : "Nữ";
            string lop = cmbLop.Text.Trim().Replace("'", "''");
            string email = txtEmail.Text.Trim().Replace("'", "''");
            string sdt = txtSoDienThoai.Text.Trim().Replace("'", "''");

            if (string.IsNullOrEmpty(maSV))
            {
                MessageBox.Show("Bạn cần chọn một sinh viên để sửa.");
                return;
            }

            try
            {
                string sql = $"UPDATE SINHVIEN SET HoTen = N'{hoTen}', NgaySinh = '{ngaySinh}', " +
                             $"GioiTinh = '{gioiTinh}', Lop = N'{lop}', Email = '{email}', SoDienThoai = '{sdt}' " +
                             $"WHERE SinhVienID = '{maSV}'";
                dbConnect.getNonQuery(sql);
                LoadSinhVienData();

                MessageBox.Show("Cập nhật thông tin sinh viên thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maSV = txtSinhVienID.Text.Trim();

            if (string.IsNullOrEmpty(maSV))
            {
                MessageBox.Show("Bạn cần chọn một sinh viên để xóa.");
                return;
            }

            try
            {
                string sql = $"DELETE FROM SINHVIEN WHERE SinhVienID = '{maSV}'";
                dbConnect.getNonQuery(sql);
                LoadSinhVienData();

                MessageBox.Show("Xóa sinh viên thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSinhVienID.Text) || string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("ID và Tên không được để trống.");
                return;
            }

            try
            {
                string maSV = txtSinhVienID.Text.Trim();
                string hoTen = txtHoTen.Text.Trim().Replace("'", "''");
                string ngaySinh = dtPickerNgaySinh.Value.ToString("yyyy-MM-dd");
                string gioiTinh = radNam.Checked ? "Nam" : "Nữ";
                string lop = cmbLop.Text.Trim().Replace("'", "''");
                string email = txtEmail.Text.Trim().Replace("'", "''");
                string sdt = txtSoDienThoai.Text.Trim().Replace("'", "''");

                string sql = $"INSERT INTO SINHVIEN (SinhVienID, HoTen, NgaySinh, GioiTinh, Lop, Email, SoDienThoai) " +
                             $"VALUES ('{maSV}', N'{hoTen}', '{ngaySinh}', '{gioiTinh}', N'{lop}', '{email}', '{sdt}')";
                dbConnect.getNonQuery(sql);
                LoadSinhVienData();

                MessageBox.Show("Thêm sinh viên thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtSinhVienID.Clear();
            txtHoTen.Clear();
            dtPickerNgaySinh.Value = DateTime.Now;
            cmbLop.SelectedIndex = -1;
            txtEmail.Clear();
            txtSoDienThoai.Clear();

            radNam.Checked = false;
            radNu.Checked = false;
        }

        private void dgvSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvSinhVien.Rows[e.RowIndex];
                txtSinhVienID.Text = row.Cells["SinhVienID"].Value.ToString().Trim();
                txtHoTen.Text = row.Cells["HoTen"].Value.ToString();

                if (row.Cells["NgaySinh"].Value != DBNull.Value)
                {
                    dtPickerNgaySinh.Value = Convert.ToDateTime(row.Cells["NgaySinh"].Value);
                }
                else
                {
                    dtPickerNgaySinh.Value = dtPickerNgaySinh.MinDate;
                }

                string gioiTinh = row.Cells["GioiTinh"].Value.ToString();
                if (gioiTinh == "Nam")
                {
                    radNam.Checked = true;
                }
                else if (gioiTinh == "Nữ")
                {
                    radNu.Checked = true;
                }

                cmbLop.Text = row.Cells["Lop"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
                txtSoDienThoai.Text = row.Cells["SoDienThoai"].Value.ToString();
            }
        }
    }
}
