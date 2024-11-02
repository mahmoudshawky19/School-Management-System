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
    public partial class Subject : Form
    {
        public Subject()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-3BPR27I;Initial Catalog=SchoolDb; Integrated Security=True"); //connect to database
            con.Open();
            SqlCommand cmd = new SqlCommand(@"insert into SubjectDb values (@SubjectID , @SubjectName)", con);//
            cmd.Parameters.AddWithValue("@SubjectID", int.Parse(textsubjectid.Text));
            cmd.Parameters.AddWithValue("@SubjectName", textsubjectname.Text);
            
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

        private void btnAdd2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-3BPR27I;Initial Catalog=SchoolDb; Integrated Security=True"); //connect to database
            con.Open();
            SqlCommand cmd = new SqlCommand(@"select * from SubjectDb", con);//
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView2.DataSource = table;
            textsubjectid.Text = "";
            textsubjectname.Text = "";

        }

        private void btnUpdate2_Click(object sender, EventArgs e)
        {
            SqlConnection c = new SqlConnection(@"Data Source=DESKTOP-3BPR27I;Initial Catalog=SchoolDb; Integrated Security=True");
            c.Open();
            SqlCommand cmd = new SqlCommand("update SubjectDb set  SubjectName = @SubjectName where SubjectId = @SubjectId", c);
            cmd.Parameters.AddWithValue("@SubjectId", int.Parse(textsubjectid.Text));
            cmd.Parameters.AddWithValue("@SubjectName", textsubjectname.Text);
            cmd.ExecuteNonQuery();
            c.Close();
            MessageBox.Show("Record Updated sucessfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void btnDelete2_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(@"Data Source=DESKTOP-3BPR27I;Initial Catalog=SchoolDb; Integrated Security=True");
            cnn.Open();
            SqlCommand cnd = new SqlCommand("delete SubjectDb where SubjectId = @SubjectId ", cnn);
            cnd.Parameters.AddWithValue("@SubjectId" , int.Parse(textsubjectid.Text));
            cnd.ExecuteNonQuery();
            cnn.Close();
            MessageBox.Show("Record Deleted sucessfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnNew2_Click(object sender, EventArgs e)
        {
            textsubjectid.Text = "";
            textsubjectname.Text = "";

        }

        private void btnDisplay2_Click(object sender, EventArgs e)
        {
            SqlConnection sc = new SqlConnection(@"Data Source=DESKTOP-3BPR27I;Initial Catalog=SchoolDb; Integrated Security=True");
            sc.Open();
            SqlCommand cmd = new SqlCommand("select * from SubjectDb", sc);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView2.DataSource = dt; 





        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
