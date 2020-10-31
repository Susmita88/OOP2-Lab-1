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
        float cgpa;

        public void insert(string Name, string Id, string Department, float cgpa)
        {
            name = Name;
            id = Id;
            department = Department;
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
