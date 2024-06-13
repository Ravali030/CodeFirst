using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.Relation
{
    [Table("Employ1")]
    public class Employ1
    {
        [Key]
        public int EmployId {  get; set; }
        public string EmployName { get; set; }
        //public virtual ICollection<Dept1> Dept1s {  get; set; }
    }
}
