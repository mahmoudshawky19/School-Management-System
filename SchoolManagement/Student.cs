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
    public partial class Student : Form
    {
        public Student()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Student_Load(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
        }

        private void dateTimePicker1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Back)
            {
                dateTimePicker1.CustomFormat = "";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-3BPR27I;Initial Catalog=SchoolDb; Integrated Security=True"); //connect to database
            con.Open();
            SqlCommand cmd = new SqlCommand(@"insert into StudentDb values (@StudentId , @StudentName , @Dob , @Gender , @Phone , @Email)", con);//
            cmd.Parameters.AddWithValue("@StudentId", int.Parse(t1.Text));
            cmd.Parameters.AddWithValue("@StudentName", t2.Text);
            cmd.Parameters.AddWithValue("@Dob", dateTimePicker1.Value);
            cmd.Parameters.AddWithValue("@Gender", t3.Text);
            cmd.Parameters.AddWithValue("@Phone", t4.Text);
            cmd.Parameters.AddWithValue("@Email", t5.Text);

            try
            {
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record saved sucessfully", "save", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("There is an SubjectId with the same value", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-3BPR27I;Initial Catalog=SchoolDb; Integrated Security=True"); //connect to database
            con.Open();
            SqlCommand cmd = new SqlCommand(@"select * from StudentDb", con);//
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            da.Fill(table);
             dataGridView1.DataSource = table;
            t1.Text = "";
            t3.Text = "";
            t4.Text = "";
            t5.Text = "";
            t2.Text = "";

        }
        
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-3BPR27I;Initial Catalog=SchoolDb; Integrated Security=True"); //connect to database
            con.Open();
            SqlCommand cmd = new SqlCommand("update StudentDb set StudentName = @StudentName , Dob = @Dob , Gender = @Gender , Phone = @Phone , Email= @Email where StudentId = @StudentId ", con);//
            cmd.Parameters.AddWithValue("@StudentId", int.Parse(t1.Text));
            cmd.Parameters.AddWithValue("@StudentName", t2.Text);
            cmd.Parameters.AddWithValue("@Dob", dateTimePicker1.Value);
            cmd.Parameters.AddWithValue("@Gender", t3.Text);
            cmd.Parameters.AddWithValue("@Phone", t4.Text);
            cmd.Parameters.AddWithValue("@Email", t5.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Updated sucessfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-3BPR27I;Initial Catalog=SchoolDb; Integrated Security=True"); //connect to database
            con.Open();
            SqlCommand cmd = new SqlCommand("delete StudentDb where StudentId = @StudentId", con);//
            cmd.Parameters.AddWithValue("@StudentId", int.Parse(t1.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Deleted sucessfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            t1.Text = "";
            t3.Text = "";
            t4.Text = "";
            t5.Text = "";
            t2.Text = "";

        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
             SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-3BPR27I;Initial Catalog=SchoolDb; Integrated Security=True"); //connect to database
            con.Open();
            SqlCommand cmd = new SqlCommand(@"select * from StudentDb", con);//
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            da.Fill(table);
             dataGridView1.DataSource = table;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
 
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
