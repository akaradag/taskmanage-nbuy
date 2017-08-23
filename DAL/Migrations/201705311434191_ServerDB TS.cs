namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ServerDBTS : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CustomerEmployee",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 50),
                        LastName = c.String(nullable: false, maxLength: 50),
                        CustomerID = c.Int(nullable: false),
                        Phone = c.String(maxLength: 13, unicode: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Customer", t => t.CustomerID, cascadeDelete: true)
                .Index(t => t.CustomerID);
            
            CreateTable(
                "dbo.Customer",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CompanyName = c.String(nullable: false, maxLength: 50),
                        Country = c.String(nullable: false, maxLength: 50),
                        City = c.String(nullable: false, maxLength: 50),
                        Address = c.String(maxLength: 200),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Project",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 100),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        CustomerID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Customer", t => t.CustomerID, cascadeDelete: true)
                .Index(t => t.CustomerID);
            
            CreateTable(
                "dbo.Request",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Description = c.String(maxLength: 500),
                        RecievedDate = c.DateTime(nullable: false),
                        RequestTypeID = c.Int(nullable: false),
                        ProjectID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Project", t => t.ProjectID, cascadeDelete: true)
                .ForeignKey("dbo.RequestType", t => t.RequestTypeID, cascadeDelete: true)
                .Index(t => t.RequestTypeID)
                .Index(t => t.ProjectID);
            
            CreateTable(
                "dbo.RequestType",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Task",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Description = c.String(maxLength: 500),
                        CreatedDate = c.DateTime(nullable: false),
                        ProjectID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Project", t => t.ProjectID, cascadeDelete: true)
                .Index(t => t.ProjectID);
            
            CreateTable(
                "dbo.TaskLog",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        TaskDate = c.DateTime(nullable: false),
                        TaskID = c.Int(nullable: false),
                        TaskStatusID = c.Int(nullable: false),
                        EmployeeID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Employee", t => t.EmployeeID)
                .ForeignKey("dbo.Task", t => t.TaskID, cascadeDelete: true)
                .ForeignKey("dbo.TaskStatus", t => t.TaskStatusID, cascadeDelete: true)
                .Index(t => t.TaskID)
                .Index(t => t.TaskStatusID)
                .Index(t => t.EmployeeID);
            
            CreateTable(
                "dbo.Employee",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 50),
                        LastName = c.String(nullable: false, maxLength: 50),
                        BirthDate = c.DateTime(),
                        HireDate = c.DateTime(nullable: false),
                        Email = c.String(nullable: false, maxLength: 50),
                        Password = c.String(nullable: false, maxLength: 15, fixedLength: true),
                        RoleID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Role", t => t.RoleID, cascadeDelete: true)
                .Index(t => t.RoleID);
            
            CreateTable(
                "dbo.Role",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.TaskStatus",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CustomerEmployee", "CustomerID", "dbo.Customer");
            DropForeignKey("dbo.Project", "CustomerID", "dbo.Customer");
            DropForeignKey("dbo.TaskLog", "TaskStatusID", "dbo.TaskStatus");
            DropForeignKey("dbo.TaskLog", "TaskID", "dbo.Task");
            DropForeignKey("dbo.TaskLog", "EmployeeID", "dbo.Employee");
            DropForeignKey("dbo.Employee", "RoleID", "dbo.Role");
            DropForeignKey("dbo.Task", "ProjectID", "dbo.Project");
            DropForeignKey("dbo.Request", "RequestTypeID", "dbo.RequestType");
            DropForeignKey("dbo.Request", "ProjectID", "dbo.Project");
            DropIndex("dbo.Employee", new[] { "RoleID" });
            DropIndex("dbo.TaskLog", new[] { "EmployeeID" });
            DropIndex("dbo.TaskLog", new[] { "TaskStatusID" });
            DropIndex("dbo.TaskLog", new[] { "TaskID" });
            DropIndex("dbo.Task", new[] { "ProjectID" });
            DropIndex("dbo.Request", new[] { "ProjectID" });
            DropIndex("dbo.Request", new[] { "RequestTypeID" });
            DropIndex("dbo.Project", new[] { "CustomerID" });
            DropIndex("dbo.CustomerEmployee", new[] { "CustomerID" });
            DropTable("dbo.TaskStatus");
            DropTable("dbo.Role");
            DropTable("dbo.Employee");
            DropTable("dbo.TaskLog");
            DropTable("dbo.Task");
            DropTable("dbo.RequestType");
            DropTable("dbo.Request");
            DropTable("dbo.Project");
            DropTable("dbo.Customer");
            DropTable("dbo.CustomerEmployee");
        }
    }
}
