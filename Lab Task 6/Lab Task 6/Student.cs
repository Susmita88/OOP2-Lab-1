﻿using System;
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
        private double cgpa;
        private Book[] borrowedBook;
        private int borrowedBookCount;

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
        public Book[] BorrowedBook
        {
            get { return borrowedBook; }
            set { borrowedBook = value; borrowedBookCount = borrowedBook.Length; }
        }

        public int BorrowedBookCount
        {
            get { return borrowedBookCount; }
            set { borrowedBookCount = value; }
        }
        public Student()
        {
            Console.WriteLine("Empty Constructor");

        }
        public void ShowInfo()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Id: " + id);
            Console.WriteLine("Department: " + department);
            Console.WriteLine("CGPA: " + cgpa);
        }
        public void ShowBorrowedBookInfo()
        {
            for (int i = 0; i < borrowedBookCount; i++)
            {
                borrowedBook[i].ShowInfo();
            }
        }
    }
}
