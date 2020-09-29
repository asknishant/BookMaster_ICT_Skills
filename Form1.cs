using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practice_project
{
    public partial class Form1 : Form
    {
        SqlDataAdapter dataAdapter;
        DataSet pagingDs;
        int scroll;
        int count = 0;
        bool loginsession = false;

        public Form1(bool getVal)
        {
            InitializeComponent();
            scroll = 0;
            loginsession = getVal;
        }

        private void loadData()
        {
            string conString = @"Data Source = NISHANT\NISHANT; Initial Catalog = BookMaster; Integrated Security = True";
            string sqlcmd = "Select * from [issues]";
            SqlConnection con = new SqlConnection(conString);
            dataAdapter = new SqlDataAdapter(sqlcmd, con);
            pagingDs = new DataSet();
            con.Open();

            dataAdapter.Fill(pagingDs, scroll, 5, "issues");
            con.Close();
            dataGridView1.DataSource = pagingDs;
            dataGridView1.DataMember = "issues";
            SqlDataAdapter da = new SqlDataAdapter(sqlcmd, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            lblTotal.Text = "Books Found = " + ds.Tables[0].Rows.Count;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                loadData();
            }catch(Exception ex)
            {
                lblTotal.Text = ex.Message;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void relationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnright_Click(object sender, EventArgs e)
        {
            scroll += 5;
            if(scroll > 13)
            {
                scroll = 5;
            }
            if(count>=0)
                count++;
            lblCount.Text = count.ToString();
            pagingDs.Clear();
            dataAdapter.Fill(pagingDs, scroll, 5, "issues");
        }

        private void btnleft_Click(object sender, EventArgs e)
        {
            scroll -= 5;
            if(scroll <= 0)
            {
                scroll = 0;
            }
            if( count<=3)
                count--;
            lblCount.Text = count.ToString();
            pagingDs.Clear();
            dataAdapter
                .Fill(pagingDs, scroll, 5, "issues");
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
            this.Hide();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();//Login hi dikhaega na 
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(fileToolStripMenuItem.DropDownItems.Count > 0)
            {
                if(loginsession)
                {
                    fileToolStripMenuItem.DropDownItems[0].Text = "Logout";
                }
                else
                {
                    fileToolStripMenuItem.DropDownItems[0].Text = "Login";
                }
            }
        }

        private void manageCustomesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show();
            this.Hide();
        }

        private void manageToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void booksToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Books bks = new Books();
            bks.Show();
        }

        private void authorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Authors author = new Authors();
            author.Show();
        }

        private void bookAuthorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookAuthors bauthor = new BookAuthors();
            bauthor.Show();
        }

        private void bookCoverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookCover author = new BookCover();
            author.Show();
        }

        private void bookSubjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookSubjects author = new BookSubjects();
            author.Show();
        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports reports = new Reports();
            reports.Show();
        }
    }
}
