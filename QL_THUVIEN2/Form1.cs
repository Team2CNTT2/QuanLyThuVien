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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //SqlConnection cnn;
        clsDatabase cls = new QL_THUVIEN2.clsDatabase();
        string tk;
       
        //public void KetNoi()
        //{
        //    string ketnoi = @"Data Source=LAPTOP88-PC\SQLEXPRESS;Initial Catalog=DA_QLTV;Integrated Security=True";
        //    cnn = new SqlConnection(ketnoi);
        //    cnn.Open();
        //}
        private void HienThi()
        {
            //string sql = "select TaiKhoan,TenNV,GioiTinh,DiaChi,SDT,NgaySinh from NHANVIEN";
            //DataTable dtnv = new DataTable();
            //DataSet dsnv = new DataSet();
            //SqlCommand cmd = new SqlCommand(sql, cnn);
            //SqlDataAdapter da = new SqlDataAdapter(cmd);
            //da.Fill(dsnv);
            //dtnv = dsnv.Tables[0];
            //dgvnvdanhsach.DataSource = dtnv;
            cls.LoadData2DataGridView(dgvnvdanhsach, "select TaiKhoan,TenNV,GioiTinh,DiaChi,SDT,NgaySinh from NHANVIEN");
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            paneldangnhap.Hide();
            paneldsnv.Enabled = false;
            panelqlphieu.Enabled = false;
            panelqldocgia.Enabled = false;
            panelbaocao.Enabled = false;
            panelqlnhanvien.Enabled = false;
            panelbaocao.Enabled = false;
            //     panelqldocgia.Enabled = false;
            panelqlsach.Enabled = false;

            cls.KetNoi();
            ttcnma.Enabled = false;
           
           
            
        }
        private void update()
        {           
            string s = ttcnngaysinh.Value.Year + "/" + ttcnngaysinh.Value.Month + "/" + ttcnngaysinh.Value.Day;
           string cmd = "update NHANVIEN set TenNV=N'" + ttcnten.Text + "',GioiTinh=N'" + ttcngioitinh.Text + "',DiaChi=N'" + ttcndiachi.Text + "',SDT='" + ttcnsdt.Text + "',NgaySinh=convert(smalldatetime,'" + s.ToString() + "') where Taikhoan='"+ttcnma.Text+"'";
            //  cmd.ExecuteNonQuery();
            cls.ThucThiSQLTheoKetNoi(cmd);

        }
        private void delete()
        {
           
                string sql = "delete from NHANVIEN where TaiKhoan='" + ttcnma.Text + "'";
                //  SqlCommand cmd = new SqlCommand(sql, cnn);
                //  cmd.ExecuteNonQuery();
                cls.ThucThiSQLTheoKetNoi(sql);
            
        }
        private void insert()
        {
           
             
            string tk = "select COUNT(TaiKhoan) from NHANVIEN WHERE TaiKhoan='" + ttcnma.Text + "'";
                //      SqlCommand sl = new SqlCommand(mapm, cnn);
                //  cls.ThucThiSQLTheoKetNoi(mapm);
                int slg = cls.CheckID(tk);
                //(int)sl.ExecuteScalar();
                if (slg > 0) MessageBox.Show("Tài khoản này đã tồn tại");
                else
                {
                    string s = ttcnngaysinh.Value.Year + "/" + ttcnngaysinh.Value.Month + "/" + ttcnngaysinh.Value.Day;
                    string sql =
                        "insert into NHANVIEN(TaiKhoan,TenNV,GioiTinh,DiaChi,SDT,NgaySinh) values('" + ttcnma.Text + "',N'" + ttcnten.Text + "',N'" + ttcngioitinh.Text + "',N'" + ttcndiachi.Text + "','" + ttcnsdt.Text + "',convert(smalldatetime,'" + s.ToString() + "'))";

                    // SqlCommand cmd = new SqlCommand(sql, cnn);
                    //// cmd.Parameters.Add(new SqlParameter("@date", ttcnngaysinh.Value.Date));
                    //  cmd.ExecuteNonQuery();
                    cls.ThucThiSQLTheoKetNoi(sql);
                }
            
         
        }
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }


        private void button2_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to logout?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                paneldangnhap.Hide();
                paneldsnv.Visible = false;
                panelqlphieu.Enabled = false;
                panelqldocgia.Enabled = false;
                panelbaocao.Enabled = false;
                panelqlnhanvien.Enabled = false;
                bttdangnhap.Enabled = true;
                MessageBox.Show("Logout successfully!");
                    } 
            //panel6.Visible=true;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Reader frm3 = new Reader();

            frm3.ShowDialog();
        }


        private void button8_Click(object sender, EventArgs e)
        {
            
            TTTaiKhoan frm= new TTTaiKhoan();
            frm.Message = txtdntaikhoan.Text;
            frm.MK = txtdnmatkhau.Text;
            frm.ShowDialog();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            ThongTinSach frm4 = new ThongTinSach();

            frm4.ShowDialog();
        }


        private void button16_Click(object sender, EventArgs e)
        {
            new QuanLymuon().ShowDialog();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        // mat khau//
        public static string tendn, matkhau, quyen;
    //    SqlCommand sqlCommand;

     
        private void button22_Click(object sender, EventArgs e)
        {
            cls.KetNoi();
            tendn = txtdntaikhoan.Text;
            matkhau = txtdnmatkhau.Text;
            if (tendn != "")
            {
                object Q = cls.layGiaTri("select Quyenhan from NHANVIEN where TaiKhoan = '" + tendn + "' and MatKhau = '" + matkhau + "'");
                if (Q == null)
                {
                    MessageBox.Show("Account is incorrect!");
                    txtdntaikhoan.Clear();
                    txtdnmatkhau.Clear();
                }
                else
                {
                    MessageBox.Show("Login successfully!");
                    quyen = Convert.ToString(Q);
                    if (quyen == "admin")
                    {
                        paneldsnv.Enabled = true;
                        panelqlphieu.Enabled = true;
                        panelqldocgia.Enabled = true;
                        panelbaocao.Enabled = true;
                        panelqlnhanvien.Enabled = true;
                        button7.Enabled = true;
                        paneldangnhap.Hide();
                        panelbaocao.Enabled = true;
                        panelqlnhanvien.Enabled = true;
                        panelqlsach.Enabled = true;

                    }
                    if (quyen == "user")
                    {
                      
                        panelqlphieu.Enabled = true;
                        panelqldocgia.Enabled = true;
                        panelbaocao.Enabled = true;
                        panelqlnhanvien.Enabled = true;
                        button7.Enabled = false;
                        panelbaocao.Enabled = true;
                        panelqlnhanvien.Enabled = true;
                        //  button8.Enabled = false;
                        paneldangnhap.Hide();
                        panelqlsach.Enabled = true;
                    }
                }

            }
        }

        //    KetNoi();
        //    string sql=@"select * from NHANVIEN where TaiKhoan='"+txtdntaikhoan.Text+"' and MatKhau = '"+txtdnmatkhau.Text+"' ";
        //    DataTable dt=new DataTable();
        //    DataSet ds=new DataSet();
        //    SqlCommand cmd=new SqlCommand(sql,cnn);
        //    SqlDataAdapter da= new SqlDataAdapter(cmd);
        //    da.Fill(ds);
        //    dt=ds.Tables[0];
        //    if(dt.Rows.Count>0)
        //    {
        //        MessageBox.Show("Đăng nhập thành công !");
        //        bttdangnhap.Enabled = false;
        //        paneldsnv.Enabled = true;
        //        panelqlphieu.Enabled = true;
        //        panelqldocgia.Enabled = true;
        //        panelbaocao.Enabled = true;
        //        panelqlnhanvien.Enabled = true;
        //        paneldangnhap.Hide();
        //    }
        //    else
        //    {
        //        MessageBox.Show("Tài Khoản hoặc Mật khẩu\n không chính xác!");
        //        txtdntaikhoan.Focus();
        //    }
        //}

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

        private void button7_Click(object sender, EventArgs e)
        {
            cls.KetNoi();
            paneldsnv.Visible = true;
            HienThi();

        }

        private void dgvnvdanhsach_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
        //    bttqltk.Visible = true;
            try
            {
                ttcnma.Text = dgvnvdanhsach.Rows[i].Cells[0].Value.ToString().Trim();
                ttcnten.Text = dgvnvdanhsach.Rows[i].Cells[1].Value.ToString().Trim();
                ttcngioitinh.Text=dgvnvdanhsach.Rows[i].Cells[2].Value.ToString().Trim();
                ttcndiachi.Text = dgvnvdanhsach.Rows[i].Cells[3].Value.ToString().Trim();
                ttcnsdt.Text = dgvnvdanhsach.Rows[i].Cells[4].Value.ToString().Trim();
                DateTime dt =Convert.ToDateTime( dgvnvdanhsach.Rows[i].Cells[5].Value.ToString());
                ttcnngaysinh.Value = dt;
                tk = dgvnvdanhsach.Rows[i].Cells[6].Value.ToString();
            
            }
            catch (Exception ) {  }
        }

        private void bttttcnluu_Click(object sender, EventArgs e)
        {
            
           // if (bttttcnluu.Text == "Add")
           // {
           //     bttttcnluu.Text = "OK";
           ////     bttqltk.Hide();
           //     ttcnsdt.Clear();
           //     ttcnten.Clear();
           //     ttcngioitinh.Clear();
           //     ttcndiachi.Clear();
           //     ttcnma.Clear();
           //     ttcnngaysinh.Text = "";
           //     ttcnma.Focus();
           //     ttcnma.Enabled = true;
           //     button1.Enabled = false;
           //     bttqlnvxoa.Enabled = false;
           //     return;
           // }
           // else
           // {
     
           //     bttttcnluu.Text = "Add";
           //     button1.Enabled = true;
           //     bttqlnvxoa.Enabled = true;
           //  //   bttqltk.Hide();
           //     insert();
           //     HienThi();
           //     ttcnma.Enabled = false;
           // }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
        
            update();
            MessageBox.Show("Edit staff successfully!");
            HienThi();
        }

        private void button23_Click_1(object sender, EventArgs e)
        {
            //  bttqltk.Hide();
            if (MessageBox.Show("Do you want to delete?(Y/N)", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                delete();
                HienThi();
            }
        }

   
        private void button11_Click(object sender, EventArgs e)
        {
            TTNXB frm5 = new TTNXB();
            frm5.ShowDialog();
        }
        private void button15_Click(object sender, EventArgs e)
        {
            new PhieuTra().ShowDialog();
        }

        private void listBox1_SelectedValueChanged(object sender, EventArgs e)
        {
          
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Category().ShowDialog();
        }

        private void button21_Click(object sender, EventArgs e)
        {

            //new Form10().ShowDialog();
            //string sql =
            //    " alter view dsmuon as select distinct dg.TenDG,s.TenSach,pm.NgayMuon,qlpm.HanTra,ts.PhatQuaHan from PHIEUMUON pm join QL_PHIEUMUON qlpm on pm.MaPM=qlpm.MaPM join DOCGIA dg on pm.MaDG=dg.MaDG join TRASACH ts on ts.MaPM=qlpm.MaPM join SACH s on s.MaSach=qlpm.MaSach  ";
            //SqlCommand cmd = new SqlCommand(sql, cnn);
            //cmd.ExecuteNonQuery();
            TimKiemSach frm = new TimKiemSach();
            frm.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            thongtincanhan frm = new thongtincanhan();

            frm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormTaoTaiKhoan frm = new FormTaoTaiKhoan();
            frm.ShowDialog();
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            Rules frm = new Rules();
            frm.ShowDialog();
        }

        private void paneldsnv_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvnvdanhsach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ttcnsdt_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtdntaikhoan_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
