﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using gtbweb.Models;

namespace gtbweb.mvc.Migrations.BlogDb
{
    [DbContext(typeof(BlogDbContext))]
    [Migration("20190406125003_BlogMigration")]
    partial class BlogMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854");

            modelBuilder.Entity("gtbweb.Models.BlogCollection", b =>
                {
                    b.Property<int>("BlogCollectionID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BlogPageID");

                    b.Property<string>("PersonalStatement");

                    b.Property<int>("ProfileID");

                    b.HasKey("BlogCollectionID");

                    b.HasIndex("BlogPageID");

                    b.HasIndex("ProfileID");

                    b.ToTable("BlogCollections");
                });

            modelBuilder.Entity("gtbweb.Models.BlogPage", b =>
                {
                    b.Property<int>("BlogPageID")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CommentID");

                    b.Property<DateTime>("CreationDate");

                    b.Property<string>("HeaderImage");

                    b.Property<string>("HeaderTitle");

                    b.Property<DateTime>("LastEditDate");

                    b.Property<int>("ProfileID");

                    b.Property<int>("TagID");

                    b.Property<string>("Text");

                    b.HasKey("BlogPageID");

                    b.HasIndex("CommentID");

                    b.HasIndex("ProfileID");

                    b.HasIndex("TagID");

                    b.ToTable("BlogPages");
                });

            modelBuilder.Entity("gtbweb.Models.Comment", b =>
                {
                    b.Property<int>("CommentID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreationDate");

                    b.Property<int>("ProfileID");

                    b.Property<int?>("ReplyID");

                    b.Property<string>("Text");

                    b.HasKey("CommentID");

                    b.HasIndex("ProfileID");

                    b.HasIndex("ReplyID");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("gtbweb.Models.Proficiency", b =>
                {
                    b.Property<int>("ProficiencyID")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("PercentageScore");

                    b.Property<int>("ProfileID");

                    b.Property<int?>("SkillID");

                    b.HasKey("ProficiencyID");

                    b.HasIndex("ProfileID");

                    b.HasIndex("SkillID");

                    b.ToTable("Proficiencies");
                });

            modelBuilder.Entity("gtbweb.Models.Profile", b =>
                {
                    b.Property<int>("ProfileID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("About");

                    b.Property<string>("Designation");

                    b.Property<string>("Image");

                    b.Property<DateTime>("RegistrationDate");

                    b.Property<string>("UserID");

                    b.HasKey("ProfileID");

                    b.ToTable("Profiles");
                });

            modelBuilder.Entity("gtbweb.Models.Service", b =>
                {
                    b.Property<int>("ServiceID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ServiceDescription");

                    b.Property<string>("Title");

                    b.HasKey("ServiceID");

                    b.ToTable("Services");
                });

            modelBuilder.Entity("gtbweb.Models.ServiceCollection", b =>
                {
                    b.Property<int>("ServiceCollectionID")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("ProficiencyID");

                    b.Property<int>("ServiceID");

                    b.HasKey("ServiceCollectionID");

                    b.HasIndex("ProficiencyID");

                    b.HasIndex("ServiceID");

                    b.ToTable("ServiceCollections");
                });

            modelBuilder.Entity("gtbweb.Models.Skill", b =>
                {
                    b.Property<int>("SkillID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Title");

                    b.HasKey("SkillID");

                    b.ToTable("Skills");
                });

            modelBuilder.Entity("gtbweb.Models.Tag", b =>
                {
                    b.Property<int>("TagID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Title");

                    b.HasKey("TagID");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("gtbweb.Models.BlogCollection", b =>
                {
                    b.HasOne("gtbweb.Models.BlogPage", "BlogPage")
                        .WithMany("BlogCollections")
                        .HasForeignKey("BlogPageID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("gtbweb.Models.Profile", "Profile")
                        .WithMany()
                        .HasForeignKey("ProfileID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("gtbweb.Models.BlogPage", b =>
                {
                    b.HasOne("gtbweb.Models.Comment")
                        .WithMany("BlogPages")
                        .HasForeignKey("CommentID");

                    b.HasOne("gtbweb.Models.Profile", "Profile")
                        .WithMany()
                        .HasForeignKey("ProfileID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("gtbweb.Models.Tag", "Tag")
                        .WithMany("BlogPage")
                        .HasForeignKey("TagID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("gtbweb.Models.Comment", b =>
                {
                    b.HasOne("gtbweb.Models.Profile", "Profile")
                        .WithMany()
                        .HasForeignKey("ProfileID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("gtbweb.Models.Comment", "Reply")
                        .WithMany()
                        .HasForeignKey("ReplyID");
                });

            modelBuilder.Entity("gtbweb.Models.Proficiency", b =>
                {
                    b.HasOne("gtbweb.Models.Profile", "Profile")
                        .WithMany("Proficiencies")
                        .HasForeignKey("ProfileID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("gtbweb.Models.Skill", "Skill")
                        .WithMany("Proficiencies")
                        .HasForeignKey("SkillID");
                });

            modelBuilder.Entity("gtbweb.Models.ServiceCollection", b =>
                {
                    b.HasOne("gtbweb.Models.Proficiency", "Proficiency")
                        .WithMany("ServiceCollections")
                        .HasForeignKey("ProficiencyID");

                    b.HasOne("gtbweb.Models.Service", "Service")
                        .WithMany("ServiceCollections")
                        .HasForeignKey("ServiceID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
