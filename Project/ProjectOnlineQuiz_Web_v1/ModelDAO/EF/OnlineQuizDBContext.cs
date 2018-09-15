namespace ModelDAO.EF
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class OnlineQuizDBContext : DbContext
    {
        public OnlineQuizDBContext()
            : base("name=OnlineQuizDBContext")
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<Answer> Answers { get; set; }
        public virtual DbSet<AttendClass> AttendClasses { get; set; }
        public virtual DbSet<Chapter> Chapters { get; set; }
        public virtual DbSet<Class> Classes { get; set; }
        public virtual DbSet<ExamDetail> ExamDetails { get; set; }
        public virtual DbSet<Exam> Exams { get; set; }
        public virtual DbSet<GeneralQuestion> GeneralQuestions { get; set; }
        public virtual DbSet<Member> Members { get; set; }
        public virtual DbSet<MixingExam> MixingExams { get; set; }
        public virtual DbSet<MixingExamDetail> MixingExamDetails { get; set; }
        public virtual DbSet<Question> Questions { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Subject> Subjects { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Teacher> Teachers { get; set; }
        public virtual DbSet<TeachingSubject> TeachingSubjects { get; set; }
        public virtual DbSet<Term> Terms { get; set; }
        public virtual DbSet<Test> Tests { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>()
                .HasOptional(e => e.Member)
                .WithRequired(e => e.Account);

            modelBuilder.Entity<AttendClass>()
                .HasMany(e => e.Tests)
                .WithRequired(e => e.AttendClass)
                .HasForeignKey(e => new { e.CodeStudent, e.CodeClass })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Class>()
                .HasMany(e => e.AttendClasses)
                .WithRequired(e => e.Class)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Member>()
                .HasOptional(e => e.Admin)
                .WithRequired(e => e.Member);

            modelBuilder.Entity<Member>()
                .HasOptional(e => e.Student)
                .WithRequired(e => e.Member);

            modelBuilder.Entity<Member>()
                .HasOptional(e => e.Teacher)
                .WithRequired(e => e.Member);

            modelBuilder.Entity<MixingExam>()
                .HasMany(e => e.Tests)
                .WithRequired(e => e.MixingExam)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Student>()
                .HasMany(e => e.AttendClasses)
                .WithRequired(e => e.Student)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Subject>()
                .HasMany(e => e.TeachingSubjects)
                .WithRequired(e => e.Subject)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Teacher>()
                .HasMany(e => e.TeachingSubjects)
                .WithRequired(e => e.Teacher)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TeachingSubject>()
                .HasMany(e => e.Questions)
                .WithOptional(e => e.TeachingSubject)
                .HasForeignKey(e => new { e.CodeTeacher, e.CodeSubject });
        }
    }
}
