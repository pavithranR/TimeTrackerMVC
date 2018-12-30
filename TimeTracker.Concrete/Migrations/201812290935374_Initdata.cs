namespace TimeTracker.Concrete.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initdata : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AssignedRoles",
                c => new
                    {
                        AssignedRolesID = c.Int(nullable: false, identity: true),
                        AssignToAdmin = c.Int(),
                        CreatedBy = c.Int(),
                        CreatedOn = c.DateTime(),
                        RegistrationID = c.Int(nullable: false),
                        Status = c.String(),
                    })
                .PrimaryKey(t => t.AssignedRolesID);
            
            CreateTable(
                "dbo.DescriptionTB",
                c => new
                    {
                        DescriptionID = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        ProjectID = c.Int(),
                        TimeSheetMasterID = c.Int(),
                        CreatedOn = c.DateTime(),
                        UserID = c.Int(),
                    })
                .PrimaryKey(t => t.DescriptionID);
            
            CreateTable(
                "dbo.ProjectMaster",
                c => new
                    {
                        ProjectID = c.Int(nullable: false, identity: true),
                        ProjectCode = c.String(nullable: false),
                        NatureofIndustry = c.String(nullable: false),
                        ProjectName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ProjectID);
            
            CreateTable(
                "dbo.Registration",
                c => new
                    {
                        RegistrationID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Mobileno = c.String(nullable: false),
                        EmailID = c.String(nullable: false),
                        Username = c.String(nullable: false),
                        Password = c.String(nullable: false),
                        ConfirmPassword = c.String(),
                        Gender = c.String(nullable: false),
                        Birthdate = c.DateTime(),
                        DateofJoining = c.DateTime(),
                        RoleID = c.Int(),
                        EmployeeID = c.String(maxLength: 5),
                        CreatedOn = c.DateTime(),
                        ForceChangePassword = c.Int(),
                    })
                .PrimaryKey(t => t.RegistrationID);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        RoleID = c.Int(nullable: false, identity: true),
                        Rolename = c.String(),
                    })
                .PrimaryKey(t => t.RoleID);
            
            CreateTable(
                "dbo.TimeSheetDetails",
                c => new
                    {
                        TimeSheetID = c.Int(nullable: false, identity: true),
                        DaysofWeek = c.String(),
                        Hours = c.Int(),
                        Period = c.DateTime(),
                        ProjectID = c.Int(),
                        UserID = c.Int(nullable: false),
                        CreatedOn = c.DateTime(),
                        TimeSheetMasterID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TimeSheetID);
            
            CreateTable(
                "dbo.TimeSheetMaster",
                c => new
                    {
                        TimeSheetMasterID = c.Int(nullable: false, identity: true),
                        FromDate = c.DateTime(),
                        ToDate = c.DateTime(),
                        TotalHours = c.Int(),
                        UserID = c.Int(nullable: false),
                        CreatedOn = c.DateTime(),
                        TimeSheetStatus = c.Int(nullable: false),
                        Comment = c.String(),
                    })
                .PrimaryKey(t => t.TimeSheetMasterID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TimeSheetMaster");
            DropTable("dbo.TimeSheetDetails");
            DropTable("dbo.Roles");
            DropTable("dbo.Registration");
            DropTable("dbo.ProjectMaster");
            DropTable("dbo.DescriptionTB");
            DropTable("dbo.AssignedRoles");
        }
    }
}
