using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.setName("Susmita Chowdhury Barua");
            s1.setId("18-38541-2");
            s1.setDepartment("CSE");
            s1.setCGPA(3.5);
            s1.ShowInfo();
            Console.WriteLine();

            Triangle t1 = new Triangle();
            t1.setX(6);
            t1.setY(3);
            t1.setZ(6);
            t1.TestTriangle();

            Course c1 = new Course();
            c1.setCourseName("OOP2");
            c1.setCourseCode("1145");
            c1.setCourseCredit(3);

            Account a1 = new Account();
            a1.setAccName("Susmita Chowdhury Barua");
            a1.setAccId("832");
            a1.setBalance(10000);
            a1.Deposit(2000);
            Console.WriteLine(a1.getBalance());
            a1.withdraw(0);
            Console.WriteLine(a1.getBalance());
        }
    }
}
