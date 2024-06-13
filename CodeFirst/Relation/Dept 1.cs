using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.Relation
{
    [Table("Dept1")]
    public class Dept1//our many to many relation table of employ1 and dept1
    {
        [Key]
        public int Did {  get; set; } 
        public string name {  get; set; }
       // public virtual ICollection<Employ1> Employ1s { get; set; }

    }
}
