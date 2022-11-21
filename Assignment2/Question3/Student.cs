using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question3
{
    class Student
    {
        int stu_id;
        string stu_dept;
        string stu_name;
        int stu_semester;
        public override string ToString()
        {
            return stu_id + " " + stu_name + " " +
                stu_dept + " " + stu_semester;
        }
        static void Main(string[] args)
        {
            List<Student> stu = new List<Student>()
            {
                new Student{ stu_id = 01, stu_name = "Shivam",
                    stu_dept = "CS", stu_semester = 2 },
                new Student{ stu_id = 02, stu_name = "Shubham",
                    stu_dept = "IT", stu_semester = 3 },
                new Student{ stu_id = 03, stu_name = "Deepak",
                    stu_dept = "Diploma", stu_semester = 4},
            };
            IEnumerable<Student> Query = from student in stu select student;
            Console.WriteLine("ID Name Department Semester");
            Console.WriteLine("+++++++++++++++++++++++++++");
            foreach (Student e in Query)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}

