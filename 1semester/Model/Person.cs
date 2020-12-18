using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1semester.Model
{
    abstract class Person
    {
        private string fname;
        private string lname;

        public string FullName
        {
            get { return fname + " " + lname; }
        }

        public string Fname
        {
            get { return fname; }
            set { fname = value; }
        }

        public string Lname
        {
            get { return lname; }
            set { lname = value; }
        }

    }
}
