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
    public partial class frmGiangVien : Form
    {
        DBConnect dbConnect = new DBConnect();
        public frmGiangVien()
        {
            InitializeComponent();
            LoadGiangVienData();
            LoadTenKhoaData();
        }

        private void LoadGiangVienData()
        {
            string sql = "SELECT * FROM GIANGVIEN";
            DataTable dt = dbConnect.getDatatable(sql);
            dgvGiangVien.DataSource = dt;
        }


        private void LoadTenKhoaData()
        {
            string sql = "SELECT KhoaID, TenKhoa FROM KHOA";
            DataTable dt = dbConnect.getDatatable(sql);
            cmbTenKhoa.DataSource = dt;
            cmbTenKhoa.DisplayMember = "TenKhoa"; // The text to display.
            cmbTenKhoa.ValueMember = "KhoaID"; // The underlying value.
            cmbTenKhoa.SelectedIndex = -1;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtGiangVienID.Text) || string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("ID và Tên không được để trống.");
                return;
            }

            try
            {
                string maGV = txtGiangVienID.Text.Trim();
                string hoTen = txtHoTen.Text.Trim().Replace("'", "''");
                string ngaySinh = dtPickerNgaySinh.Value.ToString("yyyy-MM-dd");
                string gioiTinh = radNam.Checked ? "Nam" : "Nữ";
                string sdt = txtSoDienThoai.Text.Trim().Replace("'", "''");
                string maKhoa = cmbTenKhoa.SelectedValue.ToString().Trim().Replace("'", "''");
                string email = txtEmail.Text.Trim().Replace("'", "''");

                string sql = $"INSERT INTO GIANGVIEN (GiangVienID, HoTen, NgaySinh, GioiTinh, Email, SoDienThoai, KhoaID) VALUES ('{maGV}','{hoTen}','{ngaySinh}', '{gioiTinh}','{email}','{sdt}','{maKhoa}')";
                dbConnect.getNonQuery(sql);
                LoadGiangVienData();

                MessageBox.Show("Thêm giảng viên thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maGV = txtGiangVienID.Text.Trim(); // Cắt khoảng trắng và đảm bảo không có ký tự đặc biệt

            if (string.IsNullOrEmpty(maGV))
            {
                MessageBox.Show("Bạn cần chọn một giảng viên để xóa.");
                return;
            }

            try
            {
                string sql = $"DELETE FROM GIANGVIEN WHERE GiangVienID = '{maGV}'";
                dbConnect.getNonQuery(sql);
                LoadGiangVienData();

                MessageBox.Show("Xóa giảng viên thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maGV = txtGiangVienID.Text.Trim();
            string hoTen = txtHoTen.Text.Trim().Replace("'", "''"); // Thay thế dấu nháy đơn để tránh lỗi SQL
            string ngaySinh = dtPickerNgaySinh.Value.ToString("yyyy-MM-dd");
            string gioiTinh = radNam.Checked ? "Nam" : "Nữ";
            string email = txtEmail.Text.Trim();
            string sdt = txtSoDienThoai.Text.Trim();
            string maKhoa = cmbTenKhoa.SelectedValue.ToString();

            if (string.IsNullOrEmpty(maGV))
            {
                MessageBox.Show("Bạn cần chọn một giảng viên để sửa.");
                return;
            }

            try
            {
                // Chú ý: Không cập nhật GiangVienID vì đó là khóa chính
                string sql = $"UPDATE GIANGVIEN SET HoTen = N'{hoTen}', NgaySinh = '{ngaySinh}', GioiTinh = N'{gioiTinh}', Email = '{email}', SoDienThoai = '{sdt}', KhoaID = '{maKhoa}' WHERE GiangVienID = '{maGV}'";
                dbConnect.getNonQuery(sql);
                LoadGiangVienData();

                MessageBox.Show("Cập nhật thông tin giảng viên thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
        }


        private void btnReset_Click(object sender, EventArgs e)
        {
            txtGiangVienID.Clear();
            txtHoTen.Clear();
            dtPickerNgaySinh.Value = DateTime.Now;
            txtSoDienThoai.Clear();
            cmbTenKhoa.SelectedIndex = -1;
            txtEmail.Clear();

            radNam.Checked = false;
            radNu.Checked = false;
        }

        private void dgvGiangVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvGiangVien.Rows[e.RowIndex];
                txtGiangVienID.Text = row.Cells["GiangVienID"].Value.ToString().Trim();
                txtHoTen.Text = row.Cells["HoTen"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();

                string selectedKhoaID = row.Cells["KhoaID"].Value.ToString();
                cmbTenKhoa.SelectedValue = selectedKhoaID;

                txtSoDienThoai.Text = row.Cells["SoDienThoai"].Value.ToString();

                if (row.Cells["NgaySinh"].Value != DBNull.Value)
                {
                    dtPickerNgaySinh.Value = Convert.ToDateTime(row.Cells["NgaySinh"].Value);
                }
                else
                {
                    dtPickerNgaySinh.Value = dtPickerNgaySinh.MinDate; // Or any default date you prefer
                }

                string gender = row.Cells["GioiTinh"].Value.ToString();
                if (gender == "Nam")
                {
                    radNam.Checked = true;
                }
                else if (gender == "Nữ")
                {
                    radNu.Checked = true;
                }
            }
        }
    }
}
