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
using DAO;
using System.Security.Cryptography;

namespace GUI
{
    public partial class FRM_taikhoan : Form
    {
        public FRM_taikhoan()
        {
            InitializeComponent();
        }

        private void FRM_taikhoan_Load(object sender, EventArgs e)
        {
            
            HienThiNhanVienLenCombobox();
            HienThiQuyenLenCombobox();
            HienThiDSTaiKhoanLenDataGrid();
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

        private void HienThiNhanVienLenCombobox()
        {
            List<NhanVien_DTO> lstNhanVien = NhanVien_BUS.LayDSNhanVien();
            cboNhanVien.DataSource = lstNhanVien;
            cboNhanVien.DisplayMember = "STenNV";
            cboNhanVien.ValueMember = "SMaNV";
        }
        private void HienThiQuyenLenCombobox()
        {
            cboQuyen.Items.Add("1");
            cboQuyen.Items.Add("0");
        }

        private void HienThiDSTaiKhoanLenDataGrid()
        {
            List<TaiKhoan_DTO> lstTaiKhoan = TaiKhoan_BUS.LayDSTaiKhoan();
            dtgTK.DataSource = lstTaiKhoan;
            dtgTK.Columns[0].HeaderText = "Mã nhân viên";
            dtgTK.Columns[1].HeaderText = "Mật khẩu";
            dtgTK.Columns[2].HeaderText = "Quyền hạn";
            dtgTK.AllowUserToAddRows = false;
            dtgTK.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void dtgTK_Click(object sender, EventArgs e)
        {
           
            cboNhanVien.SelectedValue = dtgTK.CurrentRow.Cells["SMaNV"].Value;
            txt_matkhau.Text = dtgTK.CurrentRow.Cells["SMatKhau"].Value.ToString();
            cboQuyen.SelectedItem = dtgTK.CurrentRow.Cells["SQuyen"].Value.ToString();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {

            if (cboNhanVien.Text == "" || txt_matkhau.Text == "" || cboQuyen.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu");
            }
            TaiKhoan_DTO tk = new TaiKhoan_DTO();
            tk.SMaNV = cboNhanVien.SelectedValue.ToString();
            tk.SMatKhau = DataProvider.MD5(txt_matkhau.Text);
            tk.SQuyen = Convert.ToInt32(cboQuyen.SelectedItem);
            if (TaiKhoan_BUS.ThemTaiKhoan(tk) == false)
            {
                MessageBox.Show("Không thêm được");
                return;
            }
              
            HienThiDSTaiKhoanLenDataGrid();
            MessageBox.Show("Đã thêm tài khoản");
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            TaiKhoan_DTO tk = new TaiKhoan_DTO();
            tk.SMaNV=cboNhanVien.SelectedValue.ToString();
            tk.SMatKhau = DataProvider.MD5(txt_matkhau.Text);
            tk.SQuyen = Convert.ToInt32(cboQuyen.SelectedItem);
            if (TaiKhoan_BUS.SuaTaiKhoan(tk) == false)
            {
                MessageBox.Show("Không sửa được");
                return;
            }
            HienThiDSTaiKhoanLenDataGrid();
            MessageBox.Show("Đã sửa tài khoản");
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            TaiKhoan_DTO tk = new TaiKhoan_DTO();
            tk.SMaNV = cboNhanVien.SelectedValue.ToString();
            if (TaiKhoan_BUS.XoaTaiKhoan(tk) == false)
            {
                MessageBox.Show("Không thể xoá");
                return;
            }
            HienThiDSTaiKhoanLenDataGrid();
            MessageBox.Show("Đã xoá tài khoản");
        }

        private void btn_lammoi_Click(object sender, EventArgs e)
        {

        }

    }
}
