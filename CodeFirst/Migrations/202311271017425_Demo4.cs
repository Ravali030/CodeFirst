namespace CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Demo4 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Department",
                c => new
                    {
                        DeptId = c.Int(nullable: false, identity: true),
                        Dname = c.String(maxLength: 25),
                    })
                .PrimaryKey(t => t.DeptId);
            
            AddColumn("dbo.Employee1", "DeptId", c => c.Int(nullable: false));
            CreateIndex("dbo.Employee1", "DeptId");
            AddForeignKey("dbo.Employee1", "DeptId", "dbo.Department", "DeptId", cascadeDelete: true); 
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employee1", "DeptId", "dbo.Department");
            DropIndex("dbo.Employee1", new[] { "DeptId" });
            DropColumn("dbo.Employee1", "DeptId");
            DropTable("dbo.Department");
        }
    }
}
