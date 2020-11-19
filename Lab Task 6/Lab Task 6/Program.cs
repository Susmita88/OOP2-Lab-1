using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Task_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            Student s1 = new Student();
            s1.setName("Susmita Chowdhury Barua");
            s1.setId("18-38541-2");
            s1.setDepartment("CSE");
            s1.setCGPA(3.5);
            s1.ShowInfo();
            Console.WriteLine();

            Student s2 = new Student();
            s2.setName("Afrin Khan");
            s2.setId("18-36653-1");
            s2.setDepartment("EEE");
            s2.setCGPA(3.0);
            s2.ShowInfo();

            Student s3 = new Student();
            s3.setName("Akib Hasan");
            s3.setId("18-32651-1");
            s3.setDepartment("BBA");
            s3.setCGPA(3.3);
            s3.ShowInfo();

            

            Book b1 = new Book("book1Name", "book1Author", "5343", "Advantures", 6);
            Book b2 = new Book("book2Name", "book2Author", "3535", "Horror", 4);
            Book b3 = new Book("book3Name", "book3Author", "2655", "Commedy", 6);
            Book b4 = new Book("book4Name", "book4Author", "4587", "Scientific", 6);
            Book b5 = new Book("book5Name", "book5Author", "9842", "Romantic", 5);
            Book b6 = new Book("book6Name", "book6Author", "6543", "Commedy", 4);


            s1.BorrowedBook = new Book[] { b1, b2 };
            s2.BorrowedBook = new Book[] { b3, b4, b5 };
            s3.BorrowedBook = new Book[] { b2, b6 };
            //s1.BorrowedBookCount = borrowedBook.Length;

            //s1.showBorrowedBookInfo();

            Library library = new Library("BookHouse", "Kuratoli", new Book[] { b1, b2, b3, b4, b5, b6 }, 6);

            library.showAllBooks();
        }
    }
}
