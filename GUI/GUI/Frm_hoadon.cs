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
using DAO;
using COMExcel = Microsoft.Office.Interop.Excel;

namespace GUI
{
    public partial class Frm_hoadon : Form
    {
        DataTable ChiTietHoaDon;
        public Frm_hoadon()
        {
            InitializeComponent();
        }

        private void dtg_hd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            string sql;
            double sl, SLcon, tong, Tongmoi;
            sql = "SELECT MAHD FROM HOADON WHERE MAHD=N'" + txt_mahd.Text + "'";
            if (!DataProvider.CheckKey(sql))
            {
                if (cboNV.Text.Length == 0 || cboKH.Text.Length == 0)
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!");
                    return;
                }
            }
            HoaDon_DTO hd = new HoaDon_DTO();
            hd.SMaHD = txt_mahd.Text;
            hd.SMaNV = cboNV.SelectedValue.ToString();
            hd.SMaKH = cboKH.SelectedValue.ToString();
            hd.DtNgayBan = DateTime.Parse(dtp_ngayban.Text);
            hd.STongTien = float.Parse(txt_tongtien.Text);
            HoaDon_BUS.ThemHoaDon(hd);

            if (cboSP.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboSP.Focus();
                return;
            }
            if ((txt_soluong.Text.Trim().Length == 0) || (txt_soluong.Text == "0"))
            {
                MessageBox.Show("Bạn phải nhập số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_soluong.Text = "";
                txt_soluong.Focus();
                return;
            }
            if (txt_giamgia.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập giảm giá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_giamgia.Focus();
                return;
            }

            sl = Convert.ToDouble(DataProvider.GetFieldValues("SELECT SOLUONG FROM SANPHAM WHERE MASP = N'" + cboSP.SelectedValue + "'"));
            if (Convert.ToDouble(txt_soluong.Text) > sl)
            {
                MessageBox.Show("Số lượng sản phẩm này chỉ còn " + sl, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_soluong.Text = "";
                txt_soluong.Focus();
                return;
            }
            ChiTietHoaDon_DTO cthd = new ChiTietHoaDon_DTO();
            cthd.SMaHD = txt_mahd.Text;
            cthd.SMaSP = cboSP.SelectedValue.ToString();
            cthd.SMauSac = txt_mau.Text;
            cthd.SKieu = txt_kieu.Text;
            cthd.SSoLuong = Convert.ToInt32(txt_soluong.Text);
            cthd.SDonGia = float.Parse(txt_dongia.Text);
            cthd.SGiamGia = float.Parse(txt_giamgia.Text);
            cthd.SThanhTien = float.Parse(txt_thanhtien.Text);
            cthd.SBaoHanh = txt_baohanh.Text;
            if (ChiTietHoaDon_BUS.ThemCTHoaDon(cthd) == false)
            {
                MessageBox.Show("Không thêm được.");
                return;
            }

            HienThiDSCTHoaDonLenDatagrid();
            MessageBox.Show("Ðã thêm hoá đơn");
            SLcon = sl - Convert.ToDouble(txt_soluong.Text);
            sql = "UPDATE SANPHAM SET SOLUONG =" + SLcon + " WHERE MASP= N'" + cboSP.SelectedValue + "'";
            DataProvider.RunSQL(sql);
            // C?p nh?t l?i t?ng ti?n cho hóa don bán
            tong = Convert.ToDouble(DataProvider.GetFieldValues("SELECT TONGTIEN FROM HOADON WHERE MAHD = N'" + txt_mahd.Text + "'"));
            Tongmoi = tong + Convert.ToDouble(txt_thanhtien.Text);
            sql = "UPDATE HOADON SET TONGTIEN =" + Tongmoi + " WHERE MAHD = N'" + txt_mahd.Text + "'";
            DataProvider.RunSQL(sql);
            txt_tongtien.Text = Tongmoi.ToString();
            ResetValuesHang();

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

        private void Frm_hoadon_Load(object sender, EventArgs e)
        {
            txt_mahd.ReadOnly = true;
            txt_tennv.ReadOnly = false;
            txt_tenkh.ReadOnly = false;
            txt_tensp.ReadOnly = false;
            txt_diachi.ReadOnly = false;
            txt_dt.ReadOnly = false;
            txt_mau.ReadOnly = false;
            txt_kieu.ReadOnly = false;
            txt_thanhtien.ReadOnly = false;
            txt_tongtien.ReadOnly = false;
            txt_dongia.ReadOnly = false;
            txt_giamgia.Text = "0";
            txt_tongtien.Text = "0";
            txt_baohanh.ReadOnly = false;

            if (txt_mahd.Text != "")
            {
                LoadInfoHoaDon();
                btn_xoa.Enabled = true;

            }
            HienThiDSCTHoaDonLenDatagrid();
            HienThiKhachHangLenCombobox();
            HienThiNhanVienLenCombobox();
            HienThiSanPhamLenCombobox();
            LoadTheme();
        }
        private void LoadInfoHoaDon()
        {
            string str;
            str = "SELECT NGAYBAN FROM HOADON WHERE MAHD = N'" + txt_mahd.Text + "'";
            dtp_ngayban.Value = DateTime.Parse(DataProvider.ConvertDateTime(DataProvider.GetFieldValues(str)));
            str = "SELECT MANV FROM HOADON WHERE MAHD = N'" + txt_mahd.Text + "'";
            cboNV.SelectedValue = DataProvider.GetFieldValues(str);
            str = "SELECT MAKH FROM HOADON WHERE MAHD = N'" + txt_mahd.Text + "'";
            cboKH.SelectedValue = DataProvider.GetFieldValues(str);
            str = "SELECT TONGTIEN FROM HOADON WHERE MAHD = N'" + txt_mahd.Text + "'";
            txt_tongtien.Text = DataProvider.GetFieldValues(str);
        }

        private void btn_lammoi_Click(object sender, EventArgs e)
        {
            txt_mahd.Text = "";
            dtp_ngayban.Value = DateTime.Now;
            cboNV.SelectedValue = "";
            cboKH.SelectedValue = "";
            txt_tongtien.Text = "0";
            cboSP.Text = "";
            txt_mahd.Text = DataProvider.CreateKey("HDB");
            HienThiDSCTHoaDonLenDatagrid();
        }
        private void HienThiDSCTHoaDonLenDatagrid()
        {
            string sql;
            sql = "SELECT a.MASP, b.TENSP, a.SOLUONG, b.GiABAN, a.GIAMGIA,a.THANHTIEN,b.MAUSAC,b.KIEU,b.THOIGIANBAOHANH FROM CHITIETHOADON AS a, SANPHAM AS b WHERE a.MAHD = N'" + txt_mahd.Text + "' AND a.MASP=b.MASP";
            ChiTietHoaDon = DataProvider.GetDataToTable(sql);
            dtg_hd.DataSource = ChiTietHoaDon;
            dtg_hd.Columns[0].HeaderText = "Mã sản phẩm";
            dtg_hd.Columns[1].HeaderText = "Tên sản phẩm";
            dtg_hd.Columns[2].HeaderText = "Số lượng";
            dtg_hd.Columns[3].HeaderText = "Đơn giá";
            dtg_hd.Columns[4].HeaderText = "Giảm giá %";
            dtg_hd.Columns[5].HeaderText = "Thành tiền";
            dtg_hd.Columns[6].HeaderText = "Màu sắc";
            dtg_hd.Columns[7].HeaderText = "Kiểu";
            dtg_hd.Columns[8].HeaderText = "Bảo hành";
            dtg_hd.AllowUserToAddRows = false;
            dtg_hd.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void ResetValuesHang()
        {

            txt_soluong.Text = "";
            txt_giamgia.Text = "0";
            txt_thanhtien.Text = "0";
            txt_baohanh.Text = "";
        }
        #region hiển thị thông tin
        private void cboNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str;
            if (cboNV.Text == "")
            {
                txt_tennv.Text = "";
            }
            str = "Select TENNV from NHANVIEN where MANV =N'" + cboNV.SelectedValue + "'";
            txt_tennv.Text = DataProvider.GetFieldValues(str);
        }

        private void cboKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str;
            if (cboKH.Text == "")
            {
                txt_tenkh.Text = "";
                txt_diachi.Text = "";
                txt_dt.Text = "";
            }
            str = "Select TENKH from KHACHHANG where MAKH =N'" + cboKH.SelectedValue + "'";
            txt_tenkh.Text = DataProvider.GetFieldValues(str);
            str = "Select DIACHI from KhachHang where MAKH =N'" + cboKH.SelectedValue + "'";
            txt_diachi.Text = DataProvider.GetFieldValues(str);
            str = "Select DIENTHOAI from KhachHang where MAKH =N'" + cboKH.SelectedValue + "'";
            txt_dt.Text = DataProvider.GetFieldValues(str);
        }

        private void cboSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str;
            if (cboSP.Text == "")
            {
                txt_tensp.Text = "";
                txt_dongia.Text = "";
                txt_mau.Text = "";
                txt_kieu.Text = "";
                txt_baohanh.Text = "";
            }
            str = "Select TENSP from SANPHAM where MASP =N'" + cboSP.SelectedValue + "'";
            txt_tensp.Text = DataProvider.GetFieldValues(str);
            str = "SELECT GIABAN FROM SANPHAM WHERE MASP =N'" + cboSP.SelectedValue + "'";
            txt_dongia.Text = DataProvider.GetFieldValues(str);
            str = "SELECT MAUSAC FROM SANPHAM WHERE MASP =N'" + cboSP.SelectedValue + "'";
            txt_mau.Text = DataProvider.GetFieldValues(str);
            str = "SELECT KIEU FROM SANPHAM WHERE MASP =N'" + cboSP.SelectedValue + "'";
            txt_kieu.Text = DataProvider.GetFieldValues(str);
            str = "SELECT THOIGIANBAOHANH FROM SANPHAM WHERE MASP =N'" + cboSP.SelectedValue + "'";
            txt_baohanh.Text = DataProvider.GetFieldValues(str);
        }
        #endregion

