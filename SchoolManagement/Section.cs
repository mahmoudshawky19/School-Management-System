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
    public partial class Section : Form
    {
        public Section()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-3BPR27I;Initial Catalog=SchoolDb; Integrated Security=True"); //connect to database
            con.Open();
            SqlCommand cmd = new SqlCommand(@"insert into SectionDb values (@SectionID , @StudentName ,@Section)", con);//
            cmd.Parameters.AddWithValue("@SectionID", int.Parse(textsectionid.Text));
            cmd.Parameters.AddWithValue("@StudentName", textstudentnamesec.Text);
            cmd.Parameters.AddWithValue("@Section", textsection.Text);
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
            SqlCommand cmd = new SqlCommand(@"select * from SectionDb", con);//
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView4.DataSource = table;
            textsectionid.Text = "";
            textstudentnamesec.Text = "";
            textsection.Text = "";
            
        }

        private void btnUpdate2_Click(object sender, EventArgs e)
        {
            SqlConnection c = new SqlConnection(@"Data Source=DESKTOP-3BPR27I;Initial Catalog=SchoolDb; Integrated Security=True");
            c.Open();
            SqlCommand cmd = new SqlCommand("update SectionDb set  StudentName = @StudentName , Section = @Section where SectionId = @SectionId", c);
            cmd.Parameters.AddWithValue("@SectionId", int.Parse(textsectionid.Text));
            cmd.Parameters.AddWithValue("@StudentName", textstudentnamesec.Text);
            cmd.Parameters.AddWithValue("@Section", textsection.Text);
            cmd.ExecuteNonQuery();
            c.Close();
            MessageBox.Show("Record Updated sucessfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnDelete2_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(@"Data Source=DESKTOP-3BPR27I;Initial Catalog=SchoolDb; Integrated Security=True");
            cnn.Open();
            SqlCommand cnd = new SqlCommand("delete SectionDb where SectionId = @SectionId ", cnn);
            cnd.Parameters.AddWithValue("@SectionId", int.Parse(textsectionid.Text));
            cnd.ExecuteNonQuery();
            cnn.Close();
            MessageBox.Show("Record Deleted sucessfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnNew2_Click(object sender, EventArgs e)
        {
            textsectionid.Text = "";
            textstudentnamesec.Text = "";
            textsection.Text = "";
        }

        private void btnDisplay2_Click(object sender, EventArgs e)
        {
            SqlConnection sc = new SqlConnection(@"Data Source=DESKTOP-3BPR27I;Initial Catalog=SchoolDb; Integrated Security=True");
            sc.Open();
            SqlCommand cmd = new SqlCommand("select * from SectionDb", sc);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView4.DataSource = dt;

        }
    }
}
