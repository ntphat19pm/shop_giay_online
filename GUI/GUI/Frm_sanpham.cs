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
using GUI.DTO;
using GUI.BUS;
using DTO;
using BUS;
using System.IO;
using DAO;

namespace GUI
{
    public partial class Frm_sanpham : Form
    {
        public Frm_sanpham()
        {
            InitializeComponent();
        }
        public class FileNotFoundException : System.IO.IOException { }

        private void btn_mo_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpen = new OpenFileDialog();
            dlgOpen.Filter = "Bitmap(*.bmp)|*.bmp|JPEG(*.jpg)|*.jpg|GIF(*.gif)|*.gif|All files(*.*)|*.*";
            dlgOpen.FilterIndex = 2;
            dlgOpen.Title = "Chọn ảnh minh hoạ cho sản phẩm";
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                pic_anh.Image = Image.FromFile(dlgOpen.FileName);
                txt_anh.Text = dlgOpen.FileName;
            }

        }
        #region combobox
        private void HienThiHangLenCombobox()
        {
            List<hangsx_dto> lstHangsx = hangsx_bus.LayDShangsx();
            cbo_mahang.DataSource = lstHangsx;
            cbo_mahang.DisplayMember = "Stenhang";
            cbo_mahang.ValueMember = "Smahang";
        }
        private void HienThiMauSacLenCombobox()
        {
            cbo_mau.Items.Add("Trắng");
            cbo_mau.Items.Add("Đen");
            cbo_mau.Items.Add("Đỏ");
            cbo_mau.Items.Add("Vàng");
            cbo_mau.Items.Add("Xanh");
            cbo_mau.Items.Add("Tím");
        }
        private void HienThiKieuLenCombobox()
        {
            cbo_kieu.Items.Add("32GB");
            cbo_kieu.Items.Add("64GB");
            cbo_kieu.Items.Add("128GB");
            cbo_kieu.Items.Add("256GB");
        }
        private void HienThiTGBHLenCombobox()
        {
            cbo_baohanh.Items.Add("6 Tháng");
            cbo_baohanh.Items.Add("1 Năm");
        }
        #endregion

        private void Frm_sanpham_Load(object sender, EventArgs e)
        {
            HienThiMauSacLenCombobox();
            HienThiKieuLenCombobox();
            HienThiHangLenCombobox();
            HienThiTGBHLenCombobox();
            HienThiDSSanPhamLenDatagrid();
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
        private void HienThiDSSanPhamLenDatagrid()
        {
            List<SanPham_DTO> lstSanPham = SanPham_BUS.LayDSSanPham();
            dtgSP.DataSource = lstSanPham;
            dtgSP.Columns[0].HeaderText = "Mã sản phẩm";
            dtgSP.Columns[1].HeaderText = "Tên sản phẩm";
            dtgSP.Columns[2].HeaderText = "Mã hãng";
            dtgSP.Columns[3].HeaderText = "Màu";
            dtgSP.Columns[4].HeaderText = "Kiểu";
            dtgSP.Columns[5].HeaderText = "Giá nhập";
            dtgSP.Columns[6].HeaderText = "Giá bán";
            dtgSP.Columns[7].HeaderText = "Số lượng";
            dtgSP.Columns[8].HeaderText = "Ngày nhập";
            dtgSP.Columns[9].HeaderText = "Thời gian bảo hành";
            dtgSP.Columns[10].HeaderText = "Ảnh";
            dtgSP.AllowUserToAddRows = false;
            dtgSP.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void dtgSP_Click(object sender, EventArgs e)
        {
            
                string sql;
                
                
                txt_masp.Text = dtgSP.CurrentRow.Cells["SMaSP"].Value.ToString();
                txt_tensp.Text = dtgSP.CurrentRow.Cells["STenSP"].Value.ToString();
                cbo_mahang.SelectedValue = dtgSP.CurrentRow.Cells["SMaHang"].Value;
                cbo_mau.SelectedItem = dtgSP.CurrentRow.Cells["SMauSac"].Value.ToString();
                cbo_kieu.SelectedItem = dtgSP.CurrentRow.Cells["SKieu"].Value.ToString();
                txt_gianhap.Text = dtgSP.CurrentRow.Cells["SGiaNhap"].Value.ToString();
                txt_giaban.Text = dtgSP.CurrentRow.Cells["SGiaBan"].Value.ToString();
                txt_soluong.Text = dtgSP.CurrentRow.Cells["SSoLuong"].Value.ToString();
                dtp_ngaynhap.Text = dtgSP.CurrentRow.Cells["DtNgayNhap"].Value.ToString();
                cbo_baohanh.SelectedItem = dtgSP.CurrentRow.Cells["SThoiGianBaoHanh"].Value.ToString();
                txt_anh.Text = dtgSP.CurrentRow.Cells["SAnh"].Value.ToString();
                sql = "SELECT ANH FROM SANPHAM WHERE MASP=N'" + txt_masp.Text + "'";
                txt_anh.Text = DataProvider.GetFieldValues(sql);
                pic_anh.Image = Image.FromFile(txt_anh.Text);
           

        }

        private void btn_them_Click(object sender, EventArgs e)

        {
            string sql;
            if (txt_masp.Text == "" || txt_tensp.Text == "" || txt_soluong.Text == "" || txt_anh.Text == ""||cbo_mahang.Text==""||cbo_baohanh.Text==""||cbo_kieu.Text==""||cbo_mau.Text==""|| txt_giaban.Text == ""|| txt_gianhap.Text == ""|| txt_soluong.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!");
                return;
            }
            // Kiểm tra mã nhân viên có độ dài chuỗi hợp lệ hay không             
            if (txt_masp.Text.Length > 5)
            {
                MessageBox.Show("Mã sản phẩm tối đa 5 ký tự!");
                return;
            }             // Kiểm tra mã nhân viên có bị trùng không             
            if (SanPham_BUS.TimSanPhamTheoMa(txt_masp.Text) != null)
            {
                MessageBox.Show("Mã sản phẩm đã tồn tại!");
                return;
            }
            

            SanPham_DTO sp  = new SanPham_DTO();
            sp.SMaSP =txt_masp.Text;
            sp.STenSP = txt_tensp.Text;
            sp.SMaHang = cbo_mahang.SelectedValue.ToString();
            sp.SMauSac = cbo_mau.SelectedItem.ToString();
            sp.SKieu = cbo_kieu.SelectedItem.ToString();
            sp.SGiaNhap = (float)Double.Parse(txt_gianhap.Text);
            sp.SGiaBan = (float)Double.Parse(txt_giaban.Text);
            sql = DataProvider.GetFieldValues("select GIABAN FROM SANPHAM WHERE MASP=N'" + txt_masp.Text + "'");
            if (float.Parse(txt_gianhap.Text) > float.Parse(txt_giaban.Text))
            {
                MessageBox.Show("Giá bán không được nhỏ hơn giá nhập");
                return;
            }
            sp.SSoLuong = Convert.ToInt32(txt_soluong.Text);
            sp.DtNgayNhap = DateTime.Parse(dtp_ngaynhap.Text);
            sp.SThoiGianBaoHanh = cbo_baohanh.SelectedItem.ToString();
            sp.SAnh = txt_anh.Text;

            if (SanPham_BUS.ThemSanPham(sp) == false)
            {
                MessageBox.Show("Không thêm được.");
                return;
            }
            HienThiDSSanPhamLenDatagrid();
            MessageBox.Show("Đã thêm sản phẩm.");
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            SanPham_DTO sp = new SanPham_DTO();
            sp.SMaSP = txt_masp.Text;
            if (SanPham_BUS.XoaSanPham(sp) == false)
            {
                MessageBox.Show("Không xóa được.");
                return;
            }
            HienThiDSSanPhamLenDatagrid();
            MessageBox.Show("Đã xóa sản phẩm.");
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            string sql;
            SanPham_DTO sp = new SanPham_DTO();
            sp.SMaSP = txt_masp.Text;
            sp.STenSP = txt_tensp.Text;
            sp.SMaHang = cbo_mahang.SelectedValue.ToString();
            sp.SMauSac = cbo_mau.SelectedItem.ToString();
            sp.SKieu = cbo_kieu.SelectedItem.ToString();
            sp.SGiaNhap = (float)Double.Parse(txt_gianhap.Text);
            sp.SGiaBan = (float)Double.Parse(txt_giaban.Text);
            sql = DataProvider.GetFieldValues("select GIABAN FROM SANPHAM WHERE MASP=N'" + txt_masp.Text + "'");
            if (float.Parse(txt_gianhap.Text) > float.Parse(txt_giaban.Text))
            {
                MessageBox.Show("Giá bán không được nhỏ hơn giá nhập");
                return;
            }
            sp.SSoLuong = Convert.ToInt32(txt_soluong.Text);
            sp.DtNgayNhap = DateTime.Parse(dtp_ngaynhap.Text);
            sp.SThoiGianBaoHanh = cbo_baohanh.SelectedItem.ToString();
            sp.SAnh = txt_anh.Text;
             pic_anh.Image= Image.FromFile(txt_anh.Text);

            if (SanPham_BUS.SuaSanPham(sp) == false)
            {
                MessageBox.Show("Không sửa được.");
                return;
            }
            HienThiDSSanPhamLenDatagrid();
            MessageBox.Show("Đã sửa sản phẩm.");
        }

        private void btn_lammoi_Click(object sender, EventArgs e)
        {
            txt_masp.Clear();
            txt_tensp.Clear();
            txt_giaban.Clear();
            txt_gianhap.Clear();
            txt_soluong.Clear();
            txt_anh.Clear();
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            string ten = txttimsp.Text;
            List<SanPham_DTO> lstsp = SanPham_BUS.TimSanPhamTheoTen(ten);
            if (lstsp == null)
            {
                MessageBox.Show("Không tìm thấy!");
                return;
            }
            dtgSP.DataSource = lstsp;
        }

        private void txt_soluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8))
                e.Handled = false;
            else e.Handled = true;
        }

        private void txt_gianhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8))
                e.Handled = false;
            else e.Handled = true;
        }

        private void txt_giaban_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8))
                e.Handled = false;
            else e.Handled = true;
        }
    }
}
