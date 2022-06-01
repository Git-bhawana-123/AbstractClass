using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    class Student
    {
        int id;
        string name;
        double marks;



        public Student() //Default Constructor
        {



        }
        public Student(int id, string name, double marks)
        {
            this.id = id;
            this.name = name;
            this.marks = marks;
        }
        public void AddStudent(int id, string name, double marks)
        {
            this.id = id;
            this.name = name;
            this.marks = marks;



        }
        public void RemoveStudent()
        {
            this.id = 0;
            this.name = null;
            this.marks = 0;

        }
        public void UpdateStudent(int id, string name, double marks)
        {
            this.id = id;
            this.name = name;
            this.marks = marks;
        }
        public void DisplayAllStudents()
        {
            Console.WriteLine("Id: " + this.id + " Name: " + this.name + " Marks: " + this.marks);
        }



    }
    internal class InterfaceAssignment
    {
        static void Main()
        {
            


            Student[] student = new Student[3];



            student[0] = new Student(66469, "Bhawana", 87.4);
            student[1] = new Student();



            student[1].AddStudent(66489, "krutika", 91);



            student[1].RemoveStudent();



            student[1].UpdateStudent(5332, "sresh", 78);



            student[2] = new Student();
            student[2].AddStudent(4533, "david", 89);







            for (int i = 0; i < 3; i++)
            {
                student[i].DisplayAllStudents();
            }
        }
    }



}



    
