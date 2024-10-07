using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAdministrator
{
    public class Course
    {
        string courseId;
        Instructor instructor;
        Period period;
        int CAPACITY = 5;
        List<Student> students = new List<Student>();

        public Course(string courseId, Period period)
        {
            this.courseId = courseId;
            this.period = period;
            
            
        }
        public Course(string courseId, Instructor instructor, Period period)
        {
            this.courseId = courseId;
            this.instructor = instructor;
            this.period = period;

        }
        
        //Curso -> Limite de alunos, 1 professor apenas, nao permitir adicionar aluno acima do limite, caso curso nao tenha iniciado


        public void addInstructor(Instructor instructor)
        {
            this.instructor = instructor;
        }

        public void addStudent(Student student) 
        {
            try
            {
                if (studentIsEligible(student))
                {
                  this.students.Add(student);
                }
                
            }
            catch (Exception ex) {
                throw ex;
            }   
        }

        public bool studentIsEligible(Student student)
        {
            if(!hasRoom())
            {
                throw new Exception($"ERROR: Course does not have room");
            }else if(existsOnList(student))
            {
                throw new Exception($"ERROR: Student already exists on the list");
            } else if(hasStarted())
            {
                throw new Exception($"ERROR: Course has already started");
            }
            return true;
        }

        public bool hasStarted()
        {
            if(period.getStartDate()>= DateTime.Now)
            {
                return true;
            }
            return false;
        }

        public bool existsOnList(Student student)
        { 
            Student found = FindStudentbyEmail(student.getEmail());
            if (found != null)
            {
                return true;
            }
            return false;
        }

        private Student FindStudentbyEmail(string email)
        {
            return this.students.Find(el => el.getEmail().Equals(email));
        }

        public void removeStudent(Student student) 
        { 
            
            if(!existsOnList(student))
            {
                throw new Exception("ERROR: Student is not on the list");
            }
            Student found = FindStudentbyEmail(student.getEmail());
            this.students.Remove(found);
        }

        public bool hasRoom()
        {
            //quantidade de aluno < capacidade
            if(this.students.Count >= CAPACITY)
            {
                return false;
            }
            return true;
        }

        public void setPeriod(Period period)
        {
            this.period = period;
        }

       

        public override string ToString()
        {
            string studentList = "";

            // Iterate over the student list and append their email to the studentList string
            foreach (var student in students)
            {
                studentList += $"- {student.email}\n";
            }

            return $"Course id: {courseId}, Period: {period.ToString()}, Instructor: {instructor.getInstructorEmail()}\nStudents:\n{studentList}";
        }
    }
}
