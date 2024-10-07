using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAdministrator
{
    public class Instructor: User
    {
        string teacherId;

        public Instructor(int id, string email, Usertype type, string teacherId) : base(id, email, type)
        {
            this.teacherId = teacherId;
        }

        public string getInstructorId()
        {
            return this.teacherId;
        }

        public string getInstructorEmail()
        {
            return this.email;
        }
    }
}
