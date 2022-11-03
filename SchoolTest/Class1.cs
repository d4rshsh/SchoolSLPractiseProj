using NUnit.Framework;
using SchoolSLPractiseProj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolTest
{
    [TestFixture]
    public class TestMethods
    {
        List<Student> students = null;
        public TestMethods()
        {
            students = new List<Student>();
        }
        [TestCase]
        public void Addstudent()
        {

            Student student = new Student();
            student.StudId = 1;
            student.StudName = "Darsh";
            student.Sub = "Physics";

            bool k = true;
            //if ((student.Sub is null) || (student.StudName is null) || student.StudId == null)
                if ((student.Sub is null) || (student.StudName is null))
                {
                k = false;
            }
            else
            {
                students.Add(student);
            }
            Assert.IsTrue(k);
        }
        [TestCase]
        public void StudentList()
        {
            bool k1 = true;
            if (students.Count <= 0)
            {
                k1 = false;
            }
            Assert.IsTrue(k1);
        }
        [TestCase("Darshan", ExpectedResult = true)]
        [TestCase("Darsh", ExpectedResult = false)]
        public bool findname(string ans)
        {
            bool k = false;
            foreach (var item in students)
            {
                if (item.StudName == ans)
                {
                    k = true;
                }
            }
            return k;
        }
    }
    [TestFixture]
    public class SubtestMethods
    {
        List<Teachers> teach = null;
        public SubtestMethods()
        {
            teach = new List<Teachers>();
        }
        [TestCase]
        public void AddTeacher()
        {

            Teachers t = new Teachers();
            t.Tid = 1;
            t.Tname = "Sonia";
            t.Subname = "Hindi";

            bool k = true;
           // if ((t.Tname is null) || (t.Subname is null) || t.Tid == null)
                if ((t.Tname is null) || (t.Subname is null))
                {
                k = false;
            }
            else
            {
                teach.Add(t);
            }
            Assert.IsTrue(k);
        }
        [TestCase]
        public void TeachersList()
        {
            bool k1 = true;
            if (teach.Count <= 0)
            {
                k1 = false;
            }
            Assert.IsTrue(k1);
        }
        [TestCase("Sonia", ExpectedResult = true)]
        [TestCase("Darshan", ExpectedResult = false)]
        public bool findname(string ans)
        {
            bool k = false;
            foreach (var item in teach)
            {
                if (item.Tname == ans)
                {
                    k = true;
                }
            }
            return k;
        }
    }
    [TestFixture]
    public class SubjTestMethods
    {
        List<Subjects> sub = null;
        public SubjTestMethods()
        {
            sub = new List<Subjects>();
        }
        [TestCase]
        public void Addstudent()
        {

            Subjects sb = new Subjects();
            sb.Subid = 1;
            sb.Subname = "Science";

            bool k = true;
           // if ((sb.Subname is null) || sb.Subid == null)
                if ((sb.Subname is null) )
                {
                k = false;
            }
            else
            {
                sub.Add(sb);
            }
            Assert.IsTrue(k);
        }
        [TestCase]
        public void StudentList()
        {
            bool k1 = true;
            if (sub.Count <= 0)
            {
                k1 = false;
            }
            Assert.IsTrue(k1);
        }
        [TestCase("English", ExpectedResult = true)]
        [TestCase("Science", ExpectedResult = false)]
        public bool findname(string ans)
        {
            bool k = false;
            foreach (var item in sub)
            {
                if (item.Subname == ans)
                {
                    k = true;
                }
            }
            return k;
        }
    }
}
