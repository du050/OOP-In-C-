using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAdministrator
{
    public class Student: User
    {
		string studentId;

        public Student(int id, string email, Usertype type, string studentId) : base(id, email, type)
        {
            this.studentId = studentId;
        }

        
    }
}
