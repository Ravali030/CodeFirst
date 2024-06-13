using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.Relation
{
    [Table("Employee1")]
    public class Employee1
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Empid {  get; set; }
        [Required]
        [StringLength(25)]
        public String Ename {  get; set; }
        public DateTime Doj { get; set; }
        [ForeignKey("address")]
        [Index("AddrId", IsUnique = true)]
        public int AddrId { get; set; }
        public  virtual Address address { get; set; }
        //[ForeignKey("department")]//may or may not use foreign key when we use iCollection 
        //public int? DeptId {get; set; }//for adding new field -->This field also Optional
        public virtual Department department { get; set; }

       
    }
}
