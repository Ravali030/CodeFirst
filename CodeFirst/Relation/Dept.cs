using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.Relation
{
    [Table("Dept")]
    public class Dept
    {
        [Key]
        public int Did {  get; set; } 
        public string name {  get; set; }
        public virtual ICollection<Employ> Employs { get; set; }//If use collections,In databse there no extra emp_Dept table

    }
}
