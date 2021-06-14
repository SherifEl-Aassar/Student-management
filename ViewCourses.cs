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
    public partial class ViewCourses : Form
    {
        public ViewCourses()//view courses in progress
        {
            InitializeComponent();

            List<string> vcrs = new List<string>();
            Student s1 = new Student();
            Courses c1 = new Courses();
            c1.read();


            vcrs=s1.viewcourses();


            if(vcrs.Count==0)
            {
                lstCourses.Items.Add("You have no courses in progress !");
                return;
            }

            for (int i = 0; i < vcrs.Count; i++)
            {

                for (int j = 0; j < c1.course_list.Count; j++)
                {
                    if (vcrs[i] == c1.course_list[j].code)
                    {
                        lstCourses.Items.Add(vcrs[i] + " ---> " + c1.course_list[j].name);
                        break;
                    }
                    
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            StudentMenu sm = new StudentMenu();
            this.Hide();
            sm.Show();
        }

        private void lstCourses_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
