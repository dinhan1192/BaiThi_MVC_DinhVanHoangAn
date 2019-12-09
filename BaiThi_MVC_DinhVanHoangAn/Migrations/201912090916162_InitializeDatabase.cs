namespace BaiThi_MVC_DinhVanHoangAn.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitializeDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Exams",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ExamSubject = c.Int(nullable: false),
                        StartTime = c.DateTime(nullable: false, precision: 0),
                        ExamDate = c.DateTime(nullable: false, precision: 0),
                        ExamDuration = c.Int(nullable: false),
                        ClassRoom = c.Int(nullable: false),
                        Faculty = c.Int(nullable: false),
                        Status = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Exams");
        }
    }
}
