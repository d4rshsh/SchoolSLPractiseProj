using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSLPractiseProj
{
    public class Student
    {

        public int StudId { get; set; }
        public string StudName { get; set; }

        public string Sub { get; set; }
    }
    public class Subjects
    {
        public int Subid { get; set; }
        public string Subname { get; set; }
    }
    public class Teachers
    {
        public int Tid
        {
            get;
            set;
        }
        public string Tname
        {
            get;
            set;
        }
        public string Subname
        {
            get;
            set;
        }
    }
}
