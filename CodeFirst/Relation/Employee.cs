using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.Relation
{
    [Table("Employee")]
    public class Employee
    {
        [Key]
        public int eid {  get; set; }
        public string name { get; set; }
        
        public Vendor Vendors { get; set; }
    }
}
