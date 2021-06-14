using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_management
{
    class Student 
    {

        public string name;
        public string ID;
        public string pass;
        public string academic_year;
        public List<string> finished_courses = new List<string>();
        public List<string> courses_progress = new List<string>();
        public static Courses course_object = new Courses();
        public List<Student> student_list = new List<Student>();
        public static Student single_student = new Student();
     
       



        /*------------Logged in student's data---------------*/
        public static string _name;
        public static string _ac_year;
        public static string _ID;
        public static string _pass;
        public static List<string> _finished_courses = new List<string>();
        public static List<string> _courses_progress = new List<string>();
        /*------------------------------------------------*/
      



        public List<string> course_name_year = new List<string>();


        public void readdata()
        {
            StreamReader read = new StreamReader("student.txt");
            string record;
            char[] dels = { ':', ',', '.', '-' };
            record = read.ReadLine();
            while (record != null)
            {
                if (record.Contains("Name:"))
                {
                    string[] substring = record.Split(dels).ToArray();
                    for (int i = 1; i < substring.Length; i++)
                    {
                        single_student.name = substring[i].ToString();
                    }
                }
                else if (record.Contains("ID"))
                {

                    string[] substring = record.Split(dels).ToArray();

                    for (int i = 1; i < substring.Length; i++)
                    {

                        single_student.ID = substring[i].ToString();
                    }
                }
                else if (record.Contains("Password"))
                {

                    string[] substring = record.Split(dels).ToArray();

                    for (int i = 1; i < substring.Length; i++)
                    {

                        single_student.pass = substring[i].ToString();
                    }
                }
                else if (record.Contains("AcYear:"))
                {

                    string[] substring = record.Split(':').ToArray();

                    for (int i = 1; i < substring.Length; i++)
                    {
                        single_student.academic_year = substring[i].ToString();
                    }
                }
                else if (record.Contains("Finished:"))
                {
                    string[] substring = record.Split(dels).ToArray();

                    for (int i = 1; i < substring.Length; i++)
                    {

                        single_student.finished_courses.Add(substring[i].ToString());
                    }
                }

                else if (record.Contains("progress:"))
                {
                    string[] substring = record.Split(dels).ToArray();

                    for (int i = 1; i < substring.Length; i++)
                    {

                        single_student.courses_progress.Add(substring[i].ToString());
                    }
                }

                else if (record.Contains("-----------------"))
                {
                    student_list.Add(single_student);

                    single_student = new Student();
                }
                record = read.ReadLine();
            }
            read.Close();
           

        }//read data of student from file and put in an array
        public void login2(string x)//x is the entered ID
        {
            
            for (int i = 0; i < student_list.Count; i++)
            {
                if (x == student_list[i].ID)
                {
                    _name = student_list[i].name;
                    _ac_year = student_list[i].academic_year;
                    _ID = student_list[i].ID;
                    _pass = student_list[i].pass;
                    for (int j = 0; j < student_list[i].finished_courses.Count; j++)
                    {
                        _finished_courses.Add(student_list[i].finished_courses[j]);
                    }
                    for (int j = 0; j < student_list[i].courses_progress.Count; j++)
                    {
                        _courses_progress.Add(student_list[i].courses_progress[j]);
                    }
                    break;
                }
            }
        }

        public List<string> avcourse()
        {
            List<string> crs = new List<string>();

            string avrec;
            char[] del = { ':', ',', '.', '\t' };
            StreamReader av = new StreamReader("Courses data.txt");
            avrec = av.ReadLine();
            readdata();
            course_object.read();
            while (avrec != null)
            {
                if (_ac_year == "1")
                {
                    if (avrec.Contains("First year"))
                    {
                        string[] sub = avrec.Split(del).ToArray();
                        for (int i = 1; i < sub.Length; i++)
                        {
                            course_name_year.Add(sub[i]);
                        }
                        for (int i = 0; i < course_name_year.Count; i++)
                        {
                            for (int j = 0; j < course_object.course_list.Count; j++)
                            {
                                if (course_name_year[i] == course_object.course_list[j].name)
                                {
                                    for (int z = 0; z < _finished_courses.Count; z++)
                                    {
                                        if (course_object.course_list[j].code == _finished_courses[z])
                                        {
                                            goto exit; 
                                        }
                                    }
                                    for (int z = 0; z <_courses_progress.Count; z++)
                                    {
                                        if (course_object.course_list[j].code == _courses_progress[z])
                                        {
                                            goto exit;
                                        }
                                    }
                                    for (int k = 0; k < _finished_courses.Count; k++)
                                    {
                                        if (course_object.course_list[j].pre_req == "_")
                                        {
                                         
                                            crs.Add(course_name_year[i]);
                                            break;
                                        }
                                        if (course_object.course_list[j].pre_req == _finished_courses[k])
                                        {
                                            crs.Add(course_name_year[i]);
                                            break;
                                        }
                                    }
                                    break;
                                }

                            }
                        exit:;
                        }
                    }
                }
                if (_ac_year == "2")
                {

                    if (avrec.Contains("Second year:"))
                    {
                        string[] sub = avrec.Split(del).ToArray();
                        for (int i = 1; i < sub.Length; i++)
                        {
                            course_name_year.Add(sub[i]);
                        }
                        for (int i = 0; i < course_name_year.Count; i++)
                        {
                            for (int j = 0; j < course_object.course_list.Count; j++)
                            {
                                if (course_name_year[i] == course_object.course_list[j].name)
                                {
                                    for (int z = 0; z < _finished_courses.Count; z++)
                                    {
                                        if (course_object.course_list[j].code == _finished_courses[z])
                                        {
                                            goto exit;
                                        }
                                    }
                                    for (int z = 0; z < _courses_progress.Count; z++)
                                    {
                                        if (course_object.course_list[j].code == _courses_progress[z])
                                        {
                                            goto exit;
                                        }
                                    }

                                    for (int k = 0; k < _finished_courses.Count; k++)
                                    {
                                        if (course_object.course_list[j].code == _finished_courses[k])
                                        {
                                            break;
                                        }
                                        if (course_object.course_list[j].pre_req == "_")
                                        {
                                            crs.Add(course_name_year[i]);
                                            break;
                                        }
                                        if (course_object.course_list[j].pre_req == _finished_courses[k])
                                        {
                                            crs.Add(course_name_year[i]);
                                            break;
                                        }
                                    }
                                    break;
                                }
                            }
                        exit:;
                        }
                    }
                }
                avrec = av.ReadLine();
            }
            av.Close();
            return crs;
        }//check for available courses of logged in student

        public string register(string g)
        {
            string condition;
         
          
            course_object.course_list.Clear();
            course_object.read();
            for (int i = 0; i < course_object.course_list.Count; i++)
            {
                if (g == course_object.course_list[i].name)
                {
                    for (int z = 0; z < _courses_progress.Count; z++)
                    {
                        if (course_object.course_list[i].code ==_courses_progress[z])
                        {
                            condition = "You have already registered for this course !";
                            return condition;

                        }
                    }



                    for (int j = 0; j < _finished_courses.Count; j++)
                    {

                        if (course_object.course_list[i].pre_req == _finished_courses[j] || course_object.course_list[i].pre_req == "_")
                        {
                            if (course_object.course_list[i].no_of_students < course_object.course_list[i].max_st)
                            {
                                condition = "Registeration Completed !";
                                course_object.course_list[i].no_of_students++;
                                _courses_progress.Add(course_object.course_list[i].code);
                                   
                                
                               
                         
                                for (int z = 0; z < student_list.Count; z++)
                                {
                                    if (_ID == student_list[z].ID)
                                    {
                                        student_list[z].courses_progress = _courses_progress;
                                    }
                                }

                                writedata();
                                
                                course_object.Writedata();
                                return condition;
                               
                            }
                            else if (course_object.course_list[i].no_of_students >= course_object.course_list[i].max_st)
                            {
                                condition = "Maxed out !";
                               
                                return condition;
                            }
                            
                        }
                       
                    }

                }
            }

           
     
            condition = "No Courses with this name !!";
            return condition;

        }//reg. for course from available
        public void writedata()
        {
            StreamWriter writer1 = new StreamWriter("student.txt");
          
            for (int i = 0; i < student_list.Count; i++)
            {
                writer1.WriteLine("Name" + ":" + student_list[i].name);
                writer1.WriteLine("ID" + ":" + student_list[i].ID);
                writer1.WriteLine("Password" + ":" + student_list[i].pass);
                writer1.WriteLine("AcYear" + ":" + student_list[i].academic_year);
                for (int j = 0; j < student_list[i].finished_courses.Count; j++)
                {
                    if (j == 0)
                        writer1.Write("Finished" + ":" + student_list[i].finished_courses[j]);
                    else
                    {
                        writer1.Write("," + student_list[i].finished_courses[j]);
                    }
                }
                writer1.WriteLine();
                for (int k = 0; k < student_list[i].courses_progress.Count; k++)
                {
                    if (k == 0)
                        writer1.Write("progress" + ":" + student_list[i].courses_progress[k]);
                    else
                    {
                        writer1.Write("," + student_list[i].courses_progress[k]);
                       
                    }
                      
                }
                writer1.WriteLine();
                writer1.WriteLine("------------------------");
            }
            writer1.Close();
        }//write data to file
        public List<string> viewcourses()
        {
            List<string> crs = new List<string>();
            for (int j = 0; j < _courses_progress.Count; j++)
            {
                {
                    crs.Add(_courses_progress[j]);
                }
            }
            return crs;
        }//view courses in progress of students
        public void editdata(string new_name,string new_pass)
        {  
            readdata();
            string old_name;
            string old_pass;
            old_name = _name;
            old_pass = _pass;
            _name = new_name;
            _pass = new_pass;


            for (int i=0;i<student_list.Count;i++)
            {
                if(student_list[i].ID==_ID)
                {

                    string text = File.ReadAllText("student.txt");
                    text = text.Replace(old_name, _name);
                    File.WriteAllText("student.txt", text);
                    

                    string text2 = File.ReadAllText("student.txt");
                    text2 = text2.Replace(old_pass, _pass);
                    File.WriteAllText("student.txt", text2);


                }
            }

          
        }//edit data of student
    }//class
}//namespace
