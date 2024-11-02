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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SchoolManagement
{
    public partial class Teacher : Form
    {
        public Teacher()
        {
            InitializeComponent();
        }

        private void Teacher_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-3BPR27I;Initial Catalog=SchoolDb; Integrated Security=True"); //connect to database
            con.Open();
            SqlCommand cmd = new SqlCommand(@"insert into TeacherDb values (@TeacherID , @TeacherName, @Gender , @Phone )", con);//
            cmd.Parameters.AddWithValue("@TeacherID", int.Parse(textteacherid.Text));
            cmd.Parameters.AddWithValue("@TeacherName", textteachername.Text);
            cmd.Parameters.AddWithValue("@Gender", textteachergender.Text);
            cmd.Parameters.AddWithValue("@Phone", textteacherphone.Text);
            try
            {
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record saved sucessfully", "save", MessageBoxButtons.OK, MessageBoxIcon.Information);
        
            }
            catch(Exception ex)
            {
                MessageBox.Show("There is an TeacherId with the same value", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            
        }

        private void btnAdd2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-3BPR27I;Initial Catalog=SchoolDb; Integrated Security=True"); //connect to database
            con.Open();
            SqlCommand cmd = new SqlCommand(@"select * from TeacherDb" , con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            cmd.ExecuteNonQuery();
            dataGridView3.DataSource = table;
            con.Close();
            textteacherid.Text = "";
            textteachername.Text = "";
            textteachergender.Text = "";
            textteacherphone.Text = "";
        }

        private void btnUpdate2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-3BPR27I;Initial Catalog=SchoolDb; Integrated Security=True"); //connect to database
            con.Open();
            SqlCommand cmd = new SqlCommand("update TeacherDb set TeacherName = @TeacherName , Gender = @Gender , Phone = @Phone where TeacherId = @TeacherId", con);
            cmd.Parameters.AddWithValue(@"TeacherId", int.Parse(textteacherid.Text));
            cmd.Parameters.AddWithValue("@TeacherName", textteachername.Text);
            cmd.Parameters.AddWithValue("@Gender", textteachergender.Text);
            cmd.Parameters.AddWithValue("@Phone", textteacherphone.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record updated sucessfully", "updated", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnDelete2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-3BPR27I;Initial Catalog=SchoolDb; Integrated Security=True"); //connect to database
            con.Open();
            SqlCommand cmd = new SqlCommand("delete TeacherDb where TeacherId = @TeacherId" , con);
            cmd.Parameters.AddWithValue(@"TeacherId", int.Parse(textteacherid.Text));
                            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Deleted sucessfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnNew2_Click(object sender, EventArgs e)
        {
            textteacherid.Text = "";
            textteachername.Text= "";
            textteachergender.Text = "";
            textteacherphone.Text= "";

        }

        private void btnDisplay2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-3BPR27I;Initial Catalog=SchoolDb; Integrated Security=True"); //connect to database
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from TeacherDb", con);
            SqlDataAdapter dt = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            dt.Fill(table);
            dataGridView3.DataSource = table; 
            con.Close();

        }
    }
}
