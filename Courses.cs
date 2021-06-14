using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_management
{
    class Courses
    {
        public string name;
        public string code;
        public int max_st;
        public int no_of_students;
        public string pre_req;
        public string hours;
        string x = "";
        int a = 0;
        public List<Courses> course_list = new List<Courses>();
        public static Courses single_course = new Courses();
        public void read()
        {
            StreamReader reader2 = new StreamReader("Courses data.txt");
            string record;
            char[] dels = { ':', ',', '\t' };
            record = reader2.ReadLine();
            while (record != null)
            {
                if (record.Contains("Name"))
                {
                    string[] substring1 = record.Split(dels).ToArray();
                    for (int i = 1; i < substring1.Length; i++)
                    {
                        single_course.name = substring1[i].ToString();
                    }
                }

                /*------------------------------------------------------*/

                else if (record.Contains("Code"))
                {
                    string[] substring1 = record.Split(dels).ToArray();

                    for (int i = 1; i < substring1.Length; i++)
                    {
                        single_course.code = substring1[i].ToString();
                    }

                }

                /*------------------------------------------------------*/

                else if (record.Contains("Maxstudents"))
                {
                    string[] substring1 = record.Split(dels).ToArray();

                    for (int i = 1; i < substring1.Length; i++)
                    {
                        single_course.max_st = Convert.ToInt32(substring1[i]);
                    }
                }

                /*------------------------------------------------------*/


                else if (record.Contains("Prereq"))
                {
                    string[] substring1 = record.Split(dels).ToArray();

                    for (int i = 1; i < substring1.Length; i++)
                    {
                        single_course.pre_req = substring1[i];
                    }
                }

                /*------------------------------------------------------*/

                else if (record.Contains("Hours"))
                {
                    string[] substring1 = record.Split(dels).ToArray();
                    for (int i = 1; i < substring1.Length; i++)
                    {
                        single_course.hours = substring1[i];
                    }
                }
                /*------------------------------------------------------*/

                else if (record.Contains("Students"))
                {
                    string[] substring1 = record.Split(dels).ToArray();

                    for (int i = 1; i < substring1.Length; i++)
                    {
                        single_course.no_of_students = Convert.ToInt32(substring1[i]);
                    }
                }


                /*------------------------------------------------------*/


                else if (record.Contains("---------------"))
                {
                    course_list.Add(single_course);
                    single_course = new Courses();

                }
                record = reader2.ReadLine();
            }
            reader2.Close();
        }
        public List<string> details(string y)
        {
            read();
            List<string> crs = new List<string>();

            for (int i = 0; i < course_list.Count; i++)
            {
                if (course_list[i].name == y)
                {

                    crs.Add(course_list[i].name);
                    crs.Add(course_list[i].code);
                    crs.Add(course_list[i].max_st.ToString());
                    if (course_list[i].pre_req == "_")
                    {
                        crs.Add(course_list[i].pre_req);
                    }
                    else
                    {
                        pre_temp(course_list[i].pre_req);
                        crs.Add(x);
                    }
                    crs.Add(course_list[i].no_of_students.ToString());
                    crs.Add(course_list[i].hours);
                }
            }
            x = "";

            return crs;
        }
        public string pre_temp(string _code)
        {
            //read();
            //List<string> x = new List<string>();
            for (int k = 0; k < course_list.Count; k++)
            {

                if (_code == course_list[k].code)
                {
                    if (course_list[k].pre_req == "_")
                    {
                        return x += course_list[k].name;
                    }
                    else
                    {
                        a = k;

                    }
                }

            }
            return x += course_list[a].name + " " + pre_temp(course_list[a].pre_req);


        }
        public void Writedata()
        {
            

            StreamWriter writer1 = new StreamWriter("Courses data.txt");
            
            writer1.WriteLine("First year:Intro,Biology,Physics,MathI,EnglishI,Humanities,SP,Biochemistry,Electronics,MathII,EnglishII,RW");
            writer1.WriteLine("Second year:Cellbiology,DS,MathIII,Biophysics,Probability,OR,Genetics,OOP,MathIIII,FO,BusinessOrganization,Logic");
            for (int i = 0; i < course_list.Count; i++)
            {
                writer1.WriteLine("Name" + ":" + course_list[i].name);
                writer1.WriteLine("Code" + ":" + course_list[i].code);
                writer1.WriteLine("Maxstudents" + ":" + course_list[i].max_st);
                writer1.WriteLine("Prereq" + ":" + course_list[i].pre_req);
                writer1.WriteLine("Students" + ":" + course_list[i].no_of_students);
                writer1.WriteLine("Hours" + ":" + course_list[i].hours);
                writer1.WriteLine("----------------------------");
            }
            writer1.Close();

        }
    }//class
}//namespace
