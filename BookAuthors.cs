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
    public partial class BookAuthors : Form
    {
        public BookAuthors()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string conString = @"Data Source = NISHANT\NISHANT; Initial Catalog = BookMaster; Integrated Security = True";
            string cmd;
            cmd = "INSERT INTO [bookauthors] VALUES('" + comboBox1.SelectedValue + "','" + comboBox2.SelectedValue + "')";
            SqlConnection con = new SqlConnection(conString);

            con.Open();
            SqlCommand sqlCommand = new SqlCommand(cmd, con);
            sqlCommand.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Added Successfully");


        }

        private void BookAuthors_Load(object sender, EventArgs e)
        {
            string conString = @"Data Source = NISHANT\NISHANT; Initial Catalog = BookMaster; Integrated Security = True";
            string cmd;
            cmd = "Select * from [Books]";
            SqlConnection con = new SqlConnection(conString);

            SqlDataAdapter datadapter = new SqlDataAdapter(cmd, con);
            DataSet paging = new DataSet();
            con.Open();
            datadapter.Fill(paging);
            con.Close();
            comboBox1.DataSource = paging.Tables[0];
            comboBox1.ValueMember = "Key";
            comboBox1.DisplayMember = "Title";

            
            string cmd2 = "Select * from [Authors]";
            SqlConnection con2 = new SqlConnection(conString);

            SqlDataAdapter datadapter2 = new SqlDataAdapter(cmd2, con2);
            DataSet paging2 = new DataSet();
            con2.Open();
            datadapter2.Fill(paging2);
            con2.Close();
            comboBox2.DataSource = paging2.Tables[0];
            comboBox2.ValueMember = "Key";
            comboBox2.DisplayMember = "Name";

        }
    }
}
