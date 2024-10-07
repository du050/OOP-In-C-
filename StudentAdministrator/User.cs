using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAdministrator
{
    public class User
    {
        public int id;
        public string email;
        public Usertype type;

        public User(int id, string email, Usertype type)
        {
            this.id = id;
            this.email = email;
            this.type = type;
        }

        // Define the enum outside of the constructor
        public enum Usertype
        {
            Student,
            Instructor
        }

        public string getEmail()
        {
            return email;
        }
    }
}
