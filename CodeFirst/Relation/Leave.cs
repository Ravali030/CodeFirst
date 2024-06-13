using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.Relation
{
    [Table("Leave")]
    public class Leave
    {
        [Key]
        [ForeignKey("Employee1")]
        public int Empid { get; set; }
        public int Cl { get; set; }
        public int El { get; set; }

        public virtual Employee1 Employee1 { get; set; }
    }
}
