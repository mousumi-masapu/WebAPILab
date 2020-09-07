using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonAPISerialization
{
    
    class Student
    {

        public int RollNo { get; set; }
        public string Name { get; set; }

        public string Grade { get; set; }
        public List<string> Subjects { get; set; }


    }

}
