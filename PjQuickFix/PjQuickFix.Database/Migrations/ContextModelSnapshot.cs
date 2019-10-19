﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PjQuickFix.Database;

namespace PjQuickFix.Database.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PjQuickFix.Domain.UserEntity", b =>
                {
                    b.Property<long>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Roles")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("UserId");

                    b.ToTable("Users","User");

                    b.HasData(
                        new
                        {
                            UserId = 1L,
                            Roles = 3,
                            Status = 1
                        });
                });

            modelBuilder.Entity("PjQuickFix.Domain.UserLogEntity", b =>
                {
                    b.Property<long>("UserLogId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("LogType")
                        .HasColumnType("int");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("UserLogId");

                    b.HasIndex("UserId");

                    b.ToTable("UsersLogs","User");
                });

            modelBuilder.Entity("PjQuickFix.Domain.UserEntity", b =>
                {
                    b.OwnsOne("PjQuickFix.Domain.Email", "Email", b1 =>
                        {
                            b1.Property<long>("UserEntityUserId")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("bigint")
                                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                            b1.Property<string>("Address")
                                .IsRequired()
                                .HasColumnName("Email")
                                .HasColumnType("nvarchar(300)")
                                .HasMaxLength(300);

                            b1.HasKey("UserEntityUserId");

                            b1.HasIndex("Address")
                                .IsUnique()
                                .HasFilter("[Email] IS NOT NULL");

                            b1.ToTable("Users");

                            b1.WithOwner()
                                .HasForeignKey("UserEntityUserId");

                            b1.HasData(
                                new
                                {
                                    UserEntityUserId = 1L,
                                    Address = "administrator@administrator.com"
                                });
                        });

                    b.OwnsOne("PjQuickFix.Domain.FullName", "FullName", b1 =>
                        {
                            b1.Property<long>("UserEntityUserId")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("bigint")
                                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                            b1.Property<string>("Name")
                                .IsRequired()
                                .HasColumnName("Name")
                                .HasColumnType("nvarchar(100)")
                                .HasMaxLength(100);

                            b1.Property<string>("Surname")
                                .IsRequired()
                                .HasColumnName("Surname")
                                .HasColumnType("nvarchar(200)")
                                .HasMaxLength(200);

                            b1.HasKey("UserEntityUserId");

                            b1.ToTable("Users");

                            b1.WithOwner()
                                .HasForeignKey("UserEntityUserId");

                            b1.HasData(
                                new
                                {
                                    UserEntityUserId = 1L,
                                    Name = "Administrator",
                                    Surname = "Administrator"
                                });
                        });

                    b.OwnsOne("PjQuickFix.Domain.SignIn", "SignIn", b1 =>
                        {
                            b1.Property<long>("UserEntityUserId")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("bigint")
                                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                            b1.Property<string>("Login")
                                .IsRequired()
                                .HasColumnName("Login")
                                .HasColumnType("nvarchar(100)")
                                .HasMaxLength(100);

                            b1.Property<string>("Password")
                                .IsRequired()
                                .HasColumnName("Password")
                                .HasColumnType("nvarchar(500)")
                                .HasMaxLength(500);

                            b1.Property<string>("Salt")
                                .IsRequired()
                                .HasColumnName("Salt")
                                .HasColumnType("nvarchar(500)")
                                .HasMaxLength(500);

                            b1.HasKey("UserEntityUserId");

                            b1.HasIndex("Login")
                                .IsUnique()
                                .HasFilter("[Login] IS NOT NULL");

                            b1.ToTable("Users");

                            b1.WithOwner()
                                .HasForeignKey("UserEntityUserId");

                            b1.HasData(
                                new
                                {
                                    UserEntityUserId = 1L,
                                    Login = "admin",
                                    Password = "O34uMN1Vho2IYcSM7nlXEqn57RZ8VEUsJwH++sFr0i3MSHJVx8J3PQGjhLR3s5i4l0XWUnCnymQ/EbRmzvLy8uMWREZu7vZI+BqebjAl5upYKMMQvlEcBeyLcRRTTBpYpv80m/YCZQmpig4XFVfIViLLZY/Kr5gBN5dkQf25rK8=",
                                    Salt = "79005744-e69a-4b09-996b-08fe0b70cbb9"
                                });
                        });
                });

            modelBuilder.Entity("PjQuickFix.Domain.UserLogEntity", b =>
                {
                    b.HasOne("PjQuickFix.Domain.UserEntity", "User")
                        .WithMany("UsersLogs")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