        #region textchanged
        private void txt_soluong_TextChanged(object sender, EventArgs e)
        {
            double tt, sl, dg, gg;
            if (txt_soluong.Text == "")
                sl = 0;
            else
                sl = Convert.ToDouble(txt_soluong.Text);
            if (txt_giamgia.Text == "")
                gg = 0;
            else
                gg = Convert.ToDouble(txt_giamgia.Text);
            if (txt_dongia.Text == "")
                dg = 0;
            else
                dg = Convert.ToDouble(txt_dongia.Text);
            tt = sl * dg - sl * dg * gg / 100;
            txt_thanhtien.Text = tt.ToString();
        }

        private void txt_giamgia_TextChanged(object sender, EventArgs e)
        {
            double tt, sl, dg, gg;
            if (txt_soluong.Text == "")
                sl = 0;
            else
                sl = Convert.ToDouble(txt_soluong.Text);
            if (txt_giamgia.Text == "")
                gg = 0;
            else
                gg = Convert.ToDouble(txt_giamgia.Text);
            if (txt_dongia.Text == "")
                dg = 0;
            else
                dg = Convert.ToDouble(txt_dongia.Text);
            tt = sl * dg - sl * dg * gg / 100;
            txt_thanhtien.Text = tt.ToString();
        }
        #endregion

