using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoApplication
{
    internal class Student
    {

        private int studentid;
        private string lastname;
        private string firstname;

        public int StudentID
        {
            get { return studentid; }
            set { studentid = value; }
        }
        
        public string Lastname
        {
            get { return lastname; }
            set { lastname = value; }
        }

        public string Firstname
        {
            get { return firstname; }
            set { firstname = value; }
        }
    }
}
