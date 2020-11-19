using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Task_6
{
    class Student
    {
       
       private string name;
       private string id;
       private string department;
       private float cgpa;

        public string getName()
        {
            return name;
        }
        public void setName(string Name)
        {
            name = Name;
        }

        public string getId()
        {
            return id;
        }
        public void setId(string Id)
        {
            id = Id;
        }

        public string getDepartment()
        {
            return department;
        }
        public void setDepartment(string Department)
        {
            department = Department;
        }
        public float getCGPA()
        {
            return cgpa;
        }
        public void setCGPA(float CGPA)
        {
            cgpa = CGPA;
        }
        public Student()
        {
            Console.WriteLine("Empty Constructor");

        }
        public Student(string name, string id, string department, float cgpa)
        {
            this.name = name;
            this.id = id;
            this.department = department;
            this.cgpa = cgpa;
            
        }
       
            void ShowInfo()
            {
                Console.WriteLine("Name: " + name);
                Console.WriteLine("Id: " + id);
                Console.WriteLine("Department: " + department);
                Console.WriteLine("CGPA: " + cgpa);
            }
    }
}
