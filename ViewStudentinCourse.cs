using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_management
{
    public partial class ViewStudentinCourse : Form
    {
        public ViewStudentinCourse()//constructor
        {
            InitializeComponent();
        }

        private void btn_View_Click(object sender, EventArgs e)//button view contain function"Students in course"
        {
            lstBoxStudents.Items.Clear();
            Admin admn = new Admin();
            Courses crs = new Courses();
            crs.read();
            bool check = false;
            for(int i=0;i<crs.course_list.Count;i++)//check for course code
            {
                if(crs.course_list[i].code==txtName.Text)
                {
                    check = true;
                    break;
                }
            }
            if(check == false)
            {
                lblerror.Text = "*No Course with this code !";
                return;
            }
       
            List<string> student_names = new List<string>();//list carry students in course
            student_names= admn.studentincourse(txtName.Text);

            if (student_names.Count != 0)
            {
                for (int i = 0; i < student_names.Count; i++)
                {
                    lstBoxStudents.Items.Add(student_names[i]);//add students to list box 
                }
            }
            else
            {
                lstBoxStudents.Items.Add("No Students in this Course !");
            }
            txtName.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)//button exit
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)//button back
        {
            adminmenu admn = new adminmenu();
            this.Hide();
            admn.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
