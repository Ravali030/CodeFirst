namespace CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Demo4 : DbMigration
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
                "dbo.Employee1",
                c => new
                    {
                        Empid = c.Int(nullable: false),
                        Ename = c.String(nullable: false, maxLength: 25),
                        Doj = c.DateTime(nullable: false),
                        AddrId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Empid)
                .ForeignKey("dbo.Address", t => t.AddrId, cascadeDelete: true)
                .Index(t => t.AddrId, unique: true, name: "AddrId");
            
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
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.StudentAddresses", "StudentAddressId", "dbo.Students");
            DropForeignKey("dbo.Employee1", "AddrId", "dbo.Address");
            DropForeignKey("dbo.Employee", "eid", "dbo.Vendor");
            DropIndex("dbo.StudentAddresses", new[] { "StudentAddressId" });
            DropIndex("dbo.Employee1", "AddrId");
            DropIndex("dbo.Employee", new[] { "eid" });
            DropTable("dbo.Students");
            DropTable("dbo.StudentAddresses");
            DropTable("dbo.Employee1");
            DropTable("dbo.Vendor");
            DropTable("dbo.Employee");
            DropTable("dbo.Address");
        }
    }
}
