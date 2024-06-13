using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.Relation
{
    [Table("Department")]
    public class Department
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DeptId {  get; set; }
        [StringLength(25)]
        public string Dname {  get; set; }

        public virtual ICollection<Employee1> Employee1s { get; set; }//vevery dept will have multiple employees
    }
}
