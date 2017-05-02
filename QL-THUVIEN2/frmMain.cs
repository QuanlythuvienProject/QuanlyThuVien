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

namespace QL_THUVIEN2
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        SqlConnection cnn;
        string tk;
       
        public void KetNoi()
        {
            string ketnoi = @"Data Source=DESKTOP-TENJO5A\DUYET;Initial Catalog=DA_QLTV;Integrated Security=True";
            cnn = new SqlConnection(ketnoi);
            cnn.Open();
        }
        private void HienThi()
        {
            string sql = "select MaNV,TenNV,GioiTinh,DiaChi,SDT,NgaySinh,TaiKhoan from NHANVIEN";
            DataTable dtnv = new DataTable();
            DataSet dsnv = new DataSet();
            SqlCommand cmd = new SqlCommand(sql, cnn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dsnv);
            dtnv = dsnv.Tables[0];
            dgvnvdanhsach.DataSource = dtnv;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            paneldangnhap.Hide();
            paneldsnv.Enabled = false;
            panelqlphieu.Enabled = false;
            panelqldocgia.Enabled = false;
            panelbaocao.Enabled = false;
            panelqlnhanvien.Enabled = false;
            KetNoi();
            txtMa.Enabled = false;
            
        }
        private void update()
        {           
            string s = ttcnngaysinh.Value.Year + "/" + ttcnngaysinh.Value.Month + "/" + ttcnngaysinh.Value.Day;
            SqlCommand cmd = new SqlCommand("update NHANVIEN set TenNV=N'" + txtTen.Text + "',GioiTinh=N'" + txtGioTinh.Text + "',DiaChi=N'" + txtdiachi.Text + "',SDT='" + txtSodienthoai.Text + "',NgaySinh=convert(smalldatetime,'" + s.ToString() + "') where MaNV='"+txtMa.Text+"'", cnn);
            cmd.ExecuteNonQuery();

        }
        private void delete()
        {
            string sql = "delete from NHANVIEN where MaNV='" + txtMa.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.ExecuteNonQuery();
        }
        private void insert()
        {
            try
            {
                string s = ttcnngaysinh.Value.Year + "/" + ttcnngaysinh.Value.Month + "/" + ttcnngaysinh.Value.Day;
                string sql =
                    "insert into NHANVIEN(MaNV,TenNV,GioiTinh,DiaChi,SDT,NgaySinh) values('" + txtMa.Text + "',N'" + txtTen.Text + "',N'" + txtGioTinh.Text + "',N'" + txtdiachi.Text + "','" + txtSodienthoai.Text + "',convert(smalldatetime,'" + s.ToString() + "'))";
               
                SqlCommand cmd = new SqlCommand(sql, cnn);
                cmd.Parameters.Add(new SqlParameter("@date", ttcnngaysinh.Value.Date));
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

       
        private void btnDangxuat_Click_1(object sender, EventArgs e)
        {
            paneldangnhap.Hide();
            paneldsnv.Visible = false;
            panelqlphieu.Enabled = false;
            panelqldocgia.Enabled = false;
            panelbaocao.Enabled = false;
            panelqlnhanvien.Enabled = false;
            bttdangnhap.Enabled = true;
            panel6.Visible=true;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            frmDocGia frm3 = new frmDocGia();

            frm3.ShowDialog();
        }


        private void btnDoimatkhau_Click(object sender, EventArgs e)
        {
            
            frmThemtaikhoan frm= new frmThemtaikhoan();
            frm.Message = txtdntaikhoan.Text;
            frm.MK = txtdnmatkhau.Text;
            frm.ShowDialog();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            frmThongtinsach frm4 = new frmThongtinsach();

            frm4.ShowDialog();
        }


        private void button16_Click(object sender, EventArgs e)
        {
            new frmQuanlymuon().ShowDialog();
        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            KetNoi();
            string sql=@"select * from NHANVIEN where TaiKhoan='"+txtdntaikhoan.Text+"' and MatKhau = '"+txtdnmatkhau.Text+"' ";
            DataTable dt=new DataTable();
            DataSet ds=new DataSet();
            SqlCommand cmd=new SqlCommand(sql,cnn);
            SqlDataAdapter da= new SqlDataAdapter(cmd);
            da.Fill(ds);
            dt=ds.Tables[0];
            if(dt.Rows.Count>0)
            {
                MessageBox.Show("Đăng nhập thành công !");
                bttdangnhap.Enabled = false;
                paneldsnv.Enabled = true;
                panelqlphieu.Enabled = true;
                panelqldocgia.Enabled = true;
                panelbaocao.Enabled = true;
                panelqlnhanvien.Enabled = true;
                paneldangnhap.Hide();
            }
            else
            {
                MessageBox.Show("Tài Khoản hoặc Mật khẩu\n không chính xác!");
                txtdntaikhoan.Focus();
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            paneldangnhap.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtdnmatkhau.Clear();
            txtdntaikhoan.Clear();
            paneldangnhap.Visible = true;
            txtdntaikhoan.Focus();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            paneldsnv.Visible = true;
            HienThi();

        }

        private void btnNhanvien_Click(object sender, EventArgs e)
        {
            KetNoi();
            paneldsnv.Visible = true;
            HienThi();

        }

        private void dgvnvdanhsach_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            bttqltk.Visible = true;
            try
            {
                txtMa.Text = dgvnvdanhsach.Rows[i].Cells[0].Value.ToString().Trim();
                txtTen.Text = dgvnvdanhsach.Rows[i].Cells[1].Value.ToString().Trim();
                txtGioTinh.Text=dgvnvdanhsach.Rows[i].Cells[2].Value.ToString().Trim();
                txtdiachi.Text = dgvnvdanhsach.Rows[i].Cells[3].Value.ToString().Trim();
                txtSodienthoai.Text = dgvnvdanhsach.Rows[i].Cells[4].Value.ToString().Trim();
                DateTime dt =Convert.ToDateTime( dgvnvdanhsach.Rows[i].Cells[5].Value.ToString());
                ttcnngaysinh.Value = dt;
                tk = dgvnvdanhsach.Rows[i].Cells[6].Value.ToString();
            
            }
            catch (Exception ) {  }
        }

        private void btnThemmoi_Click(object sender, EventArgs e)
        {
            
            if (btnThemmoi.Text == "Thêm Mới")
            {
                btnThemmoi.Text = "Đồng Ý";
                bttqltk.Hide();
                txtSodienthoai.Clear();
                txtTen.Clear();
                txtGioTinh.Clear();
                txtdiachi.Clear();
                txtMa.Clear();
                ttcnngaysinh.Text = "";
                txtMa.Focus();
                txtMa.Enabled = true;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                return;
            }
            else
            {
     
                btnThemmoi.Text = "Thêm Mới";
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                bttqltk.Hide();
                insert();
                HienThi();
                txtMa.Enabled = false;
            }
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
        
            update();
            HienThi();
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            bttqltk.Hide();
            delete();
            HienThi();
        }

        private void bttqltk_Click(object sender, EventArgs e)
        {
            
            if (tk.ToString() =="")
            {
                frmThemtaikhoan frm = new frmThemtaikhoan();
                frm.MaNV = txtMa.Text;
                frm.ShowDialog(); 
            }
            else
            {
                MessageBox.Show("Nhân viên này đã có tài khoản");
            }
        }
        private void button11_Click(object sender, EventArgs e)
        {
            frmThongtinhaxuatban frm5 = new frmThongtinhaxuatban();
            frm5.ShowDialog();
        }
        private void button15_Click(object sender, EventArgs e)
        {
            new frmPhieuTra().ShowDialog();
        }

        private void listBox1_SelectedValueChanged(object sender, EventArgs e)
        {
           
                new Form8().ShowDialog();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new frmTheLoai().ShowDialog();
        }

        private void button21_Click(object sender, EventArgs e)
        {

            new frmBaocao().ShowDialog();
            string sql =
                " alter view dsmuon as select distinct dg.TenDG,s.TenSach,pm.NgayMuon,qlpm.HanTra,ts.PhatQuaHan from PHIEUMUON pm join QL_PHIEUMUON qlpm on pm.MaPM=qlpm.MaPM join DOCGIA dg on pm.MaDG=dg.MaDG join TRASACH ts on ts.MaPM=qlpm.MaPM join SACH s on s.MaSach=qlpm.MaSach  ";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.ExecuteNonQuery();
        }

        private void btnNhanvien_Click_1(object sender, EventArgs e)
        {
            KetNoi();
            paneldsnv.Visible = true;
            HienThi();

        }

       
    }
}
