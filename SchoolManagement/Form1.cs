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
namespace SchoolManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-3BPR27I;Initial Catalog=SchoolDb; Integrated Security=True"); //connect to database
            con.Open();
            string Username = txtUsername.Text; 
            string Password = txtPassword.Text;
            SqlCommand cmd = new SqlCommand("select Username , Password from Logintab where Username ='" + txtUsername.Text + "' and Password ='" + txtPassword.Text + "'", con);//
            SqlDataAdapter dar = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dar.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                Main m = new Main();
                m.Show();
            
            }
            else
            {
                MessageBox.Show("Invalid username and password");
            }
            con.Close();
        
        }
    }
}
