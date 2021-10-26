using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;

namespace GUI
{
    public partial class Frm_khachhang : Form
    {
        public Frm_khachhang()
        {
            InitializeComponent();
        }

        private void Frm_khachhang_Load(object sender, EventArgs e)
        {
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
        private void HienThiDSNhanVienLenDatagrid()
        {
            List<khachhang_dto> lstkh = khachhang_bus.LayDSkh();
            dtg_khachhang.DataSource = lstkh;
            dtg_khachhang.Columns[0].HeaderText = "Mã khách hàng";
            dtg_khachhang.Columns[1].HeaderText = "Tên khách hàng";
            dtg_khachhang.Columns[2].HeaderText = "Địa chỉ";
            dtg_khachhang.Columns[3].HeaderText = "Số điện thoại";
            dtg_khachhang.Columns[0].Width = 120;
            dtg_khachhang.Columns[1].Width = 120;
            dtg_khachhang.Columns[2].Width = 120;
            dtg_khachhang.Columns[3].Width = 100;
            dtg_khachhang.AllowUserToAddRows = false;
            dtg_khachhang.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (txt_makh.Text == "" || txt_tenkh.Text == "" || txt_diachi.Text == ""||txt_sdt.Text=="" )
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!");
                return;
            }
            // Kiểm tra mã nhân viên có độ dài chuỗi hợp lệ hay không             
            if (txt_makh.Text.Length > 5)
            {
                MessageBox.Show("Mã khách hàng tối đa 5 ký tự!");
                return;
            }
            if (txt_sdt.Text.Length > 11)
            {
                MessageBox.Show("Số điện thoại tối đa 11 số");
                return;
            }
            if (khachhang_bus.TimKHTheoMa(txt_makh.Text) != null)
            {
                MessageBox.Show("Mã khách hàng đã tồn tại!");
                return;
            }
            khachhang_dto kh = new khachhang_dto();
            kh.Smakh = txt_makh.Text;
            kh.Stenkh = txt_tenkh.Text;
            kh.Sdiachi = txt_diachi.Text;
            kh.Sdienthoai = txt_sdt.Text;
            if (khachhang_bus.ThemKhachHang(kh) == false)
            {
                MessageBox.Show("Không thêm được.");
                return;
            }
            HienThiDSNhanVienLenDatagrid();
            MessageBox.Show("Đã thêm khách hàng.");
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            khachhang_dto kh = new khachhang_dto();
            kh.Smakh = txt_makh.Text;
            if (khachhang_bus.XoaKhachHang(kh) == false)
            {
                MessageBox.Show("Không xóa được.");
                return;
            }
            HienThiDSNhanVienLenDatagrid();
            MessageBox.Show("Đã xóa khách hàng.");
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            khachhang_dto kh = new khachhang_dto();
            kh.Smakh = txt_makh.Text;
            kh.Stenkh = txt_tenkh.Text;
            kh.Sdiachi = txt_sdt.Text;
            kh.Sdienthoai = txt_sdt.Text;
            if (khachhang_bus.SuaKhachHang(kh) == false)
            {
                MessageBox.Show("Không sửa được.");
                return;
            }
            HienThiDSNhanVienLenDatagrid();
            MessageBox.Show("Đã sửa khách hàng.");
        }

        private void btn_lammoi_Click(object sender, EventArgs e)
        {
            txt_makh.Clear();
            txt_tenkh.Clear();
            txt_diachi.Clear();
            txt_sdt.Clear();
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            string ten = txt_timkiem.Text;
            List<khachhang_dto> lstkh = khachhang_bus.TimKHTheoTen(ten);
            if (lstkh == null)
            {
                MessageBox.Show("Không tìm thấy!");
                return;
            }
            dtg_khachhang.DataSource = lstkh;
        }

        private void dtg_khachhang_Click(object sender, EventArgs e)
        {
            
            txt_makh.Text = dtg_khachhang.CurrentRow.Cells["Smakh"].Value.ToString();
            txt_tenkh.Text = dtg_khachhang.CurrentRow.Cells["Stenkh"].Value.ToString();
            txt_diachi.Text = dtg_khachhang.CurrentRow.Cells["Sdiachi"].Value.ToString();
            txt_sdt.Text = dtg_khachhang.CurrentRow.Cells["Sdienthoai"].Value.ToString();
        }

        private void txt_sdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8))
                e.Handled = false;
            else e.Handled = true;
        }
    }
}
