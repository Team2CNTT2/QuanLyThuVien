﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_THUVIEN2
{
    public partial class thongtincanhan : Form
    {
        public thongtincanhan()
        {
            InitializeComponent();
        }
        clsDatabase cls = new QL_THUVIEN2.clsDatabase();
        //private void ketnoi()
        //{
        //    string ketnoi = @"Data Source=LAPTOP88-PC\SQLEXPRESS;Initial Catalog=DA_QLTV;Integrated Security=True";
        //    cnn = new SqlConnection(ketnoi);
        //    cnn.Open();
        //}
     //   SqlConnection cnn;
        private void HienThi()
        {
            //DataTable dt = new DataTable();
            //DataSet ds = new DataSet();
            //SqlCommand cmd = new SqlCommand("select * from NHANVIEN where TAIKHOAN = '"+Form1.tendn+"'", cnn);
            //SqlDataAdapter da = new SqlDataAdapter(cmd);
            //da.Fill(ds);
            //dt = ds.Tables[0];
            //dataGridView1.DataSource = dt;
            cls.LoadData2DataGridView(dataGridView1, "select * from NHANVIEN where TAIKHOAN = '" + Form1.tendn + "'");
        }

        private void thongtincanhan_Load(object sender, EventArgs e)
        {
            cls.KetNoi();
           // ketnoi();
            HienThi();
        }

        //private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        
        //    //  txtSoDienThoai.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
        // //   DateTime dt = Convert.ToDateTime(dgvdsdg.Rows[i].Cells[5].Value.ToString());
        //}

        private void button5_Click(object sender, EventArgs e)
        {
            if (txtSoDienThoai.Text.Length - 1 <= 0)
                MessageBox.Show("Phone number cannot be smaller than 0!");
           else if (txtSoDienThoai.Text.ToString().Trim().Length - 1 >=12)
            {
                MessageBox.Show("Phone number cannot be bigger than 12 ");

            }
            else
            {

                string s = txtns.Value.Year + "/" + txtns.Value.Month + "/" + txtns.Value.Day;
                string cmd ="update NHANVIEN set TenNV=N'" + textBox1.Text + "',DiaChi=N'" + txtDiaChi.Text + "',NgaySinh=N'" + Convert.ToDateTime(s.ToString()) + "',SDT=N'" + txtSoDienThoai.Text + "',GioiTinh=N'" + txtGIOITINH.Text + "' where TAIKHOAN='" + Form1.tendn + "'";
                //    cmd.ExecuteNonQuery();
                cls.ThucThiSQLTheoKetNoi(cmd);
                HienThi();
                MessageBox.Show("Edit staff successfully!");
            }
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            //    bttqltk.Visible = true;
           
            textBox1.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            txtDiaChi.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            txtSoDienThoai.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            txtns.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
            txtGIOITINH.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            
          
        }
        //cls.LoadData2DataGridView(dataGridView1, "select * from tblNhanVien where TAIKHOAN='" + Main.TenDN + "'");

    }
}
