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
using DTO;
using BUS;

namespace GUI
{
    public partial class Frm_nhanvien : Form
    {
        public Frm_nhanvien()
        {
            InitializeComponent();
        }

        private void Frm_nhanvien_Load(object sender, EventArgs e)
        {
            // Combobox chức vụ
            HienThiChucVuLenCombobox();

            // Datagrid nhân viên
            HienThiDSNhanVienLenDatagrid();
            LoadTheme();
        }
        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }

        }
        private void HienThiChucVuLenCombobox()
        {
            List<ChucVu_DTO> lstChucVu = ChucVu_BUS.LayChucVu();
            cboChucVu.DataSource = lstChucVu;
            cboChucVu.DisplayMember = "STenCV";
            cboChucVu.ValueMember = "SMaCV";
        }

        private void HienThiDSNhanVienLenDatagrid()
        {
            List<NhanVien_DTO> lstNhanVien = NhanVien_BUS.LayDSNhanVien();
            dgDSNhanVien.DataSource = lstNhanVien;
            dgDSNhanVien.Columns[0].HeaderText = "Mã số";
            dgDSNhanVien.Columns[1].HeaderText = "Tên nhân viên";
            dgDSNhanVien.Columns[2].HeaderText = "Địa chỉ";
            dgDSNhanVien.Columns[3].HeaderText = "Điện thoại";
            dgDSNhanVien.Columns[4].HeaderText = "Phái";
            dgDSNhanVien.Columns[5].HeaderText = "Ngày sinh";
            dgDSNhanVien.Columns[6].HeaderText = "Chức vụ";
            dgDSNhanVien.Columns[0].Width = 60;
            dgDSNhanVien.Columns[1].Width = 120;
            dgDSNhanVien.Columns[2].Width = 115;
            dgDSNhanVien.Columns[3].Width = 100;
            dgDSNhanVien.Columns[4].Width = 50;
            dgDSNhanVien.Columns[5].Width = 80;
            dgDSNhanVien.AllowUserToAddRows = false;
            dgDSNhanVien.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void dgDSNhanVien_Click(object sender, EventArgs e)
        {
           
            txtMaNV.Text = dgDSNhanVien.CurrentRow.Cells["SMaNV"].Value.ToString();
            txt_tennv.Text = dgDSNhanVien.CurrentRow.Cells["STenNV"].Value.ToString();
            txt_diachi.Text = dgDSNhanVien.CurrentRow.Cells["SDiaChi"].Value.ToString();
            txt_dt.Text = dgDSNhanVien.CurrentRow.Cells["SDienThoai"].Value.ToString();
            if (dgDSNhanVien.CurrentRow.Cells["SPhai"].Value.ToString() == "Nam")
            {
                radNam.Checked = true;
            }
            else
            {
                radNu.Checked = true;
            }
            dtpNgaySinh.Text = dgDSNhanVien.CurrentRow.Cells["DtNgaySinh"].Value.ToString();
            cboChucVu.SelectedValue = dgDSNhanVien.CurrentRow.Cells["SMaCV"].Value;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu có bị bỏ trống              
            if (txtMaNV.Text == "" || txt_tennv.Text == "" || txt_diachi.Text == "" || txt_dt.Text == ""||cboChucVu.Text==""||dtpNgaySinh.Text=="")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!");
                return;
            }
            string sdtnv = txt_dt.Text;
            string chuoi = "84";
            if (sdtnv.Length != 11 || !sdtnv.StartsWith(chuoi))
            {
                MessageBox.Show("SĐT phải bắt đầu 84 và không dài quá 11 số");
                txt_dt.Focus();
                return;
            }
            // Kiểm tra mã nhân viên có độ dài chuỗi hợp lệ hay không             
            if (txtMaNV.Text.Length > 5)
            {
                MessageBox.Show("Mã nhân viên tối đa 5 ký tự!");
                return;
            }             // Kiểm tra mã nhân viên có bị trùng không             
            if (NhanVien_BUS.TimNhanVienTheoMa(txtMaNV.Text) != null)
            {
                MessageBox.Show("Mã nhân viên đã tồn tại!");
                return;
            }

            NhanVien_DTO nv = new NhanVien_DTO();
            nv.SMaNV = txtMaNV.Text;
            nv.STenNV = txt_tennv.Text;
            nv.SDiaChi = txt_diachi.Text;
            nv.SDienThoai = txt_dt.Text;

            if (radNam.Checked == true)
            {
                nv.SPhai = "Nam";
            }
            else
            {
                nv.SPhai = "Nữ";

            }
            nv.DtNgaySinh = DateTime.Parse(dtpNgaySinh.Text);
            nv.SMaCV = cboChucVu.SelectedValue.ToString();

            if (NhanVien_BUS.ThemNhanVien(nv) == false)
            {
                MessageBox.Show("Không thêm được.");
                return;
            }
            HienThiDSNhanVienLenDatagrid();
            MessageBox.Show("Đã thêm nhân viên.");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            NhanVien_DTO nv = new NhanVien_DTO();
            nv.SMaNV = txtMaNV.Text;
            nv.STenNV = txt_tennv.Text;
            nv.SDiaChi = txt_diachi.Text;
            nv.SDienThoai = txt_dt.Text;

            if (radNam.Checked == true)
            {
                nv.SPhai = "Nam";
            }
            else
            {
                nv.SPhai = "Nữ";

            }
            nv.DtNgaySinh = DateTime.Parse(dtpNgaySinh.Text);
            nv.SMaCV = cboChucVu.SelectedValue.ToString();

            if (NhanVien_BUS.SuaNhanVien(nv) == false)
            {
                MessageBox.Show("Không sửa được.");
                return;
            }
            HienThiDSNhanVienLenDatagrid();
            MessageBox.Show("Đã sửa nhân viên.");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            NhanVien_DTO nv = new NhanVien_DTO();
            nv.SMaNV = txtMaNV.Text;
            if (NhanVien_BUS.XoaNhanVien(nv) == false)
            {
                MessageBox.Show("Không Xóa được.");
                return;
            }
            HienThiDSNhanVienLenDatagrid();
            MessageBox.Show("Đã Xóa nhân viên.");
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string ten = txtTimTen.Text;
            List<NhanVien_DTO> lstnv = NhanVien_BUS.TimNhanVienTheoTen(ten);
            if (lstnv == null)
            {
                MessageBox.Show("Không tìm thấy!");
                return;
            }
            dgDSNhanVien.DataSource = lstnv;
        }

        private void btn_lammoi_Click(object sender, EventArgs e)
        {
            txtMaNV.Clear();
            txt_tennv.Clear();
            txt_diachi.Clear();
            txt_dt.Clear();
            txtMaNV.Focus();
        }

        private void txt_dt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8))
                e.Handled = false;
            else e.Handled = true;
        }
    }
}
