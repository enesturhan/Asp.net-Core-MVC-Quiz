﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using sınav.Data.Model;

namespace sınav.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20210731192217_migration")]
    partial class migration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113");

            modelBuilder.Entity("sınav.Data.Model.Admin", b =>
                {
                    b.Property<int>("AdminID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AdminPassword");

                    b.Property<string>("AdminUserName");

                    b.HasKey("AdminID");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("sınav.Data.Model.Question", b =>
                {
                    b.Property<int>("QuestionID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Question1");

                    b.Property<string>("Question2");

                    b.Property<string>("Question3");

                    b.Property<string>("Question4");

                    b.Property<char>("QuestionAns1");

                    b.Property<char>("QuestionAns2");

                    b.Property<char>("QuestionAns3");

                    b.Property<char>("QuestionAns4");

                    b.Property<string>("QuestionDesc");

                    b.HasKey("QuestionID");

                    b.ToTable("Questions");
                });
#pragma warning restore 612, 618
        }
    }
}
