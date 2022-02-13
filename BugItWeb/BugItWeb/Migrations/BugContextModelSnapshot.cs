﻿// <auto-generated />
using System;
using BugIt.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BugItWeb.Migrations
{
    [DbContext(typeof(BugContext))]
    partial class BugContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BugIt.Model.Project", b =>
                {
                    b.Property<int>("ProjectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProjectId"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("ProjectId");

                    b.HasIndex("UserId");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("BugIt.Model.Todo", b =>
                {
                    b.Property<int>("TodoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TodoId"), 1L, 1);

                    b.Property<DateTime?>("AssignedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DoneDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Priority")
                        .HasColumnType("int");

                    b.Property<int?>("ProjectId")
                        .HasColumnType("int");

                    b.Property<int>("ProjetId")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("TodoId");

                    b.HasIndex("ProjectId");

                    b.HasIndex("UserID");

                    b.ToTable("Todos");
                });

            modelBuilder.Entity("BugIt.Model.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("BugIt.Model.Project", b =>
                {
                    b.HasOne("BugIt.Model.User", null)
                        .WithMany("Projects")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("BugIt.Model.Todo", b =>
                {
                    b.HasOne("BugIt.Model.Project", null)
                        .WithMany("Todos")
                        .HasForeignKey("ProjectId");

                    b.HasOne("BugIt.Model.User", null)
                        .WithMany("Todo")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BugIt.Model.Project", b =>
                {
                    b.Navigation("Todos");
                });

            modelBuilder.Entity("BugIt.Model.User", b =>
                {
                    b.Navigation("Projects");

                    b.Navigation("Todo");
                });
#pragma warning restore 612, 618
        }
    }
}
