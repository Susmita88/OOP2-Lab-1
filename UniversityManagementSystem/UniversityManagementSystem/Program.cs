using System;
using System.Collections;

namespace UniversityManagementSystem
{
    class Program
    {
        public int userInput()
        {
            return Convert.ToInt32(Console.ReadLine());
        }

        public Boolean addCourse(Department dept, Course course)
        {
            if (dept != null && dept.Courses != null)
            {
                dept.Courses.Add(course);
                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean addSection(Course course, Section section)
        {
            if (course != null && course.Section != null)
            {
                course.Section.Add(section);
                return true;
            }
            else
            {
                return false;
            }

        }

        public Boolean assignFaculty(Section section, Faculty faculty)
        {
            if (faculty.loadInWeek() + (section.Duration * section.NClassInWeek) > 21)
            {
                return false;
            }
            else
            {
                if (section != null && faculty.Section != null)
                {
                    section.Faculty = faculty;
                    faculty.Section.Add(section);
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        static void Main(string[] args)
        {
          
            Program p = new Program();

            Department cse = new Department();
            cse.Name = "Computer Science and Engineering";
            cse.Id = "1001";

            Department eee = new Department();
            eee.Name = "Electrical & Electronics Engineering";
            eee.Id = "1002";

            Department bba = new Department();
            bba.Name = "Bachelor of Business Administration";
            bba.Id = "1003";

            Faculty sajjad = new Faculty("Sajjad Ahmed", "1212");
            Faculty moshiur = new Faculty("Malik Moshiur", "1213");
            Faculty tanvir = new Faculty("Tanvir Ahmed", "1216");
            Faculty sayman = new Faculty("Sayman Ahmed", "1214");
            Faculty rushee = new Faculty("Rushee Ahmed", "1215");

            Section oop1A = new Section("OOP1-A", "6685", 1, 3, sajjad);
            Section oop2A = new Section("OOP2-A", "9865", 1, 3, tanvir);
            Section oop2B = new Section("OOP2-B", "9865", 1, 3, sajjad);
            Section oop2C = new Section("OOP2-C", "9865", 1, 3, tanvir);
            Section oop1B = new Section("OOP1-B", "4825", 1, 3, rushee);
            Section webtechA = new Section("Web Technology-A", "5698", 1, 3, moshiur);
            Section webtechB = new Section("Web Technology-B", "5699", 1, 3, sayman);
            Section webtechC = new Section("Web Technology-C", "5697", 1, 3, rushee);

            Course oop1 = new Course("Object Oriented Programming 1", "", new ArrayList { oop1A, oop1B });
            Course oop2 = new Course("Object Oriented Programming 2", "", new ArrayList { oop2A, oop2B, oop2C });
            Course webtech = new Course("Web Technology", "", new ArrayList { webtechA, webtechB, webtechC });

            cse.Courses = new ArrayList { oop1, oop2, webtech };

           

            Department[] departments = { cse, eee, bba };


            Console.WriteLine("University Management System");
            Console.WriteLine("===================================================\n\n");
            Console.WriteLine("Departments:\n");
            int c = 0;
            foreach (Department department in departments)
            {
                Console.Write(++c + ". ");
                Console.WriteLine(department.Name);
            }

            Console.Write("Enter Option : ");

            int opt = p.userInput();

            Department dept = departments[opt - 1];

            Console.WriteLine("\n" + dept.Name);
            Console.WriteLine("\nCourses:\n");
            dept.showCourses();

            opt = p.userInput();

            Course course = (Course)dept.Courses[opt - 1];

            course.showCourseInfo();

        }
    }
}