        #region hiển thị combobox
        private void HienThiNhanVienLenCombobox()
        {
            List<NhanVien_DTO> lstNhanVien = NhanVien_BUS.LayDSNhanVien();
            cboNV.DataSource = lstNhanVien;
            cboNV.DisplayMember = "SMaNV";
            cboNV.ValueMember = "SMaNV";
        }
        private void HienThiKhachHangLenCombobox()
        {
            List<khachhang_dto> lstKhachHang = khachhang_bus.LayDSkh();
            cboKH.DataSource = lstKhachHang;
            cboKH.DisplayMember = "Smakh";
            cboKH.ValueMember = "Smakh";
        }
        private void HienThiSanPhamLenCombobox()
        {
            List<SanPham_DTO> lstSanPham = SanPham_BUS.LayDSSanPham();
            cboSP.DataSource = lstSanPham;
            cboSP.DisplayMember = "SMaSP";
            cboSP.ValueMember = "SMaSP";
        }
        #endregion

        private void cbo_mahd_DropDown(object sender, EventArgs e)
        {
            DataProvider.FillCombo("SELECT MAHD FROM HOADON", cbo_mahd, "MAHD", "MAHD");
            cbo_mahd.SelectedIndex = -1;
        }

        private void btn_tim_Click(object sender, EventArgs e)
        {
            if (cbo_mahd.Text == "")
            {
                MessageBox.Show("Bạn phải chọn một mã hóa đơn để tìm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbo_mahd.Focus();
                return;
            }
            txt_mahd.Text = cbo_mahd.Text;
            LoadInfoHoaDon();
            HienThiDSCTHoaDonLenDatagrid();

            cbo_mahd.SelectedIndex = -1;
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
                double sl, slcon, slxoa;
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sql = "SELECT MASP,SOLUONG FROM CHITIETHOADON WHERE MAHD = N'" + txt_mahd.Text + "'";
                DataTable SanPham = DataProvider.GetDataToTable(sql);
                for (int dt = 0; dt <= SanPham.Rows.Count - 1; dt++)
                {
                    // Cập nhật lại số lượng giày
                    sl = Convert.ToDouble(DataProvider.GetFieldValues("SELECT SOLUONG FROM SANPHAM WHERE MASP = N'" + SanPham.Rows[dt][0].ToString() + "'"));
                    slxoa = Convert.ToDouble(SanPham.Rows[dt][1].ToString());
                    slcon = sl + slxoa;
                    sql = "UPDATE SANPHAM SET SOLUONG =" + slcon + " WHERE MASP= N'" + SanPham.Rows[dt][0].ToString() + "'";
                    DataProvider.RunSQL(sql);
                }

                HoaDon_DTO hd = new HoaDon_DTO();
                hd.SMaHD = txt_mahd.Text;
                HoaDon_BUS.XoaHoaDon(hd);
                DataProvider.RunSQL(sql);

                ChiTietHoaDon_DTO cthd = new ChiTietHoaDon_DTO();
                cthd.SMaHD = txt_mahd.Text;
                if (ChiTietHoaDon_BUS.XoaCTHoaDon(cthd) == false)
                {
                    MessageBox.Show("Không xóa được.");
                    return;
                }
                DataProvider.RunSQL(sql);
                btn_lammoi_Click(sender, e);
                HienThiDSCTHoaDonLenDatagrid();
                MessageBox.Show("Ðã xóa hoá đơn.");
            }
        }

