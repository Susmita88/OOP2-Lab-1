using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Task_3
{
    class Student
    {
        string name;
        string id;
        string department;
        double cgpa;

        public string getName()
        {
            return name; 
        }
        public void setName(String Name)
        {
            name = Name;
        }
        public string getId()
        {
            return id;
        }
        public void setId(String Id)
        {
            id = Id;
        }
        public string getDepartment()
        {
            return department;
        }
        public void setDepartment(String Department)
        {
            department = Department;
        }
        public double getCGPA()
        {
            return cgpa;
        }
        public void setCGPA(double CGPA)
        {
            cgpa = CGPA;
        }
        public void ShowInfo()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Id: " + id);
            Console.WriteLine("Department: " + department);
            Console.WriteLine("CGPA: " + cgpa);

        }
    }
}
