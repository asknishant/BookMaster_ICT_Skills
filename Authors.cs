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
    public partial class Authors : Form
    {
        public Authors()
        {
            InitializeComponent();
        }

        private void Authors_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string conString = @"Data Source = NISHANT\NISHANT; Initial Catalog = BookMaster; Integrated Security = True";
            string sqlcmd = "INSERT INTO [Authors] VALUES('" + textboxKey.Text + "','" + textBoxName.Text + "','" + textBoxBio.Text + "','" + birthdate.Text + "','" + deathDate.Text + "','" + textBoxWikipedia.Text + "')";

            SqlConnection con = new SqlConnection(conString);
            con.Open();
            SqlCommand cmd = new SqlCommand(sqlcmd, con);
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Added Successfully");
        }
    }
}
