using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;


namespace CodeFirst.Relation
{
    public class VendorDbcontext:DbContext
    {
        public VendorDbcontext() : base("VendorEntities") 
        { 
           Database.SetInitializer(new MigrateDatabaseToLatestVersion<VendorDbcontext,CodeFirst.Migrations.Configuration>("Vendorentities"));
        }
        
        public virtual DbSet<Vendor> Vendors { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Employee1> Employees1s { get; set; }
        public virtual DbSet<Address> Addresses { get; set; } 
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<StudentAddress> StudentAddresses { get; set; } 
        public virtual DbSet<Leave> Leaves { get; set; }
        public virtual DbSet<Department> Departments { get; set; }

        public virtual DbSet<Employ> Employs { get; set; }
        public virtual DbSet<Dept> Depts { get; set; }
        public virtual DbSet<Employ1> Employ1s { get; set; }
        public virtual DbSet<Dept1> Dept1s { get; set; }

        public virtual DbSet<Emp_Dept> Emp_Depts { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasOptional(r => r.studentAddress).WithRequired(r1 => r1.student);
            modelBuilder.Entity<Vendor>().HasOptional(s => s.Employee).WithRequired(s1 => s1.Vendors);
            base.OnModelCreating(modelBuilder);
        }
       
    }

}
