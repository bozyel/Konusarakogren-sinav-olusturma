using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Konusarak_ogren.Models
{
    public partial class Db_Language_CourseContext : DbContext
    {
        public Db_Language_CourseContext()
        {
        }

        public Db_Language_CourseContext(DbContextOptions<Db_Language_CourseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblArticle> TblArticles { get; set; }
        public virtual DbSet<TblExam> TblExams { get; set; }
        public virtual DbSet<TblQuestion> TblQuestions { get; set; }
        public virtual DbSet<TblUser> TblUsers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-QHTAPA5\\MSSQLSERVER01;Database=Db_Language_Course;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TblArticle>(entity =>
            {
                entity.ToTable("tbl_articles");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ArticleContent).HasColumnName("article_content");

                entity.Property(e => e.ArticleDate)
                    .HasColumnType("datetime")
                    .HasColumnName("article_date");

                entity.Property(e => e.ArticleTitle)
                    .HasMaxLength(500)
                    .HasColumnName("article_title");

                entity.Property(e => e.Status).HasColumnName("status");
            });

            modelBuilder.Entity<TblExam>(entity =>
            {
                entity.ToTable("tbl_exams");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ArticleId).HasColumnName("article_id");

                entity.Property(e => e.ArticleTitle)
                    .HasMaxLength(2000)
                    .HasColumnName("article_title")
                    .IsFixedLength(true);

                entity.Property(e => e.ExamDate)
                    .HasMaxLength(25)
                    .HasColumnName("exam_date")
                    .IsFixedLength(true);

                entity.Property(e => e.Status).HasColumnName("status");

                entity.HasOne(d => d.Article)
                    .WithMany(p => p.TblExams)
                    .HasForeignKey(d => d.ArticleId)
                    .HasConstraintName("FK_tbl_exams_tbl_articles");
            });

            modelBuilder.Entity<TblQuestion>(entity =>
            {
                entity.ToTable("tbl_question");

                entity.Property(e => e.CorrectAnswer1)
                    .HasMaxLength(500)
                    .HasColumnName("correct_answer1");

                entity.Property(e => e.CorrectAnswer2)
                    .HasMaxLength(500)
                    .HasColumnName("correct_answer2");

                entity.Property(e => e.CorrectAnswer3)
                    .HasMaxLength(500)
                    .HasColumnName("correct_answer3");

                entity.Property(e => e.CorrectAnswer4)
                    .HasMaxLength(500)
                    .HasColumnName("correct_answer4");

                entity.Property(e => e.ExamId).HasColumnName("exam_id");

                entity.Property(e => e.Option1A)
                    .HasMaxLength(500)
                    .HasColumnName("option1_a");

                entity.Property(e => e.Option1B)
                    .HasMaxLength(500)
                    .HasColumnName("option1_b");

                entity.Property(e => e.Option1C)
                    .HasMaxLength(500)
                    .HasColumnName("option1_c");

                entity.Property(e => e.Option1D)
                    .HasMaxLength(500)
                    .HasColumnName("option1_d");

                entity.Property(e => e.Option2A)
                    .HasMaxLength(500)
                    .HasColumnName("option2_a");

                entity.Property(e => e.Option2B)
                    .HasMaxLength(500)
                    .HasColumnName("option2_b");

                entity.Property(e => e.Option2C)
                    .HasMaxLength(500)
                    .HasColumnName("option2_c");

                entity.Property(e => e.Option2D)
                    .HasMaxLength(500)
                    .HasColumnName("option2_d");

                entity.Property(e => e.Option3A)
                    .HasMaxLength(500)
                    .HasColumnName("option3_a");

                entity.Property(e => e.Option3B)
                    .HasMaxLength(500)
                    .HasColumnName("option3_b");

                entity.Property(e => e.Option3C)
                    .HasMaxLength(500)
                    .HasColumnName("option3_c");

                entity.Property(e => e.Option3D)
                    .HasMaxLength(500)
                    .HasColumnName("option3_d");

                entity.Property(e => e.Option4A)
                    .HasMaxLength(500)
                    .HasColumnName("option4_a");

                entity.Property(e => e.Option4B)
                    .HasMaxLength(500)
                    .HasColumnName("option4_b");

                entity.Property(e => e.Option4C)
                    .HasMaxLength(500)
                    .HasColumnName("option4_c");

                entity.Property(e => e.Option4D)
                    .HasMaxLength(500)
                    .HasColumnName("option4_d");

                entity.Property(e => e.Question1Text).HasColumnName("question1_text");

                entity.Property(e => e.Question2Text).HasColumnName("question2_text");

                entity.Property(e => e.Question3Text).HasColumnName("question3_text");

                entity.Property(e => e.Question4Text).HasColumnName("question4_text");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.HasOne(d => d.Exam)
                    .WithMany(p => p.TblQuestions)
                    .HasForeignKey(d => d.ExamId)
                    .HasConstraintName("FK_Question_tbl_exams");
            });

            modelBuilder.Entity<TblUser>(entity =>
            {
                entity.ToTable("tbl_users");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("password");

                entity.Property(e => e.Role).HasColumnName("role");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.UserName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("user_name");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
