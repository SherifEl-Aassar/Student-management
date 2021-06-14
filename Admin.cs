using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_management
{
    class Admin
    {
        public string name = "Amr";
        public string password = "123";
        public string id = "000";
        public static Admin adminobject = new Admin();
        public Student objectstudent = new Student();//object from student claas.
        public Courses objectcourse = new Courses(); //object from course class.
        public void ADDstudent(string name,string ID,string pass,string ac_year,List<string> finished,List<string>in_progress)
        {
            using (StreamWriter x = File.AppendText("student.txt"))// add to file student
            {
                //put the values in file.
                x.WriteLine("Name:" + name);
                x.WriteLine("ID:" + ID);
                x.WriteLine("Password:" +pass);
                x.WriteLine("Ac.year:" + ac_year);
                for (int i = 0; i < finished.Count; i++)
                {
                    if (i == 0)
                        x.Write("Finished:" + finished[i]);
                    else
                        x.Write("," + finished[i]);
                }
                x.WriteLine();//endl
                for (int i = 0; i < in_progress.Count; i++)
                {
                    if (i == 0)
                        x.Write("progress:" + in_progress[i]);
                    else
                        x.Write("," + in_progress[i]);
                }
                x.WriteLine();
                x.WriteLine("------------------------");
            }
           
        }
        public void ADDcourse(string name,string code,int max,string pre_req,string hours,int numstudents)
        {
           

            using (StreamWriter x = File.AppendText("Courses data.txt"))
            {
                x.WriteLine("Name:" + name);
                x.WriteLine("Code:" + code);
                x.WriteLine("Max:" + max);
                x.WriteLine("Students:" + numstudents);
                x.WriteLine("Pre:" + pre_req);
                x.WriteLine("Hours:" + hours);
                x.WriteLine("---------------------------");
            }

        }
        public List<string> studentincourse(string coursecode)//return list of students
        {
            List<string> nameofstudents = new List<string>();  //name of students in course
            objectstudent.readdata();
            for (int i = 0; i < objectstudent.student_list.Count; i++)
            {
                for (int j = 0; j < objectstudent.student_list[i].courses_progress.Count; j++)
                {

                    if (coursecode == objectstudent.student_list[i].courses_progress[j])
                    {
                        nameofstudents.Add(objectstudent.student_list[i].name);
                        break;
                    }
                }
            }
            return nameofstudents;
        }
        public List<string> progress(string nameofstudent)
        {
            objectstudent.readdata();//read data of student from file
            List<string> crs_progress = new List<string>();

            for (int i = 0; i < objectstudent.student_list.Count; i++)
            {
                if (nameofstudent == objectstudent.student_list[i].name)
                {

                    for (int j = 0; j < objectstudent.student_list[i].courses_progress.Count; j++)
                    { 
                        crs_progress.Add(objectstudent.student_list[i].courses_progress[j]);

                    }
                    break;
                }
            }
            return crs_progress;
        }//return list of progress of specific student
        public List<string> finish(string nameofstudent)
        {
            objectstudent.readdata();//read data of student from file
            List<string> crs_finish = new List<string>();
            for (int i = 0; i < objectstudent.student_list.Count; i++)
            {
                if (nameofstudent == objectstudent.student_list[i].name)
                {
                    for (int j = 0; j < objectstudent.student_list[i].finished_courses.Count; j++)
                    {

                        crs_finish.Add(objectstudent.student_list[i].finished_courses[j]);

                    }
                    break;
                }
            }
            return crs_finish;
        }//return list of finished courses of specific student
        public void editcoursedata(string oldname, string name, string code, int max, int students, string prereq, string hours)
        {

            string temp_code;
            objectcourse.read();
            for (int i = 0; i < objectcourse.course_list.Count; i++)
            {
                if (oldname == objectcourse.course_list[i].name)
                {
                    temp_code = objectcourse.course_list[i].code;
                    objectcourse.course_list[i].name = name;
                    objectcourse.course_list[i].code = code;
                    objectcourse.course_list[i].max_st = max;
                    objectcourse.course_list[i].no_of_students = students;
                    objectcourse.course_list[i].pre_req = prereq;
                    objectcourse.course_list[i].hours = hours;
                    objectcourse.Writedata();


                    // to change pre code in all file if old code changed
                    string text = File.ReadAllText("Courses data.txt");
                    text = text.Replace(temp_code, code);
                    File.WriteAllText("Courses data.txt", text);
                    //to change progress and finish code 
                    string text2 = File.ReadAllText("student.txt");
                    text2 = text2.Replace(temp_code, code);
                    File.WriteAllText("student.txt", text2);
                    break;
                }
            }
             
            
        }

    }//class
}//namespace
