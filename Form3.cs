using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practice_project
{
    public partial class Form3 : Form
    {
        SqlDataAdapter dataAdapter;
        DataSet pagingDs;
        string ciid;
        string property;
        public Form3()
        {
            InitializeComponent();
        }

       
        private void Form3_Load(object sender, EventArgs e)
        {
            string conString = @"Data Source = NISHANT\NISHANT; Initial Catalog = BookMaster; Integrated Security = True";

            string sqlcmd = "Select * from [Customers]";
            SqlConnection con = new SqlConnection(conString);
            dataAdapter = new SqlDataAdapter(sqlcmd,con);
            pagingDs = new DataSet();
            con.Open();
            dataAdapter.Fill(pagingDs);
            con.Close();
            dataGridView1.DataSource = pagingDs.Tables[0];
            int count = pagingDs.Tables[0].Rows.Count;
            string str = pagingDs.Tables[0].Rows[count - 1][0].ToString();
            int cid = Convert.ToInt32(str.Replace("C", "").Trim()) + 1;

            label3.Text = "C" + cid;
            ciid = "C" + cid;
        }
       
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            textBox1.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string conString = @"Data Source = NISHANT\NISHANT; Initial Catalog = BookMaster; Integrated Security = True";

            string sqlcmd ="";
            if(textBox1.Text == "" && textBox2.Text == "")
            {
                sqlcmd = "Select * from [Customers]";
            } else
            {
                sqlcmd = "Select * from [Customers] where ID='" + textBox1.Text + "'or Name='" + textBox2.Text + "'";
            }

            SqlConnection con = new SqlConnection(conString);
            dataAdapter = new SqlDataAdapter(sqlcmd, con);
            pagingDs = new DataSet();
            con.Open();
            dataAdapter.Fill(pagingDs);

            con.Close();
            if(pagingDs.Tables[0].Rows.Count > 0)
            {
                dataGridView1.DataSource = pagingDs.Tables[0];
            }
            else
            {
                MessageBox.Show("No Entry Matched teh search criteria");
                textBox1.Text = "";
                textBox2.Text = "";
                sqlcmd = "Select * from [Customers]";
                SqlConnection scon = new SqlConnection(conString);
                dataAdapter = new SqlDataAdapter(sqlcmd, scon);
                pagingDs = new DataSet();
                scon.Open();
                dataAdapter.Fill(pagingDs);
                scon.Close();
                dataGridView1.DataSource = pagingDs.Tables[0];
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormAddEdit ffrm4 = new FormAddEdit(ciid,"Add");
            ffrm4.Show();
            this.Hide();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            FormAddEdit frm4 = new FormAddEdit(textBox1.Text, "Edit");
            frm4.Show();
            this.Hide();
        }

    }
}
