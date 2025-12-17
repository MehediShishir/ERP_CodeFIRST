namespace HR.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDepartmentAndDesignationToEmployee : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "DepartmentID", c => c.Int(nullable: false));
            AddColumn("dbo.Employees", "DesignationID", c => c.Int(nullable: false));
            CreateIndex("dbo.Employees", "DepartmentID");
            CreateIndex("dbo.Employees", "DesignationID");
            AddForeignKey("dbo.Employees", "DepartmentID", "dbo.Departments", "DepartmentID", cascadeDelete: true);
            AddForeignKey("dbo.Employees", "DesignationID", "dbo.Designations", "DesignationID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employees", "DesignationID", "dbo.Designations");
            DropForeignKey("dbo.Employees", "DepartmentID", "dbo.Departments");
            DropIndex("dbo.Employees", new[] { "DesignationID" });
            DropIndex("dbo.Employees", new[] { "DepartmentID" });
            DropColumn("dbo.Employees", "DesignationID");
            DropColumn("dbo.Employees", "DepartmentID");
        }
    }
}
