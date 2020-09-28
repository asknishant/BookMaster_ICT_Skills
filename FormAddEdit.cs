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
    public partial class FormAddEdit : Form
    {
        SqlDataAdapter dataAdapter;
        DataSet pagingDs;
        string id, properties;
        public FormAddEdit(string value,string properties)
        {
            InitializeComponent();
            id = value;
            this.properties = properties;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string conString = @"Data Source = NISHANT\NISHANT; Initial Catalog = BookMaster; Integrated Security = True";
            string sqlcmd = "Select from [Customers]";
            SqlConnection con = new SqlConnection(conString);
            dataAdapter = new SqlDataAdapter(sqlcmd, con);
            pagingDs = new DataSet();
            con.Open();
            dataAdapter.Fill(pagingDs);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(properties=="Add")
            {
                string conString = @"Data Source = NISHANT\NISHANT; Initial Catalog = BookMaster; Integrated Security = True";
                string sqlcmd = "Insert into [Customers] Values('"+ textBox1.Text+"','"+textBox2.Text+"','"+textBox3.Text+"','"+textBox4.Text+"','"+textBox5.Text+"','"+textBox6.Text+"')";
                SqlConnection con = new SqlConnection(conString);
                dataAdapter = new SqlDataAdapter(sqlcmd, con);
                pagingDs = new DataSet();
                con.Open();
                dataAdapter.Fill(pagingDs);

                MessageBox.Show("Customer Added Successsfully");
                Form3 frm3 = new Form3();
                frm3.Show();
                this.Hide();
            }

            if (properties == "Edit")
            {
                string conString = @"Data Source = NISHANT\NISHANT; Initial Catalog = BookMaster; Integrated Security = True";
                string sqlcmd = "Update [Customers] set Name = '"+ textBox2.Text + "'Address = '"+textBox2.Text+"'Zip ='"+textBox3.Text+"'city ='"+textBox4.Text+"'Phone = '"+textBox5.Text+"'Email = '"+textBox6.Text+"'";
                SqlConnection con = new SqlConnection(conString);
                dataAdapter = new SqlDataAdapter(sqlcmd, con);
                pagingDs = new DataSet();
                con.Open();
                dataAdapter.Fill(pagingDs);

                MessageBox.Show("Customer Added Successsfully");
                Form3 frm3 = new Form3();
                frm3.Show();
                this.Hide();
            }
        }

        private void FormAddEdit_Load(object sender, EventArgs e)
        {
            textBox1.Text = id;
        }
    }
}
