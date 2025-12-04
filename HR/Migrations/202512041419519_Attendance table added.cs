namespace HR.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Attendancetableadded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Attendances",
                c => new
                    {
                        AttendanceID = c.Int(nullable: false, identity: true),
                        EmployeeID = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.AttendanceID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Attendances");
        }
    }
}