        private void txt_soluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8))
                e.Handled = false;
            else e.Handled = true;
        }

        private void txt_giamgia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8))
                e.Handled = false;
            else e.Handled = true;
        }

        private void btn_in_Click(object sender, EventArgs e)
        {
            COMExcel.Application exApp = new COMExcel.Application();
            COMExcel.Workbook exBook; //Trong 1 chương trình Excel có nhiều Workbook
            COMExcel.Worksheet exSheet; //Trong 1 Workbook có nhiều Worksheet
            COMExcel.Range exRange;
            string sql;
            int hang = 0, cot = 0;
            DataTable tblThongtinHD, tblThongtinHang;
            exBook = exApp.Workbooks.Add(COMExcel.XlWBATemplate.xlWBATWorksheet);
            exSheet = exBook.Worksheets[1];
            // Định dạng chung
            exRange = exSheet.Cells[1, 1];
            exRange.Range["A1:Z300"].Font.Name = "Times new roman"; //Font chữ
            exRange.Range["A1:B3"].Font.Size = 10;
            exRange.Range["A1:B3"].Font.Bold = true;
            exRange.Range["A1:B3"].Font.ColorIndex = 5; //Màu xanh da trời
            exRange.Range["A1:A1"].ColumnWidth = 7;
            exRange.Range["B1:B1"].ColumnWidth = 15;
            exRange.Range["A1:B1"].MergeCells = true;
            exRange.Range["A1:B1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A1:B1"].Value = "Shop Máy Tính Q.M";
            exRange.Range["A2:B2"].MergeCells = true;
            exRange.Range["A2:B2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A2:B2"].Value = "Long Xuyên - An Giang";
            exRange.Range["A3:B3"].MergeCells = true;
            exRange.Range["A3:B3"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A3:B3"].Value = "Điện thoại: (84)961825152";
            exRange.Range["C2:E2"].Font.Size = 16;
            exRange.Range["C2:E2"].Font.Bold = true;
            exRange.Range["C2:E2"].Font.ColorIndex = 3; //Màu đỏ
            exRange.Range["C2:E2"].MergeCells = true;
            exRange.Range["C2:E2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C2:E2"].Value = "HÓA ĐƠN BÁN";
            // Biểu diễn thông tin chung của hóa đơn bán
            sql = "SELECT a.MAHD, a.NGAYBAN, a.TONGTIEN, b.TENKH, b.DIACHI, b.DIENTHOAI, c.TENNV FROM HOADON AS a, KHACHHANG AS b, NHANVIEN AS c WHERE a.MaHD = N'" + txt_mahd.Text + "' AND a.MAKH = b.MAKH AND a.MANV = c.MANV";
            tblThongtinHD = DataProvider.GetDataToTable(sql);
            exRange.Range["B6:C9"].Font.Size = 12;
            exRange.Range["B6:B6"].Value = "Mã hóa đơn:";
            exRange.Range["C6:E6"].MergeCells = true;
            exRange.Range["C6:E6"].Value = tblThongtinHD.Rows[0][0].ToString();
            exRange.Range["B7:B7"].Value = "Khách hàng:";
            exRange.Range["C7:E7"].MergeCells = true;
            exRange.Range["C7:E7"].Value = tblThongtinHD.Rows[0][3].ToString();
            exRange.Range["B8:B8"].Value = "Địa chỉ:";
            exRange.Range["C8:D8"].MergeCells = true;
            exRange.Range["C8:D8"].Value = tblThongtinHD.Rows[0][4].ToString();
            exRange.Range["B9:B9"].Value = "Điện thoại:";
            exRange.Range["C9:C9"].MergeCells = true;
            exRange.Range["C9:C9"].Value = tblThongtinHD.Rows[0][5].ToString();
            //Lấy thông tin các mặt hàng
            sql = "SELECT b.TENSP, a.SOLUONG,a.MAUSAC,a.KIEU, b.GIABAN, a.GIAMGIA, a.THANHTIEN,a.THOIGIANBAOHANH " +
                  "FROM CHITIETHOADON AS a , SANPHAM AS b WHERE a.MAHD = N'" +
                  txt_mahd.Text + "' AND a.MASP = b.MASP";
            tblThongtinHang = DataProvider.GetDataToTable(sql);
            //Tạo dòng tiêu đề bảng
            exRange.Range["A11:I11"].Font.Bold = true;
            exRange.Range["A11:I11"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C11:F11"].ColumnWidth = 12;
            exRange.Range["A11:A11"].Value = "STT";
            exRange.Range["B11:C11"].Value = "Tên sản phẩm";
            exRange.Range["C11:C11"].Value = "Số lượng";
            exRange.Range["D11:D11"].Value = "Màu";
            exRange.Range["E11:E11"].Value = "Kiểu";
            exRange.Range["F11:F11"].Value = "Đơn giá";
            exRange.Range["G11:G11"].Value = "Giảm giá";
            exRange.Range["H11:H11"].Value = "Thành tiền";
            exRange.Range["I11:I11"].Value = "Bảo hành";
            for (hang = 0; hang < tblThongtinHang.Rows.Count; hang++)
            {
                //Điền số thứ tự vào cột 1 từ dòng 12
                exSheet.Cells[1][hang + 12] = hang + 1;
                for (cot = 0; cot < tblThongtinHang.Columns.Count; cot++)
                //Điền thông tin hàng từ cột thứ 2, dòng 12
                {
                    exSheet.Cells[cot + 2][hang + 12] = tblThongtinHang.Rows[hang][cot].ToString();
                    if (cot == 5) exSheet.Cells[cot + 2][hang + 12] = tblThongtinHang.Rows[hang][cot].ToString() + "%";
                }
            }
            exRange = exSheet.Cells[cot][hang + 14];
            exRange.Font.Bold = true;
            exRange.Value2 = "Tổng tiền:";
            exRange = exSheet.Cells[cot + 1][hang + 14];
            exRange.Font.Bold = true;
            exRange.Value2 = tblThongtinHD.Rows[0][2].ToString();
            exRange = exSheet.Cells[1][hang + 15]; //Ô A1 
            exRange.Range["A1:F1"].MergeCells = true;
            exRange.Range["A1:F1"].Font.Bold = true;
            exRange.Range["A1:F1"].Font.Italic = true;
            exRange.Range["A1:F1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignRight;
            // exRange.Range["A1:F1"].Value = "Bằng chữ: " + Functions.ChuyenSoSangChu(tblThongtinHD.Rows[0][2].ToString());
            exRange = exSheet.Cells[4][hang + 17]; //Ô A1 
            exRange.Range["A1:C1"].MergeCells = true;
            exRange.Range["A1:C1"].Font.Italic = true;
            exRange.Range["A1:C1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            DateTime d = Convert.ToDateTime(tblThongtinHD.Rows[0][1]);
            exRange.Range["A1:C1"].Value = "Long Xuyên, ngày " + d.Day + " tháng " + d.Month + " năm " + d.Year;
            exRange.Range["A2:C2"].MergeCells = true;
            exRange.Range["A2:C2"].Font.Italic = true;
            exRange.Range["A2:C2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A2:C2"].Value = "Nhân viên bán hàng";
            exRange.Range["A6:C6"].MergeCells = true;
            exRange.Range["A6:C6"].Font.Italic = true;
            exRange.Range["A6:C6"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A6:C6"].Value = tblThongtinHD.Rows[0][6];
            exSheet.Name = "Hóa đơn nhập";
            exApp.Visible = true;
        }
    }
}
