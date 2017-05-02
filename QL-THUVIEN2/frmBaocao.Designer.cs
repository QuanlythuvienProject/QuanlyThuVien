namespace QL_THUVIEN2
{
    partial class frmBaocao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBaocao));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.dsmuonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DA_QLTVDataSet2 = new QL_THUVIEN2.DA_QLTVDataSet2();
            this.tRASACHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DA_QLTVDataSet = new QL_THUVIEN2.DA_QLTVDataSet();
            this.DOCGIABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DOCGIATableAdapter = new QL_THUVIEN2.DA_QLTVDataSetTableAdapters.DOCGIATableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.nHANVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nHANVIENTableAdapter = new QL_THUVIEN2.DA_QLTVDataSetTableAdapters.NHANVIENTableAdapter();
            this.btnThoat = new System.Windows.Forms.Button();
            this.qLPHIEUMUONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qL_PHIEUMUONTableAdapter = new QL_THUVIEN2.DA_QLTVDataSetTableAdapters.QL_PHIEUMUONTableAdapter();
            this.tRASACHTableAdapter = new QL_THUVIEN2.DA_QLTVDataSetTableAdapters.TRASACHTableAdapter();
            this.dsmuonTableAdapter = new QL_THUVIEN2.DA_QLTVDataSet2TableAdapters.dsmuonTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dsmuonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DA_QLTVDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRASACHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DA_QLTVDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DOCGIABindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLPHIEUMUONBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dsmuonBindingSource
            // 
            this.dsmuonBindingSource.DataMember = "dsmuon";
            this.dsmuonBindingSource.DataSource = this.DA_QLTVDataSet2;
            // 
            // DA_QLTVDataSet2
            // 
            this.DA_QLTVDataSet2.DataSetName = "DA_QLTVDataSet2";
            this.DA_QLTVDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tRASACHBindingSource
            // 
            this.tRASACHBindingSource.DataMember = "TRASACH";
            this.tRASACHBindingSource.DataSource = this.DA_QLTVDataSet;
            // 
            // DA_QLTVDataSet
            // 
            this.DA_QLTVDataSet.DataSetName = "DA_QLTVDataSet";
            this.DA_QLTVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DOCGIABindingSource
            // 
            this.DOCGIABindingSource.DataMember = "DOCGIA";
            this.DOCGIABindingSource.DataSource = this.DA_QLTVDataSet;
            // 
            // DOCGIATableAdapter
            // 
            this.DOCGIATableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.reportViewer1);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // reportViewer1
            // 
            resources.ApplyResources(this.reportViewer1, "reportViewer1");
            reportDataSource1.Name = "dsmuon";
            reportDataSource1.Value = this.dsmuonBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QL_THUVIEN2.Report1.rdlc";
            this.reportViewer1.Name = "reportViewer1";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.nHANVIENBindingSource;
            this.comboBox1.DisplayMember = "TenNV";
            resources.ApplyResources(this.comboBox1, "comboBox1");
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // nHANVIENBindingSource
            // 
            this.nHANVIENBindingSource.DataMember = "NHANVIEN";
            this.nHANVIENBindingSource.DataSource = this.DA_QLTVDataSet;
            // 
            // nHANVIENTableAdapter
            // 
            this.nHANVIENTableAdapter.ClearBeforeFill = true;
            // 
            // btnThoat
            // 
            resources.ApplyResources(this.btnThoat, "btnThoat");
            this.btnThoat.Image = global::QL_THUVIEN2.Properties.Resources.delete2;
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // qLPHIEUMUONBindingSource
            // 
            this.qLPHIEUMUONBindingSource.DataMember = "QL_PHIEUMUON";
            this.qLPHIEUMUONBindingSource.DataSource = this.DA_QLTVDataSet;
            // 
            // qL_PHIEUMUONTableAdapter
            // 
            this.qL_PHIEUMUONTableAdapter.ClearBeforeFill = true;
            // 
            // tRASACHTableAdapter
            // 
            this.tRASACHTableAdapter.ClearBeforeFill = true;
            // 
            // dsmuonTableAdapter
            // 
            this.dsmuonTableAdapter.ClearBeforeFill = true;
            // 
            // frmBaocao
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "frmBaocao";
            this.Load += new System.EventHandler(this.Form10_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsmuonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DA_QLTVDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRASACHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DA_QLTVDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DOCGIABindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLPHIEUMUONBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource DOCGIABindingSource;
        private DA_QLTVDataSet DA_QLTVDataSet;
        private DA_QLTVDataSetTableAdapters.DOCGIATableAdapter DOCGIATableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource nHANVIENBindingSource;
        private DA_QLTVDataSetTableAdapters.NHANVIENTableAdapter nHANVIENTableAdapter;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.BindingSource qLPHIEUMUONBindingSource;
        private DA_QLTVDataSetTableAdapters.QL_PHIEUMUONTableAdapter qL_PHIEUMUONTableAdapter;
        private System.Windows.Forms.BindingSource tRASACHBindingSource;
        private DA_QLTVDataSetTableAdapters.TRASACHTableAdapter tRASACHTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource dsmuonBindingSource;
        private DA_QLTVDataSet2 DA_QLTVDataSet2;
        private DA_QLTVDataSet2TableAdapters.dsmuonTableAdapter dsmuonTableAdapter;
    }
}