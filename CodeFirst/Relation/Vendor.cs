using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.Relation
{
    [Table("Vendor")]
    public class Vendor
    {
        [Key]
        public int vid {  get; set; }
        [StringLength(50)]
        public string vname { get; set; }
        public DateTime DoReg { get; set; }
        [StringLength(50)]  
        public string city { get; set; }
        [StringLength(50)]
        public string country { get; set; }
        [ForeignKey("Employee")]
        
        public int eid {  get; set; }
        public virtual Employee Employee { get; set; }

    }
}
