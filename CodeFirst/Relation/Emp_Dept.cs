using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.Relation
{
    [Table("Emp_Dept")]
    public class Emp_Dept
    {
        [Key,Column(Order =1)]
        public int EmployId {  get; set; }
        [Key,Column(Order =2)]
        public int Did { get; set; }

        public virtual Employ1 Employ1 { get; set; }
        public virtual Dept1 Dept1 { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }


    }
}
