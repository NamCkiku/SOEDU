namespace SOEDU.Entities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addmigrationInitialDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Sys_Assess",
                c => new
                    {
                        Assess_ID = c.String(nullable: false, maxLength: 50, unicode: false),
                        Course_ID = c.String(maxLength: 50, unicode: false),
                        IsStar = c.Int(),
                        Description = c.String(maxLength: 500),
                        CreateDate = c.DateTime(storeType: "smalldatetime"),
                    })
                .PrimaryKey(t => t.Assess_ID)
                .ForeignKey("dbo.Sys_Course", t => t.Course_ID)
                .Index(t => t.Course_ID);
            
            CreateTable(
                "dbo.Sys_Course",
                c => new
                    {
                        Course_ID = c.String(nullable: false, maxLength: 50, unicode: false),
                        Course_Name = c.String(maxLength: 250),
                        Avatar = c.Binary(storeType: "image"),
                        Video = c.String(maxLength: 500),
                        Description = c.String(storeType: "ntext"),
                        IsPrice = c.Double(),
                        IsPriceSale = c.Double(),
                        ViewCount = c.Int(),
                        CreateDate = c.DateTime(storeType: "smalldatetime"),
                        Status = c.Boolean(),
                        IsOrder = c.Int(),
                    })
                .PrimaryKey(t => t.Course_ID);
            
            CreateTable(
                "dbo.Sys_CourseCategory",
                c => new
                    {
                        Category_ID = c.String(nullable: false, maxLength: 50, unicode: false),
                        Course_ID = c.String(maxLength: 50, unicode: false),
                        Category_Name = c.String(maxLength: 500),
                        Title_Name = c.String(maxLength: 250),
                        IsIcon = c.Binary(storeType: "image"),
                        Parent_ID = c.String(maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.Category_ID)
                .ForeignKey("dbo.Sys_Course", t => t.Course_ID)
                .ForeignKey("dbo.Sys_CourseCategory", t => t.Parent_ID)
                .Index(t => t.Course_ID)
                .Index(t => t.Parent_ID);
            
            CreateTable(
                "dbo.Sys_Section",
                c => new
                    {
                        Section_ID = c.String(nullable: false, maxLength: 50, unicode: false),
                        Course_ID = c.String(maxLength: 50, unicode: false),
                        Section_Name = c.String(maxLength: 250),
                        Title = c.String(maxLength: 250),
                        Description = c.String(maxLength: 500),
                        CreateDate = c.DateTime(storeType: "smalldatetime"),
                        IsOrder = c.Int(),
                        IsStatus = c.Boolean(),
                    })
                .PrimaryKey(t => t.Section_ID)
                .ForeignKey("dbo.Sys_Course", t => t.Course_ID)
                .Index(t => t.Course_ID);
            
            CreateTable(
                "dbo.Sys_Lesson",
                c => new
                    {
                        Lesson_ID = c.String(nullable: false, maxLength: 50, unicode: false),
                        Section_ID = c.String(maxLength: 50, unicode: false),
                        Lesson_Name = c.String(maxLength: 250),
                        Title = c.String(maxLength: 250),
                        Description = c.String(),
                        Video = c.String(maxLength: 500),
                        ParentID = c.String(maxLength: 50, unicode: false),
                        CreateDate = c.DateTime(storeType: "smalldatetime"),
                        IsOrder = c.Int(),
                        IsStatus = c.Boolean(),
                    })
                .PrimaryKey(t => t.Lesson_ID)
                .ForeignKey("dbo.Sys_Lesson", t => t.ParentID)
                .ForeignKey("dbo.Sys_Section", t => t.Section_ID)
                .Index(t => t.Section_ID)
                .Index(t => t.ParentID);
            
            CreateTable(
                "dbo.Sys_Attach",
                c => new
                    {
                        Attach_ID = c.String(nullable: false, maxLength: 50, unicode: false),
                        Lesson_ID = c.String(maxLength: 50, unicode: false),
                        File_Name = c.String(maxLength: 250),
                        Des = c.String(maxLength: 250),
                        FileSource = c.Binary(storeType: "image"),
                        FileSize = c.String(maxLength: 20, unicode: false),
                        IsOrder = c.Int(),
                    })
                .PrimaryKey(t => t.Attach_ID)
                .ForeignKey("dbo.Sys_Lesson", t => t.Lesson_ID)
                .Index(t => t.Lesson_ID);
            
            CreateTable(
                "dbo.Sys_Test",
                c => new
                    {
                        Test_ID = c.String(nullable: false, maxLength: 50, unicode: false),
                        Lesson_ID = c.String(maxLength: 50, unicode: false),
                        Test_Name = c.String(maxLength: 50),
                        IsSetTime = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Test_ID)
                .ForeignKey("dbo.Sys_Lesson", t => t.Lesson_ID)
                .Index(t => t.Lesson_ID);
            
            CreateTable(
                "dbo.Sys_StudentTest",
                c => new
                    {
                        User_ID = c.String(nullable: false, maxLength: 50, unicode: false),
                        Test_ID = c.String(nullable: false, maxLength: 50, unicode: false),
                        IsDate = c.DateTime(),
                        IsGetTime = c.String(maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => new { t.User_ID, t.Test_ID })
                .ForeignKey("dbo.Sys_TestLesson", t => t.Test_ID)
                .ForeignKey("dbo.Sys_Users", t => t.User_ID)
                .ForeignKey("dbo.Sys_Test", t => t.Test_ID)
                .Index(t => t.User_ID)
                .Index(t => t.Test_ID);
            
            CreateTable(
                "dbo.Sys_TestLesson",
                c => new
                    {
                        Test_ID = c.String(nullable: false, maxLength: 50, unicode: false),
                        Lesson_ID = c.String(maxLength: 50, unicode: false),
                        Test_Name = c.String(maxLength: 250),
                        IsSetTime = c.String(maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.Test_ID);
            
            CreateTable(
                "dbo.Sys_TestLessonAnswer",
                c => new
                    {
                        Answer_ID = c.String(nullable: false, maxLength: 50, unicode: false),
                        Test_ID = c.String(maxLength: 50, unicode: false),
                        Answer_Name = c.String(maxLength: 500),
                    })
                .PrimaryKey(t => t.Answer_ID)
                .ForeignKey("dbo.Sys_Test", t => t.Test_ID)
                .ForeignKey("dbo.Sys_TestLesson", t => t.Test_ID)
                .Index(t => t.Test_ID);
            
            CreateTable(
                "dbo.Sys_TestLessonQuestion",
                c => new
                    {
                        Question_ID = c.String(nullable: false, maxLength: 50, unicode: false),
                        Answer_ID = c.String(maxLength: 50, unicode: false),
                        Question_Name = c.String(maxLength: 250),
                        IsSupper = c.Boolean(),
                        IsOK = c.Boolean(),
                    })
                .PrimaryKey(t => t.Question_ID)
                .ForeignKey("dbo.Sys_TestLessonAnswer", t => t.Answer_ID)
                .Index(t => t.Answer_ID);
            
            CreateTable(
                "dbo.Sys_Users",
                c => new
                    {
                        User_ID = c.String(nullable: false, maxLength: 50, unicode: false),
                        User_Name = c.String(maxLength: 50),
                        IsPassword = c.String(maxLength: 100),
                        IsName = c.String(maxLength: 50),
                        IsSex = c.Boolean(),
                        IsAdds = c.String(maxLength: 250),
                        IsEmail = c.String(maxLength: 50),
                        IsMobile = c.String(maxLength: 50, unicode: false),
                        IsDes = c.String(maxLength: 500),
                        IsFoto = c.Binary(storeType: "image"),
                        IsLocked = c.Boolean(),
                        IsLevel = c.String(maxLength: 250),
                        CreateDate = c.DateTime(storeType: "smalldatetime"),
                    })
                .PrimaryKey(t => t.User_ID);
            
            CreateTable(
                "dbo.Sys_StudentCourse",
                c => new
                    {
                        User_ID = c.String(nullable: false, maxLength: 50, unicode: false),
                        Course_ID = c.String(nullable: false, maxLength: 50, unicode: false),
                        IsStatus = c.Boolean(),
                        CreateDate = c.DateTime(storeType: "smalldatetime"),
                    })
                .PrimaryKey(t => new { t.User_ID, t.Course_ID })
                .ForeignKey("dbo.Sys_Users", t => t.User_ID)
                .ForeignKey("dbo.Sys_Course", t => t.Course_ID)
                .Index(t => t.User_ID)
                .Index(t => t.Course_ID);
            
            CreateTable(
                "dbo.Sys_StudentTestSection",
                c => new
                    {
                        User_ID = c.String(nullable: false, maxLength: 50, unicode: false),
                        TestSection_ID = c.String(nullable: false, maxLength: 50, unicode: false),
                        IsDate = c.DateTime(storeType: "smalldatetime"),
                        IsGetTime = c.String(maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => new { t.User_ID, t.TestSection_ID })
                .ForeignKey("dbo.Sys_TestSection", t => t.TestSection_ID)
                .ForeignKey("dbo.Sys_Users", t => t.User_ID)
                .Index(t => t.User_ID)
                .Index(t => t.TestSection_ID);
            
            CreateTable(
                "dbo.Sys_TestSection",
                c => new
                    {
                        TestSection_ID = c.String(nullable: false, maxLength: 50, unicode: false),
                        Section_ID = c.String(maxLength: 50, unicode: false),
                        IsSetTime = c.String(maxLength: 50, unicode: false),
                        Test_Name = c.String(maxLength: 500),
                    })
                .PrimaryKey(t => t.TestSection_ID)
                .ForeignKey("dbo.Sys_Section", t => t.Section_ID)
                .Index(t => t.Section_ID);
            
            CreateTable(
                "dbo.Sys_TestSectionAnswer",
                c => new
                    {
                        Answer_ID = c.String(nullable: false, maxLength: 50, unicode: false),
                        TestSection_ID = c.String(maxLength: 50, unicode: false),
                        Answer_Name = c.String(maxLength: 250),
                    })
                .PrimaryKey(t => t.Answer_ID)
                .ForeignKey("dbo.Sys_TestSection", t => t.TestSection_ID)
                .Index(t => t.TestSection_ID);
            
            CreateTable(
                "dbo.Sys_TestSectionQuestion",
                c => new
                    {
                        Question_ID = c.String(nullable: false, maxLength: 50, unicode: false),
                        Answer_ID = c.String(maxLength: 50, unicode: false),
                        Question_Name = c.String(maxLength: 500),
                        IsSupper = c.Boolean(),
                        IsOK = c.Boolean(),
                    })
                .PrimaryKey(t => t.Question_ID)
                .ForeignKey("dbo.Sys_TestSectionAnswer", t => t.Answer_ID)
                .Index(t => t.Answer_ID);
            
            CreateTable(
                "dbo.Sys_Target",
                c => new
                    {
                        Target_ID = c.String(nullable: false, maxLength: 50, unicode: false),
                        Course_ID = c.String(maxLength: 50, unicode: false),
                        User_ID = c.String(maxLength: 50, unicode: false),
                        Parent_ID = c.String(maxLength: 50, unicode: false),
                        IsStar = c.Int(),
                        Description = c.String(maxLength: 250),
                        CreateDate = c.DateTime(storeType: "smalldatetime"),
                        IsOrder = c.Int(),
                    })
                .PrimaryKey(t => t.Target_ID)
                .ForeignKey("dbo.Sys_Course", t => t.Course_ID)
                .ForeignKey("dbo.Sys_Target", t => t.Parent_ID)
                .ForeignKey("dbo.Sys_Users", t => t.User_ID)
                .Index(t => t.Course_ID)
                .Index(t => t.User_ID)
                .Index(t => t.Parent_ID);
            
            CreateTable(
                "dbo.Sys_TeacherCourse",
                c => new
                    {
                        User_ID = c.String(nullable: false, maxLength: 50, unicode: false),
                        Course_ID = c.String(nullable: false, maxLength: 50, unicode: false),
                        IsSupper = c.Boolean(),
                        IsAdmin = c.Boolean(),
                        IsStatus = c.Boolean(),
                        CreateDate = c.DateTime(storeType: "smalldatetime"),
                    })
                .PrimaryKey(t => new { t.User_ID, t.Course_ID })
                .ForeignKey("dbo.Sys_Users", t => t.User_ID)
                .ForeignKey("dbo.Sys_Course", t => t.Course_ID)
                .Index(t => t.User_ID)
                .Index(t => t.Course_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Sys_TeacherCourse", "Course_ID", "dbo.Sys_Course");
            DropForeignKey("dbo.Sys_StudentCourse", "Course_ID", "dbo.Sys_Course");
            DropForeignKey("dbo.Sys_StudentTest", "Test_ID", "dbo.Sys_Test");
            DropForeignKey("dbo.Sys_TeacherCourse", "User_ID", "dbo.Sys_Users");
            DropForeignKey("dbo.Sys_Target", "User_ID", "dbo.Sys_Users");
            DropForeignKey("dbo.Sys_Target", "Parent_ID", "dbo.Sys_Target");
            DropForeignKey("dbo.Sys_Target", "Course_ID", "dbo.Sys_Course");
            DropForeignKey("dbo.Sys_StudentTestSection", "User_ID", "dbo.Sys_Users");
            DropForeignKey("dbo.Sys_TestSectionQuestion", "Answer_ID", "dbo.Sys_TestSectionAnswer");
            DropForeignKey("dbo.Sys_TestSectionAnswer", "TestSection_ID", "dbo.Sys_TestSection");
            DropForeignKey("dbo.Sys_StudentTestSection", "TestSection_ID", "dbo.Sys_TestSection");
            DropForeignKey("dbo.Sys_TestSection", "Section_ID", "dbo.Sys_Section");
            DropForeignKey("dbo.Sys_StudentTest", "User_ID", "dbo.Sys_Users");
            DropForeignKey("dbo.Sys_StudentCourse", "User_ID", "dbo.Sys_Users");
            DropForeignKey("dbo.Sys_TestLessonQuestion", "Answer_ID", "dbo.Sys_TestLessonAnswer");
            DropForeignKey("dbo.Sys_TestLessonAnswer", "Test_ID", "dbo.Sys_TestLesson");
            DropForeignKey("dbo.Sys_TestLessonAnswer", "Test_ID", "dbo.Sys_Test");
            DropForeignKey("dbo.Sys_StudentTest", "Test_ID", "dbo.Sys_TestLesson");
            DropForeignKey("dbo.Sys_Test", "Lesson_ID", "dbo.Sys_Lesson");
            DropForeignKey("dbo.Sys_Lesson", "Section_ID", "dbo.Sys_Section");
            DropForeignKey("dbo.Sys_Lesson", "ParentID", "dbo.Sys_Lesson");
            DropForeignKey("dbo.Sys_Attach", "Lesson_ID", "dbo.Sys_Lesson");
            DropForeignKey("dbo.Sys_Section", "Course_ID", "dbo.Sys_Course");
            DropForeignKey("dbo.Sys_CourseCategory", "Parent_ID", "dbo.Sys_CourseCategory");
            DropForeignKey("dbo.Sys_CourseCategory", "Course_ID", "dbo.Sys_Course");
            DropForeignKey("dbo.Sys_Assess", "Course_ID", "dbo.Sys_Course");
            DropIndex("dbo.Sys_TeacherCourse", new[] { "Course_ID" });
            DropIndex("dbo.Sys_TeacherCourse", new[] { "User_ID" });
            DropIndex("dbo.Sys_Target", new[] { "Parent_ID" });
            DropIndex("dbo.Sys_Target", new[] { "User_ID" });
            DropIndex("dbo.Sys_Target", new[] { "Course_ID" });
            DropIndex("dbo.Sys_TestSectionQuestion", new[] { "Answer_ID" });
            DropIndex("dbo.Sys_TestSectionAnswer", new[] { "TestSection_ID" });
            DropIndex("dbo.Sys_TestSection", new[] { "Section_ID" });
            DropIndex("dbo.Sys_StudentTestSection", new[] { "TestSection_ID" });
            DropIndex("dbo.Sys_StudentTestSection", new[] { "User_ID" });
            DropIndex("dbo.Sys_StudentCourse", new[] { "Course_ID" });
            DropIndex("dbo.Sys_StudentCourse", new[] { "User_ID" });
            DropIndex("dbo.Sys_TestLessonQuestion", new[] { "Answer_ID" });
            DropIndex("dbo.Sys_TestLessonAnswer", new[] { "Test_ID" });
            DropIndex("dbo.Sys_StudentTest", new[] { "Test_ID" });
            DropIndex("dbo.Sys_StudentTest", new[] { "User_ID" });
            DropIndex("dbo.Sys_Test", new[] { "Lesson_ID" });
            DropIndex("dbo.Sys_Attach", new[] { "Lesson_ID" });
            DropIndex("dbo.Sys_Lesson", new[] { "ParentID" });
            DropIndex("dbo.Sys_Lesson", new[] { "Section_ID" });
            DropIndex("dbo.Sys_Section", new[] { "Course_ID" });
            DropIndex("dbo.Sys_CourseCategory", new[] { "Parent_ID" });
            DropIndex("dbo.Sys_CourseCategory", new[] { "Course_ID" });
            DropIndex("dbo.Sys_Assess", new[] { "Course_ID" });
            DropTable("dbo.Sys_TeacherCourse");
            DropTable("dbo.Sys_Target");
            DropTable("dbo.Sys_TestSectionQuestion");
            DropTable("dbo.Sys_TestSectionAnswer");
            DropTable("dbo.Sys_TestSection");
            DropTable("dbo.Sys_StudentTestSection");
            DropTable("dbo.Sys_StudentCourse");
            DropTable("dbo.Sys_Users");
            DropTable("dbo.Sys_TestLessonQuestion");
            DropTable("dbo.Sys_TestLessonAnswer");
            DropTable("dbo.Sys_TestLesson");
            DropTable("dbo.Sys_StudentTest");
            DropTable("dbo.Sys_Test");
            DropTable("dbo.Sys_Attach");
            DropTable("dbo.Sys_Lesson");
            DropTable("dbo.Sys_Section");
            DropTable("dbo.Sys_CourseCategory");
            DropTable("dbo.Sys_Course");
            DropTable("dbo.Sys_Assess");
        }
    }
}
