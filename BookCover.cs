using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practice_project
{
    public partial class BookCover : Form
    {
        public BookCover()
        {
            InitializeComponent();
        }

        private void BookCover_Load(object sender, EventArgs e)
        {
            string conString = @"Data Source = NISHANT\NISHANT; Initial Catalog = BookMaster; Integrated Security = True";
            string cmd;
            cmd = "Select * from [books]";
            SqlConnection con = new SqlConnection(conString);

            SqlDataAdapter datadapter = new SqlDataAdapter(cmd, con);
            DataSet paging = new DataSet();
            con.Open();
            datadapter.Fill(paging);
            con.Close();
            comboBox1.DataSource = paging.Tables[0];
            comboBox1.ValueMember = "Key";
            comboBox1.DisplayMember = "Title";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                long coverfile = Convert.ToInt64(textBox1.Text);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter integer value" + ex.Message);
            }
            try
            {
                string conString = @"Data Source=NISHANT\NISHANT;Initial Catalog=BookMaster;Integrated Security=True";
                string cmd = "INSERT INTO [BookCovers] VALUES(" + textBox1.Text + ",'" + comboBox1.SelectedValue + "')";
                SqlConnection con = new SqlConnection(conString);

                con.Open();
                SqlCommand sqlCommand = new SqlCommand(cmd, con);
                sqlCommand.ExecuteNonQuery();
                
                con.Close();
               
                MessageBox.Show("Added Successfully");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }


}
