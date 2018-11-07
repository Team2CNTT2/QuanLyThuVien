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
    public partial class Reader : Form
    {
        public Reader()
        {
            InitializeComponent();
        }
      
        clsDatabase cls = new QL_THUVIEN2.clsDatabase();
      
        private void insert()
        {
            try
            {
                if (txtma.Text == "")
                {
                    MessageBox.Show("The reader ID is empty!");
                }
                else if (txtten.Text == "")
                {
                    MessageBox.Show("The reader's name is empty!");
                }
                else
                {
                    string s = txtns.Value.Year + "/" + txtns.Value.Month + "/" + txtns.Value.Day;
                    string sql =
                        "insert into DOCGIA (MaDG,TenDG,GioiTinh,DiaChi,SDT,NgaySinh) values ('" + txtma.Text + "',N'" + txtten.Text + "',N'" + txtgt.Text + "',N'" + txtdc.Text + "','" + txtstd.Text + "',convert(smalldatetime,'" + s.ToString() + "'))";

                    cls.ThucThiSQLTheoKetNoi(sql);
                    MessageBox.Show("Success!");
                }
            }
            catch (Exception) { MessageBox.Show("Account already exists!"); }
        }
        private void update()
        {
            string s = txtns.Value.Year + "/" + txtns.Value.Month + "/" + txtns.Value.Day;
            string update =
                "update DOCGIA set TenDG=N'" + txtten.Text + "',GioiTinh=N'" + txtgt.Text + "',DiaChi=N'" + txtdc.Text + "',SDT='" + txtstd.Text + "',NgaySinh='" + Convert.ToDateTime(s.ToString()) + "' WHERE MaDG='" + txtma.Text + "'";
            
            cls.ThucThiSQLTheoKetNoi(update);
        }
        private void delete()
        {
            
            string delete1= "DELETE TRASACH WHERE MAPM=(SELECT MAPM FROM PHIEUMUON WHERE MAPM=TRASACH.MAPM AND MaDG='" + txtma.Text + "')";
            cls.ThucThiSQLTheoKetNoi(delete1);
            string delete2 = "DELETE QL_PHIEUMUON WHERE MAPM=(SELECT MAPM FROM PHIEUMUON WHERE MAPM=QL_PHIEUMUON.MAPM AND MaDG='" + txtma.Text + "')";
            cls.ThucThiSQLTheoKetNoi(delete2);
            string delete = "delete from phieumuon where MaDG='" + txtma.Text + "'";
            cls.ThucThiSQLTheoKetNoi(delete);
           
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            paneldg.Visible = true;
           // if()
            cls.KetNoi();
            cls.LoadData2DataGridView(dgvdsdg, "select *from DOCGIA");

            txtma.Enabled = false;
        }

        private void bttttcnluu_Click(object sender, EventArgs e)
        {
            txtdc.Clear();
            txtgt.Clear();
            txtma.Clear();
            txtstd.Clear();
            txtten.Clear();
            txtma.Focus();
        }


        private void dgvdsdg_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            try
            {
                txtma.Text = dgvdsdg.Rows[i].Cells[0].Value.ToString().Trim();
                txtten.Text = dgvdsdg.Rows[i].Cells[1].Value.ToString().Trim();
                txtgt.Text = dgvdsdg.Rows[i].Cells[2].Value.ToString().Trim();
                txtdc.Text = dgvdsdg.Rows[i].Cells[3].Value.ToString().Trim();
                txtstd.Text = dgvdsdg.Rows[i].Cells[4].Value.ToString().Trim();
                DateTime dt = Convert.ToDateTime(dgvdsdg.Rows[i].Cells[5].Value.ToString());
                txtns.Value = dt;
                cls.LoadData2DataGridView(dgvchitiet, "select  masach, sum(soluongSM)  tongSM from PHIEUMUON, QL_PHIEUMUON where PHIEUMUON.MaPM = QL_PHIEUMUON.MaPM and madg='" + txtma.Text + "' group by masach");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void bttttcnluu_Click_1(object sender, EventArgs e)
        {
            if (bttthemmoi.Text == "Add")
            {
                // txtma.Focus();
                txtma.Clear();
                txtstd.Clear();
                txtten.Clear();
                txtdc.Clear();
                txtgt.Clear();
                txtma.Enabled = true;
                bttthemmoi.Text = "OK";
                bttsua.Enabled = false;
                bttxoa.Enabled = false;
                txtma.Focus();

            }
            else
            {
                insert();
                //  HienThi();
            
                cls.LoadData2DataGridView(dgvdsdg, "select *from docgia");
                txtma.Enabled = false;
                bttthemmoi.Text = "Add";
                bttsua.Enabled = true;
                bttxoa.Enabled = true;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            update();
            MessageBox.Show(" Edit item successfully!");
            cls.LoadData2DataGridView(dgvdsdg, "select *from DOCGIA");
        }

        private void bttqlnvxoa_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want delete?(Y/N)", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                delete();
                string delete1 = "delete DOCGIA where MaDG='" + txtma.Text + "'";
                cls.ThucThiSQLTheoKetNoi(delete1);
                MessageBox.Show("Delete item successfully!");
            }
            cls.LoadData2DataGridView(dgvdsdg, "select *from DOCGIA");
            //HienThi();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtma_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
