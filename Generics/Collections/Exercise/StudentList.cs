using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.Collections.Exercise
{
    //StudentList is a class represented by a List of students.

    public class StudentList
    {

        //Targil 1 - write the Property of StudentList called Students
        #region Properties
        List<Student> Students { get; set; }
        #endregion

        //Targil 2 - Write a constructor which initiates the students and calls for Student.FillList()
        #region Constructor
        public StudentList()
        {
            Students = new List<Student>();
            var list = Student.FillList();
            foreach(var item in list)
                Students.Add(item);
        }
        #endregion

        //Targil 3- Create a dictionary where the key is the name of the Student and the value is the Student object
        #region Work with Dictionary
        public Dictionary<string, Student> CreateDictionaryFromStudentList()
        {
            Dictionary<string, Student> x = new Dictionary<string, Student>();
            for (int i = 0; i < Students.Count; i++)
            {
                x.Add(Students[i].Name, Students[i]);
            }
            return x;
           
        }

        //Targil 4- write a method which retrieves a Student By name. Use the Dictionary created in Targil 3
        public Student FindStudentByName(string name)
        {
            Student s = CreateDictionaryFromStudentList()[name];
            return s;

        }
        #endregion

        #region retrieving a list
        //Targil 5-  write a method which retrieves a list of Students By Kita
        public List<Student> GetStudentsByKitas(string kita)
        {
            List<Student> l = new List<Student>();
            for (int i = 0; i < Students.Count; i++)
            {
                if (Students[i].Kita.ToString() == kita)
                {
                    l.Add(Students[i]);
                }
            }
            return l;
            
        }
        #endregion



    }
}
