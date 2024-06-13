using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.Relation
{
    //using API (without annotations)
    public class Student
    {
        public int StudentId { get; set; }
        public string SName { get; set; }

        public StudentAddress studentAddress { get; set; }
    }
}
