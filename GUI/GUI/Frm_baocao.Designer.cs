
namespace GUI
{
    partial class Frm_baocao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.HOADONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.QLMTDataSet = new GUI.QLMTDataSet();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.rp_sp = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.report_hd = new Microsoft.Reporting.WinForms.ReportViewer();
            this.HOADONTableAdapter = new GUI.QLMTDataSetTableAdapters.HOADONTableAdapter();
            this.CHITIETHOADONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CHITIETHOADONTableAdapter = new GUI.QLMTDataSetTableAdapters.CHITIETHOADONTableAdapter();
            this.SPDataSet1 = new GUI.SPDataSet1();
            this.SANPHAMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SANPHAMTableAdapter = new GUI.SPDataSet1TableAdapters.SANPHAMTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.HOADONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLMTDataSet)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CHITIETHOADONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SPDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SANPHAMBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // HOADONBindingSource
            // 
            this.HOADONBindingSource.DataMember = "HOADON";
            this.HOADONBindingSource.DataSource = this.QLMTDataSet;
            // 
            // QLMTDataSet
            // 
            this.QLMTDataSet.DataSetName = "QLMTDataSet";
            this.QLMTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(963, 448);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.rp_sp);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(955, 422);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Báo cáo sản phẩm";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // rp_sp
            // 
            this.rp_sp.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetSP";
            reportDataSource1.Value = this.SANPHAMBindingSource;
            this.rp_sp.LocalReport.DataSources.Add(reportDataSource1);
            this.rp_sp.LocalReport.ReportEmbeddedResource = "GUI.ReportSP.rdlc";
            this.rp_sp.Location = new System.Drawing.Point(3, 3);
            this.rp_sp.Name = "rp_sp";
            this.rp_sp.ServerReport.BearerToken = null;
            this.rp_sp.Size = new System.Drawing.Size(949, 416);
            this.rp_sp.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.report_hd);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(955, 422);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Báo cáo hoá đơn";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // report_hd
            // 
            this.report_hd.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.HOADONBindingSource;
            reportDataSource3.Name = "DataSet2";
            reportDataSource3.Value = this.CHITIETHOADONBindingSource;
            this.report_hd.LocalReport.DataSources.Add(reportDataSource2);
            this.report_hd.LocalReport.DataSources.Add(reportDataSource3);
            this.report_hd.LocalReport.ReportEmbeddedResource = "GUI.Report1.rdlc";
            this.report_hd.Location = new System.Drawing.Point(3, 3);
            this.report_hd.Name = "report_hd";
            this.report_hd.ServerReport.BearerToken = null;
            this.report_hd.Size = new System.Drawing.Size(949, 416);
            this.report_hd.TabIndex = 0;
            // 
            // HOADONTableAdapter
            // 
            this.HOADONTableAdapter.ClearBeforeFill = true;
            // 
            // CHITIETHOADONBindingSource
            // 
            this.CHITIETHOADONBindingSource.DataMember = "CHITIETHOADON";
            this.CHITIETHOADONBindingSource.DataSource = this.QLMTDataSet;
            // 
            // CHITIETHOADONTableAdapter
            // 
            this.CHITIETHOADONTableAdapter.ClearBeforeFill = true;
            // 
            // SPDataSet1
            // 
            this.SPDataSet1.DataSetName = "SPDataSet1";
            this.SPDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SANPHAMBindingSource
            // 
            this.SANPHAMBindingSource.DataMember = "SANPHAM";
            this.SANPHAMBindingSource.DataSource = this.SPDataSet1;
            // 
            // SANPHAMTableAdapter
            // 
            this.SANPHAMTableAdapter.ClearBeforeFill = true;
            // 
            // Frm_baocao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Frm_baocao";
            this.Text = "Báo cáo ";
            this.Load += new System.EventHandler(this.Frm_baocao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HOADONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLMTDataSet)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CHITIETHOADONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SPDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SANPHAMBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private Microsoft.Reporting.WinForms.ReportViewer rp_sp;
        //private QLĐTDataSet QLĐTDataSet;
        //private QLĐTDataSetTableAdapters.SANPHAMTableAdapter SANPHAMTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer report_hd;
        private System.Windows.Forms.BindingSource HOADONBindingSource;
        private QLMTDataSet QLMTDataSet;
        private QLMTDataSetTableAdapters.HOADONTableAdapter HOADONTableAdapter;
        private System.Windows.Forms.BindingSource CHITIETHOADONBindingSource;
        private QLMTDataSetTableAdapters.CHITIETHOADONTableAdapter CHITIETHOADONTableAdapter;
        private System.Windows.Forms.BindingSource SANPHAMBindingSource;
        private SPDataSet1 SPDataSet1;
        private SPDataSet1TableAdapters.SANPHAMTableAdapter SANPHAMTableAdapter;
    }
}