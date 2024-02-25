using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student
{
    internal class Student
    {
        public string name;
        public int rollNumber;
        public float cgpa;
        public int matricMarks;
        public int ecatMarks;
        public int fscMarks;
        public string homeTown;
        public bool isHostellite;
        public bool isTakingScholarship;

        public Student()
        {
            matricMarks = 1100;
            ecatMarks = 300;
            fscMarks = 1001;
        }

        public float calculateMerit()
        {
            return ((fscMarks * 0.05f) + (ecatMarks * 0.1f));
        }

        public bool isHostelite()
        {
            if(calculateMerit() > 80)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
       
    }


}
