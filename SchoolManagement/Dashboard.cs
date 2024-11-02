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

namespace SchoolManagement
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            display(); display2(); display3(); display4();
        }
        private void display()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-3BPR27I;Initial Catalog=SchoolDb; Integrated Security=True"); //connect to database
            con.Open();
            SqlCommand cmd = new SqlCommand("select count(*) from StudentDb ", con);//
            int c = Convert.ToInt32(cmd.ExecuteScalar());
            if (c > 0)
            {
                st.Text = Convert.ToString(c);
            }
            else st.Text = "0";

        }
        private void display2()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-3BPR27I;Initial Catalog=SchoolDb; Integrated Security=True"); //connect to database
            con.Open();
            SqlCommand cmd = new SqlCommand("select count(*) from SubjectDb ", con);//
            int c = Convert.ToInt32(cmd.ExecuteScalar());
            if (c > 0)
            {
                sb.Text = Convert.ToString(c);
            }
            else sb.Text = "0";

        }
        private void display3()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-3BPR27I;Initial Catalog=SchoolDb; Integrated Security=True"); //connect to database
            con.Open();
            SqlCommand cmd = new SqlCommand("select count(*) from TeacherDb ", con);//
            int c = Convert.ToInt32(cmd.ExecuteScalar());
            if (c > 0)
            {
                te.Text = Convert.ToString(c);
            }
            else te.Text = "0";

        }
        private void display4()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-3BPR27I;Initial Catalog=SchoolDb; Integrated Security=True"); //connect to database
            con.Open();
            SqlCommand cmd = new SqlCommand("select count(*) from EnrollmentDb", con);//
            int c = Convert.ToInt32(cmd.ExecuteScalar());
            if (c > 0)
            {
                en.Text = Convert.ToString(c);
            }
            else en.Text = "0";

        }

    }
}
