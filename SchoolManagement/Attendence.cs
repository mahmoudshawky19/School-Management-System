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
    public partial class Attendence : Form
    {
        public Attendence()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnSave2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-3BPR27I;Initial Catalog=SchoolDb; Integrated Security=True"); //connect to database
            con.Open();
            SqlCommand cmd = new SqlCommand(@"insert into AttendenceDb values (@AId , @StudentName ,@Status  )", con);//
            cmd.Parameters.AddWithValue("@AId", int.Parse(textAid.Text));
            cmd.Parameters.AddWithValue("@StudentName", textstudentnameAid.Text);
            cmd.Parameters.AddWithValue("@Status", textstatus.Text);
             try
            {
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record saved sucessfully", "save", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("There is an StudentId with the same value", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        private void Attendence_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-3BPR27I;Initial Catalog=SchoolDb; Integrated Security=True"); //connect to database
            con.Open();
            SqlCommand cmd = new SqlCommand(@"select * from AttendenceDb", con);//
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView6.DataSource = table;
            textAid.Text = "";
            textstudentnameAid.Text = "";
            textstatus.Text = "";
 
        }

        private void btnUpdate2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-3BPR27I;Initial Catalog=SchoolDb; Integrated Security=True"); //connect to database
            con.Open();
            SqlCommand cmd = new SqlCommand("update AttendenceDb set StudentName = @StudentName , Status = @Status where AId = @AId ", con);//
            cmd.Parameters.AddWithValue("@AId", int.Parse(textAid.Text));
            cmd.Parameters.AddWithValue("@StudentName", textstudentnameAid.Text);
             cmd.Parameters.AddWithValue("@Status", textstatus.Text);
 
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Updated sucessfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void btnDelete2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-3BPR27I;Initial Catalog=SchoolDb; Integrated Security=True"); //connect to database
            con.Open();
            SqlCommand cmd = new SqlCommand("delete AttendenceDb where AId = @AId", con);//
            cmd.Parameters.AddWithValue("@AId", int.Parse(textAid.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Deleted sucessfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void btnNew2_Click(object sender, EventArgs e)
        {
            textAid.Text = "";
            textstudentnameAid.Text = "";
            textstatus.Text = "";

        }

        private void btnDisplay2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-3BPR27I;Initial Catalog=SchoolDb; Integrated Security=True"); //connect to database
            con.Open();
            SqlCommand cmd = new SqlCommand(@"select * from AttendenceDb", con);//
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView6.DataSource = table;
             
        }
    }
}
