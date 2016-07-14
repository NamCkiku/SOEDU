namespace SOEDU.Entities.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class SOEDUEntity : DbContext
    {
        public SOEDUEntity()
            : base("name=SOEDUEntity")
        {
        }

        public virtual DbSet<Sys_Assess> Sys_Assess { get; set; }
        public virtual DbSet<Sys_Attach> Sys_Attach { get; set; }
        public virtual DbSet<Sys_Course> Sys_Course { get; set; }
        public virtual DbSet<Sys_CourseCategory> Sys_CourseCategory { get; set; }
        public virtual DbSet<Sys_Lesson> Sys_Lesson { get; set; }
        public virtual DbSet<Sys_Section> Sys_Section { get; set; }
        public virtual DbSet<Sys_StudentCourse> Sys_StudentCourse { get; set; }
        public virtual DbSet<Sys_StudentTest> Sys_StudentTest { get; set; }
        public virtual DbSet<Sys_StudentTestSection> Sys_StudentTestSection { get; set; }
        public virtual DbSet<Sys_Target> Sys_Target { get; set; }
        public virtual DbSet<Sys_TeacherCourse> Sys_TeacherCourse { get; set; }
        public virtual DbSet<Sys_Test> Sys_Test { get; set; }
        public virtual DbSet<Sys_TestLesson> Sys_TestLesson { get; set; }
        public virtual DbSet<Sys_TestLessonAnswer> Sys_TestLessonAnswer { get; set; }
        public virtual DbSet<Sys_TestLessonQuestion> Sys_TestLessonQuestion { get; set; }
        public virtual DbSet<Sys_TestSection> Sys_TestSection { get; set; }
        public virtual DbSet<Sys_TestSectionAnswer> Sys_TestSectionAnswer { get; set; }
        public virtual DbSet<Sys_TestSectionQuestion> Sys_TestSectionQuestion { get; set; }
        public virtual DbSet<Sys_Users> Sys_Users { get; set; }
        public virtual DbSet<Sys_Error> Sys_Errors { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Sys_Assess>()
                .Property(e => e.Assess_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Assess>()
                .Property(e => e.Course_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Attach>()
                .Property(e => e.Attach_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Attach>()
                .Property(e => e.Lesson_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Attach>()
                .Property(e => e.FileSize)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Course>()
                .Property(e => e.Course_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Course>()
                .HasMany(e => e.Sys_StudentCourse)
                .WithRequired(e => e.Sys_Course)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Sys_Course>()
                .HasMany(e => e.Sys_TeacherCourse)
                .WithRequired(e => e.Sys_Course)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Sys_CourseCategory>()
                .Property(e => e.Category_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_CourseCategory>()
                .Property(e => e.Course_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_CourseCategory>()
                .Property(e => e.Parent_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_CourseCategory>()
                .HasMany(e => e.Sys_CourseCategory1)
                .WithOptional(e => e.Sys_CourseCategory2)
                .HasForeignKey(e => e.Parent_ID);

            modelBuilder.Entity<Sys_Lesson>()
                .Property(e => e.Lesson_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Lesson>()
                .Property(e => e.Section_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Lesson>()
                .Property(e => e.ParentID)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Lesson>()
                .HasMany(e => e.Sys_Lesson1)
                .WithOptional(e => e.Sys_Lesson2)
                .HasForeignKey(e => e.ParentID);

            modelBuilder.Entity<Sys_Section>()
                .Property(e => e.Section_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Section>()
                .Property(e => e.Course_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_StudentCourse>()
                .Property(e => e.User_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_StudentCourse>()
                .Property(e => e.Course_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_StudentTest>()
                .Property(e => e.User_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_StudentTest>()
                .Property(e => e.Test_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_StudentTest>()
                .Property(e => e.IsGetTime)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_StudentTestSection>()
                .Property(e => e.User_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_StudentTestSection>()
                .Property(e => e.TestSection_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_StudentTestSection>()
                .Property(e => e.IsGetTime)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Target>()
                .Property(e => e.Target_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Target>()
                .Property(e => e.Course_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Target>()
                .Property(e => e.User_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Target>()
                .Property(e => e.Parent_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Target>()
                .HasMany(e => e.Sys_Target1)
                .WithOptional(e => e.Sys_Target2)
                .HasForeignKey(e => e.Parent_ID);

            modelBuilder.Entity<Sys_TeacherCourse>()
                .Property(e => e.User_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_TeacherCourse>()
                .Property(e => e.Course_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Test>()
                .Property(e => e.Test_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Test>()
                .Property(e => e.Lesson_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Test>()
                .HasMany(e => e.Sys_StudentTest)
                .WithRequired(e => e.Sys_Test)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Sys_TestLesson>()
                .Property(e => e.Test_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_TestLesson>()
                .Property(e => e.Lesson_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_TestLesson>()
                .Property(e => e.IsSetTime)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_TestLesson>()
                .HasMany(e => e.Sys_StudentTest)
                .WithRequired(e => e.Sys_TestLesson)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Sys_TestLessonAnswer>()
                .Property(e => e.Answer_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_TestLessonAnswer>()
                .Property(e => e.Test_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_TestLessonQuestion>()
                .Property(e => e.Question_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_TestLessonQuestion>()
                .Property(e => e.Answer_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_TestSection>()
                .Property(e => e.TestSection_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_TestSection>()
                .Property(e => e.Section_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_TestSection>()
                .Property(e => e.IsSetTime)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_TestSection>()
                .HasMany(e => e.Sys_StudentTestSection)
                .WithRequired(e => e.Sys_TestSection)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Sys_TestSectionAnswer>()
                .Property(e => e.Answer_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_TestSectionAnswer>()
                .Property(e => e.TestSection_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_TestSectionQuestion>()
                .Property(e => e.Question_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_TestSectionQuestion>()
                .Property(e => e.Answer_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Users>()
                .Property(e => e.User_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Users>()
                .Property(e => e.IsMobile)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Users>()
                .HasMany(e => e.Sys_StudentCourse)
                .WithRequired(e => e.Sys_Users)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Sys_Users>()
                .HasMany(e => e.Sys_StudentTest)
                .WithRequired(e => e.Sys_Users)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Sys_Users>()
                .HasMany(e => e.Sys_StudentTestSection)
                .WithRequired(e => e.Sys_Users)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Sys_Users>()
                .HasMany(e => e.Sys_TeacherCourse)
                .WithRequired(e => e.Sys_Users)
                .WillCascadeOnDelete(false);
        }
    }
}
