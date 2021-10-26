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
    public partial class Frm_chucvu : Form
    {
        public Frm_chucvu()
        {
            InitializeComponent();
        }

        private void Frm_chucvu_Load(object sender, EventArgs e)
        {
            HienThiChucVuLenDataGrid();
            
        }
        private void HienThiChucVuLenDataGrid()
        {
            List<ChucVu_DTO> lstChucVu = ChucVu_BUS.LayChucVu();
            dgDSChucVu.DataSource = lstChucVu;
            dgDSChucVu.Columns["SMaCV"].HeaderText = "Mã chức vụ";
            dgDSChucVu.Columns["STenCV"].HeaderText = "Tên chức vụ";
            dgDSChucVu.AllowUserToAddRows = false;
            dgDSChucVu.EditMode = DataGridViewEditMode.EditProgrammatically;

        }

        private void dgDSChucVu_Click(object sender, EventArgs e)
        {
           
            textBox1.Text = dgDSChucVu.CurrentRow.Cells["SMaCV"].Value.ToString();
            textBox2.Text = dgDSChucVu.CurrentRow.Cells["STenCV"].Value.ToString();
        }
    }
}
