using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLcuahangbanmaytinh
{
    public partial class frmdangnhap : Form
    {
        public frmdangnhap()
        {
            InitializeComponent();
        }
        frmMenu fm;

        private void btndangnhap_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            SqlConnection cn = new SqlConnection(@"Data Source=ADMINISTRATOR\SQLEXPRESS;Initial Catalog=QLCuaHangMayTinh;Integrated Security=True");
            SqlDataAdapter da = new SqlDataAdapter("select * from NhanVien where MaNV='" + txt_MaNV.Text + "' and MatKhau ='" + txtmatkhau.Text + "'", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Đăng nhập thành công");
                this.Hide();
                fm = new frmMenu();
                fm.Show();

            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại");
            }

        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có chắc muốn thoát không?", "Trả lời",
           MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
                Application.Exit();
        }
    }
}
   