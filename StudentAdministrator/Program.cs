using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAdministrator
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Period periodEnglish = new Period(new DateTime(2024, 10, 4, 14, 30, 0), new DateTime(2024, 11, 4, 14, 30, 0));
                Course english = new Course("12345", periodEnglish);
                english.addInstructor(new Instructor(1, "abc@gmail.com", User.Usertype.Instructor, "TC12345"));

                english.addStudent(new Student(2, "def@gmail.com", User.Usertype.Student, "ST12345"));
                english.addStudent(new Student(3, "fjf@gmail.com", User.Usertype.Student, "ST167"));
                english.addStudent(new Student(4, "fnf@gmail.com", User.Usertype.Student, "ST127889"));
                english.addStudent(new Student(5, "quatro@gmail.com", User.Usertype.Student, "ST19998"));
                



                Console.WriteLine(english);

                
               

                english.removeStudent(new Student(2, "def@gmail.com", User.Usertype.Student, "ST12345"));
                Console.WriteLine(english);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            
            Console.ReadLine();
        }
    }
}
