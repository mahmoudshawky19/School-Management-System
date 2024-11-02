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
    public partial class Enrollment : Form
    {
        public Enrollment()
        {
            InitializeComponent();
        }

        private void textsectionen_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker2.CustomFormat = "dd/MM/yyyy";
        }

        private void dateTimePicker2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                dateTimePicker2.CustomFormat = "";
            }
        }

        private void btnSave2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-3BPR27I;Initial Catalog=SchoolDb; Integrated Security=True"); //connect to database
            con.Open();
            SqlCommand cmd = new SqlCommand(@"insert into EnrollmentDb values (@EId , @studentName ,@Section , @EnrollData)", con);//
            cmd.Parameters.AddWithValue("@EId", int.Parse(textEid.Text));
            cmd.Parameters.AddWithValue("@studentName", textstudentnameEn.Text);
            cmd.Parameters.AddWithValue("@Section", textsectionen.Text);
            cmd.Parameters.AddWithValue("@EnrollData", dateTimePicker2.Value);
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

        private void btnAdd2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-3BPR27I;Initial Catalog=SchoolDb; Integrated Security=True"); //connect to database
            con.Open();
            SqlCommand cmd = new SqlCommand(@"select * from EnrollmentDb", con);//
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView5.DataSource = table;
            textEid.Text = "";
            textstudentnameEn.Text = "";
            textsectionen.Text = "";
          
        }

        private void btnUpdate2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-3BPR27I;Initial Catalog=SchoolDb; Integrated Security=True"); //connect to database
            con.Open();
            SqlCommand cmd = new SqlCommand("update EnrollmentDb set studentName = @studentName , Section = @Section , EnrollData = @EnrollData  where EId = @EId ", con);//
            cmd.Parameters.AddWithValue("@EId", int.Parse(textEid.Text));
            cmd.Parameters.AddWithValue("@studentName", textstudentnameEn.Text);
            cmd.Parameters.AddWithValue("@Section", textsectionen.Text);
            cmd.Parameters.AddWithValue("@EnrollData", dateTimePicker2.Value);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Updated sucessfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnDelete2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-3BPR27I;Initial Catalog=SchoolDb; Integrated Security=True"); //connect to database
            con.Open();
            SqlCommand cmd = new SqlCommand("delete EnrollmentDb where EId = @EId", con);//
            cmd.Parameters.AddWithValue("@EId", int.Parse(textEid.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Deleted sucessfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnNew2_Click(object sender, EventArgs e)
        {
            textEid.Text = "";
            textstudentnameEn.Text = "";
            textsectionen.Text = "";

        }

        private void btnDisplay2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-3BPR27I;Initial Catalog=SchoolDb; Integrated Security=True"); //connect to database
            con.Open();
            SqlCommand cmd = new SqlCommand(@"select * from EnrollmentDb", con);//
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView5.DataSource = table;

        }

        private void textstudentnameEn_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
