using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.Relation
{
 
    public class StudentAddress
    {
        public int StudentAddressId {  get; set; }
        public string Hno {  get; set; }
        public string Area { get; set; }
        public virtual Student student { get; set; }

    }
}
