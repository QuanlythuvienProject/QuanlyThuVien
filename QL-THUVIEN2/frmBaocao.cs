using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using System.Data.SqlClient;
namespace QL_THUVIEN2
{
    public partial class frmBaocao : Form
    {
        public frmBaocao()
        {
            InitializeComponent();
        }
        SqlConnection cnn;
        public void KetNoi()
        {
            string ketnoi = @"Data Source=DESKTOP-TENJO5A\DUYET;Initial Catalog=DA_QLTV;Integrated Security=True";
            cnn = new SqlConnection(ketnoi);
            cnn.Open();
        }
        private void Form10_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DA_QLTVDataSet2.dsmuon' table. You can move, or remove it, as needed.
           this.dsmuonTableAdapter.Fill(this.DA_QLTVDataSet2.dsmuon);
            KetNoi();
            // TODO: This line of code loads data into the 'DA_QLTVDataSet.TRASACH' table. You can move, or remove it, as needed.
            this.tRASACHTableAdapter.Fill(this.DA_QLTVDataSet.TRASACH);
            // TODO: This line of code loads data into the 'DA_QLTVDataSet.QL_PHIEUMUON' table. You can move, or remove it, as needed.
            this.qL_PHIEUMUONTableAdapter.Fill(this.DA_QLTVDataSet.QL_PHIEUMUON);
            // TODO: This line of code loads data into the 'DA_QLTVDataSet.NHANVIEN' table. You can move, or remove it, as needed.
            this.nHANVIENTableAdapter.Fill(this.DA_QLTVDataSet.NHANVIEN);
            // TODO: This line of code loads data into the 'DA_QLTVDataSet.DOCGIA' table. You can move, or remove it, as needed.
            this.DOCGIATableAdapter.Fill(this.DA_QLTVDataSet.DOCGIA);
         
            
            this.reportViewer1.RefreshReport();
        }


        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
