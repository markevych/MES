﻿// <auto-generated />
using System;
using MES.DAL.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MES.DAL.Migrations
{
    [DbContext(typeof(MESContext))]
    [Migration("20190603190951_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MES.DAL.Entities.Education.Lecture", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Lectures");
                });

            modelBuilder.Entity("MES.DAL.Entities.Group.Direction", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("DirectionTypeId");

                    b.Property<Guid>("StreamId");

                    b.HasKey("Id");

                    b.HasIndex("DirectionTypeId");

                    b.HasIndex("StreamId");

                    b.ToTable("Directions");
                });

            modelBuilder.Entity("MES.DAL.Entities.Group.DirectionType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Name");

                    b.HasKey("Id");

                    b.ToTable("DirectionTypes");
                });

            modelBuilder.Entity("MES.DAL.Entities.Group.Group", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("DirectionId");

                    b.Property<int>("Grade");

                    b.HasKey("Id");

                    b.HasIndex("DirectionId");

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("MES.DAL.Entities.Group.Program", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Programs");
                });

            modelBuilder.Entity("MES.DAL.Entities.Group.Role", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("MES.DAL.Entities.Group.Stream", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Year");

                    b.HasKey("Id");

                    b.ToTable("Streams");
                });

            modelBuilder.Entity("MES.DAL.Entities.Group.Student", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("GroupId");

                    b.HasKey("Id");

                    b.HasIndex("GroupId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("MES.DAL.Entities.Group.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email");

                    b.Property<string>("Password");

                    b.Property<Guid>("RoleId");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("MES.DAL.Entities.Program.Chapter", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<Guid>("TopicId");

                    b.HasKey("Id");

                    b.HasIndex("TopicId");

                    b.ToTable("Chapters");
                });

            modelBuilder.Entity("MES.DAL.Entities.Program.Skill", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<Guid>("TopicId");

                    b.HasKey("Id");

                    b.HasIndex("TopicId");

                    b.ToTable("Skills");
                });

            modelBuilder.Entity("MES.DAL.Entities.Program.Subject", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("HoursQuantity");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Subjects");
                });

            modelBuilder.Entity("MES.DAL.Entities.Program.Topic", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Grade");

                    b.Property<int>("Hours");

                    b.Property<string>("Name");

                    b.Property<int>("Number");

                    b.Property<Guid>("SubjectId");

                    b.HasKey("Id");

                    b.HasIndex("SubjectId");

                    b.ToTable("Topics");
                });

            modelBuilder.Entity("MES.DAL.Entities.Testing.Answer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Instance");

                    b.Property<bool>("IsCorrect");

                    b.Property<Guid>("QuestionId");

                    b.HasKey("Id");

                    b.HasIndex("QuestionId");

                    b.ToTable("Answers");
                });

            modelBuilder.Entity("MES.DAL.Entities.Testing.Question", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Instance");

                    b.Property<Guid>("TestId");

                    b.HasKey("Id");

                    b.HasIndex("TestId");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("MES.DAL.Entities.Testing.Test", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<Guid>("TopicId");

                    b.HasKey("Id");

                    b.HasIndex("TopicId");

                    b.ToTable("Tests");
                });

            modelBuilder.Entity("MES.DAL.Entities.Group.Direction", b =>
                {
                    b.HasOne("MES.DAL.Entities.Group.DirectionType", "DirectionType")
                        .WithMany("Directions")
                        .HasForeignKey("DirectionTypeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MES.DAL.Entities.Group.Stream", "Stream")
                        .WithMany("Directions")
                        .HasForeignKey("StreamId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MES.DAL.Entities.Group.Group", b =>
                {
                    b.HasOne("MES.DAL.Entities.Group.Direction", "Direction")
                        .WithMany("Groups")
                        .HasForeignKey("DirectionId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MES.DAL.Entities.Group.Student", b =>
                {
                    b.HasOne("MES.DAL.Entities.Group.Group", "Group")
                        .WithMany("Students")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MES.DAL.Entities.Group.User", b =>
                {
                    b.HasOne("MES.DAL.Entities.Group.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MES.DAL.Entities.Program.Chapter", b =>
                {
                    b.HasOne("MES.DAL.Entities.Program.Topic", "Topic")
                        .WithMany("Chapters")
                        .HasForeignKey("TopicId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MES.DAL.Entities.Program.Skill", b =>
                {
                    b.HasOne("MES.DAL.Entities.Program.Topic", "Topic")
                        .WithMany("Skills")
                        .HasForeignKey("TopicId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MES.DAL.Entities.Program.Topic", b =>
                {
                    b.HasOne("MES.DAL.Entities.Program.Subject", "Subject")
                        .WithMany("Topics")
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MES.DAL.Entities.Testing.Answer", b =>
                {
                    b.HasOne("MES.DAL.Entities.Testing.Question", "Question")
                        .WithMany("Answers")
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MES.DAL.Entities.Testing.Question", b =>
                {
                    b.HasOne("MES.DAL.Entities.Testing.Test", "Test")
                        .WithMany("Questions")
                        .HasForeignKey("TestId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MES.DAL.Entities.Testing.Test", b =>
                {
                    b.HasOne("MES.DAL.Entities.Program.Topic", "Topic")
                        .WithMany()
                        .HasForeignKey("TopicId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
