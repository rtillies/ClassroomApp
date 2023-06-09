﻿// <auto-generated />
using ClassroomApp;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ClassroomApp.Migrations
{
    [DbContext(typeof(ClassroomContext))]
    partial class ClassroomContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("ClassroomApp.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("Capacity")
                        .HasColumnType("integer")
                        .HasColumnName("capacity");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.HasKey("Id")
                        .HasName("pk_courses");

                    b.ToTable("courses", (string)null);
                });

            modelBuilder.Entity("ClassroomApp.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("Age")
                        .HasColumnType("integer")
                        .HasColumnName("age");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("first_name");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("last_name");

                    b.HasKey("Id")
                        .HasName("pk_students");

                    b.ToTable("students", (string)null);
                });

            modelBuilder.Entity("CourseStudent", b =>
                {
                    b.Property<int>("CourseListId")
                        .HasColumnType("integer")
                        .HasColumnName("course_list_id");

                    b.Property<int>("RosterId")
                        .HasColumnType("integer")
                        .HasColumnName("roster_id");

                    b.HasKey("CourseListId", "RosterId")
                        .HasName("pk_course_student");

                    b.HasIndex("RosterId")
                        .HasDatabaseName("ix_course_student_roster_id");

                    b.ToTable("course_student", (string)null);
                });

            modelBuilder.Entity("CourseStudent", b =>
                {
                    b.HasOne("ClassroomApp.Course", null)
                        .WithMany()
                        .HasForeignKey("CourseListId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_course_student_courses_course_list_id");

                    b.HasOne("ClassroomApp.Student", null)
                        .WithMany()
                        .HasForeignKey("RosterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_course_student_students_roster_id");
                });
#pragma warning restore 612, 618
        }
    }
}
