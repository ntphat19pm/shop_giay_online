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
    public partial class Frm_hangsx : Form
    {
        public Frm_hangsx()
        {
            InitializeComponent();
        }

        private void Frm_hangsx_Load(object sender, EventArgs e)
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
            List<hangsx_dto> lsthangsx = hangsx_bus.LayDShangsx();
            dtg_hangsx.DataSource = lsthangsx;
            dtg_hangsx.Columns[0].HeaderText = "Mã hãng";
            dtg_hangsx.Columns[1].HeaderText = "Tên hãng";
            dtg_hangsx.Columns[0].Width = 80;
            dtg_hangsx.Columns[1].Width = 120;
            dtg_hangsx.AllowUserToAddRows = false;
            dtg_hangsx.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void dtg_hangsx_Click(object sender, EventArgs e)
        {
           
            txt_mahang.Text = dtg_hangsx.CurrentRow.Cells["Smahang"].Value.ToString();
            txt_tenhang.Text = dtg_hangsx.CurrentRow.Cells["Stenhang"].Value.ToString();
           
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (txt_mahang.Text == "" || txt_tenhang.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!");
                return;
            }
            // Kiểm tra mã nhân viên có độ dài chuỗi hợp lệ hay không             
            if (txt_mahang.Text.Length > 5)
            {
                MessageBox.Show("Mã hãng tối đa 5 ký tự!");
                return;
            }
            if (hangsx_bus.TimHSXTheoMa(txt_mahang.Text) != null)
            {
                MessageBox.Show("Mã hãng đã tồn tại!");
                return;
            }
            hangsx_dto hsx = new hangsx_dto();
            hsx.Smahang = txt_mahang.Text;
            hsx.Stenhang = txt_tenhang.Text;
            if (hangsx_bus.ThemNhanVien(hsx) == false)
            {
                MessageBox.Show("Không thêm được.");
                return;
            }
            HienThiDSNhanVienLenDatagrid();
            MessageBox.Show("Đã thêm hãng sản xuất.");
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            hangsx_dto hsx = new hangsx_dto();
            hsx.Smahang = txt_mahang.Text;
            if (hangsx_bus.XoaNhanVien(hsx) == false)
            {
                MessageBox.Show("Không xóa được.");
                return;
            }
            HienThiDSNhanVienLenDatagrid();
            MessageBox.Show("Đã xóa hãng sản xuất.");
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            string ten = txt_timkiem.Text;
            List<hangsx_dto> lsthsx = hangsx_bus.TimHSXTheoTen(ten);
            if (lsthsx == null)
            {
                MessageBox.Show("Không tìm thấy!");
                return;
            }
                dtg_hangsx.DataSource = lsthsx;
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            hangsx_dto hsx = new hangsx_dto();
            hsx.Smahang = txt_mahang.Text;
            hsx.Stenhang = txt_tenhang.Text;
            if (hangsx_bus.SuaNhanVien(hsx) == false)
            {
                MessageBox.Show("Không sửa được.");
                return;
            }
            HienThiDSNhanVienLenDatagrid();
            MessageBox.Show("Đã sửa hãng sản xuất.");
        }

        private void btn_lammoi_Click(object sender, EventArgs e)
        {
            txt_mahang.Clear();
            txt_tenhang.Clear();
            txt_timkiem.Clear();
        }
    }
    
}
