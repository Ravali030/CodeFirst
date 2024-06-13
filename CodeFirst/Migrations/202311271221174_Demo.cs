namespace CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Demo : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Address",
                c => new
                    {
                        AddrId = c.Int(nullable: false),
                        Hno = c.String(),
                        Area = c.String(),
                    })
                .PrimaryKey(t => t.AddrId);
            
            CreateTable(
                "dbo.Department",
                c => new
                    {
                        DeptId = c.Int(nullable: false),
                        Dname = c.String(maxLength: 25),
                    })
                .PrimaryKey(t => t.DeptId);
            
            CreateTable(
                "dbo.Employee1",
                c => new
                    {
                        Empid = c.Int(nullable: false),
                        Ename = c.String(nullable: false, maxLength: 25),
                        Doj = c.DateTime(nullable: false),
                        AddrId = c.Int(nullable: false),
                        department_DeptId = c.Int(),
                    })
                .PrimaryKey(t => t.Empid)
                .ForeignKey("dbo.Address", t => t.AddrId, cascadeDelete: true)
                .ForeignKey("dbo.Department", t => t.department_DeptId)
                .Index(t => t.AddrId, unique: true, name: "AddrId")
                .Index(t => t.department_DeptId);
            
            CreateTable(
                "dbo.Dept1",
                c => new
                    {
                        Did = c.Int(nullable: false, identity: true),
                        name = c.String(),
                    })
                .PrimaryKey(t => t.Did);
            
            CreateTable(
                "dbo.Dept",
                c => new
                    {
                        Did = c.Int(nullable: false, identity: true),
                        name = c.String(),
                    })
                .PrimaryKey(t => t.Did);
            
            CreateTable(
                "dbo.Employ",
                c => new
                    {
                        EmployId = c.Int(nullable: false, identity: true),
                        EmployName = c.String(),
                    })
                .PrimaryKey(t => t.EmployId);
            
            CreateTable(
                "dbo.Emp_Dept",
                c => new
                    {
                        EmployId = c.Int(nullable: false),
                        Did = c.Int(nullable: false),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(),
                    })
                .PrimaryKey(t => new { t.EmployId, t.Did })
                .ForeignKey("dbo.Dept1", t => t.Did, cascadeDelete: true)
                .ForeignKey("dbo.Employ1", t => t.EmployId, cascadeDelete: true)
                .Index(t => t.EmployId)
                .Index(t => t.Did);
            
            CreateTable(
                "dbo.Employ1",
                c => new
                    {
                        EmployId = c.Int(nullable: false, identity: true),
                        EmployName = c.String(),
                    })
                .PrimaryKey(t => t.EmployId);
            
            CreateTable(
                "dbo.Employee",
                c => new
                    {
                        eid = c.Int(nullable: false),
                        name = c.String(),
                    })
                .PrimaryKey(t => t.eid)
                .ForeignKey("dbo.Vendor", t => t.eid)
                .Index(t => t.eid);
            
            CreateTable(
                "dbo.Vendor",
                c => new
                    {
                        vid = c.Int(nullable: false, identity: true),
                        vname = c.String(maxLength: 50),
                        DoReg = c.DateTime(nullable: false),
                        city = c.String(maxLength: 50),
                        country = c.String(maxLength: 50),
                        eid = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.vid);
            
            CreateTable(
                "dbo.Leave",
                c => new
                    {
                        Empid = c.Int(nullable: false),
                        Cl = c.Int(nullable: false),
                        El = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Empid)
                .ForeignKey("dbo.Employee1", t => t.Empid)
                .Index(t => t.Empid);
            
            CreateTable(
                "dbo.StudentAddresses",
                c => new
                    {
                        StudentAddressId = c.Int(nullable: false),
                        Hno = c.String(),
                        Area = c.String(),
                    })
                .PrimaryKey(t => t.StudentAddressId)
                .ForeignKey("dbo.Students", t => t.StudentAddressId)
                .Index(t => t.StudentAddressId);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        StudentId = c.Int(nullable: false, identity: true),
                        SName = c.String(),
                    })
                .PrimaryKey(t => t.StudentId);
            
            CreateTable(
                "dbo.EmployDepts",
                c => new
                    {
                        Employ_EmployId = c.Int(nullable: false),
                        Dept_Did = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Employ_EmployId, t.Dept_Did })
                .ForeignKey("dbo.Employ", t => t.Employ_EmployId, cascadeDelete: true)
                .ForeignKey("dbo.Dept", t => t.Dept_Did, cascadeDelete: true)
                .Index(t => t.Employ_EmployId)
                .Index(t => t.Dept_Did);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.StudentAddresses", "StudentAddressId", "dbo.Students");
            DropForeignKey("dbo.Leave", "Empid", "dbo.Employee1");
            DropForeignKey("dbo.Employee", "eid", "dbo.Vendor");
            DropForeignKey("dbo.Emp_Dept", "EmployId", "dbo.Employ1");
            DropForeignKey("dbo.Emp_Dept", "Did", "dbo.Dept1");
            DropForeignKey("dbo.EmployDepts", "Dept_Did", "dbo.Dept");
            DropForeignKey("dbo.EmployDepts", "Employ_EmployId", "dbo.Employ");
            DropForeignKey("dbo.Employee1", "department_DeptId", "dbo.Department");
            DropForeignKey("dbo.Employee1", "AddrId", "dbo.Address");
            DropIndex("dbo.EmployDepts", new[] { "Dept_Did" });
            DropIndex("dbo.EmployDepts", new[] { "Employ_EmployId" });
            DropIndex("dbo.StudentAddresses", new[] { "StudentAddressId" });
            DropIndex("dbo.Leave", new[] { "Empid" });
            DropIndex("dbo.Employee", new[] { "eid" });
            DropIndex("dbo.Emp_Dept", new[] { "Did" });
            DropIndex("dbo.Emp_Dept", new[] { "EmployId" });
            DropIndex("dbo.Employee1", new[] { "department_DeptId" });
            DropIndex("dbo.Employee1", "AddrId");
            DropTable("dbo.EmployDepts");
            DropTable("dbo.Students");
            DropTable("dbo.StudentAddresses");
            DropTable("dbo.Leave");
            DropTable("dbo.Vendor");
            DropTable("dbo.Employee");
            DropTable("dbo.Employ1");
            DropTable("dbo.Emp_Dept");
            DropTable("dbo.Employ");
            DropTable("dbo.Dept");
            DropTable("dbo.Dept1");
            DropTable("dbo.Employee1");
            DropTable("dbo.Department");
            DropTable("dbo.Address");
        }
    }
}
