namespace HR.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeinleaveApplication : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.LeaveApplications", "LeaveTypeID", c => c.Int(nullable: false));
            CreateIndex("dbo.LeaveApplications", "LeaveTypeID");
            AddForeignKey("dbo.LeaveApplications", "LeaveTypeID", "dbo.LeaveTypes", "LeaveTypeID", cascadeDelete: true);
            DropColumn("dbo.LeaveApplications", "LeaveType");
        }
        
        public override void Down()
        {
            AddColumn("dbo.LeaveApplications", "LeaveType", c => c.String());
            DropForeignKey("dbo.LeaveApplications", "LeaveTypeID", "dbo.LeaveTypes");
            DropIndex("dbo.LeaveApplications", new[] { "LeaveTypeID" });
            DropColumn("dbo.LeaveApplications", "LeaveTypeID");
        }
    }
}
