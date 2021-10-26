using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Frm_baocao : Form
    {
        public Frm_baocao()
        {
            InitializeComponent();
        }

        private void Frm_baocao_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'SPDataSet1.SANPHAM' table. You can move, or remove it, as needed.
            this.SANPHAMTableAdapter.Fill(this.SPDataSet1.SANPHAM);
            // TODO: This line of code loads data into the 'QLMTDataSet.CHITIETHOADON' table. You can move, or remove it, as needed.
            this.CHITIETHOADONTableAdapter.Fill(this.QLMTDataSet.CHITIETHOADON);
            // TODO: This line of code loads data into the 'QLMTDataSet.HOADON' table. You can move, or remove it, as needed.
            this.HOADONTableAdapter.Fill(this.QLMTDataSet.HOADON);
            // TODO: This line of code loads data into the 'SPDataSet.SANPHAM' table. You can move, or remove it, as needed.
            //this.SANPHAMTableAdapter.Fill(this.SPDataSet.SANPHAM);


            //his.SANPHAMTableAdapter.Fill(this.DataSet1.SANPHAM);
            // TODO: This line of code loads data into the 'QLĐTDataSet.SANPHAM' table. You can move, or remove it, as needed.


            this.rp_sp.RefreshReport();
            this.report_hd.RefreshReport();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            //this.CHITIETHOADONTableAdapter.Fill(this.HoaDonDataSet1.CHITIETHOADON, textBox1.Text);
            //this.HOADONTableAdapter.Fill(this.HoaDonDataSet1.HOADON, textBox1.Text);
            this.report_hd.RefreshReport();


        }

        private void SANPHAMBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
