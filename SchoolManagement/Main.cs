using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagement
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student s = new Student();
            s.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Subject sub = new Subject();
            sub.Show(); 
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Teacher t = new Teacher();
            t.Show(); 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Enrollment en = new Enrollment();
            en.Show();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Attendence at = new Attendence();
            at.Show();



        }

        private void button7_Click(object sender, EventArgs e)
        {
            Dashboard dd = new Dashboard();
            dd.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Section s = new Section();
            s.Show(); 
        }

        private void button8_Click(object sender, EventArgs e)
        {
           

        }
    }
}
