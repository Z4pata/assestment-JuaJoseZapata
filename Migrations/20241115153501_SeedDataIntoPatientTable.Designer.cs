﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using assestment_JuaJoseZapata.Data;

#nullable disable

namespace assestment_JuaJoseZapata.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20241115153501_SeedDataIntoPatientTable")]
    partial class SeedDataIntoPatientTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("assestment_JuaJoseZapata.Models.Doctor", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("user_id");

                    b.Property<string>("Status")
                        .HasColumnType("longtext")
                        .HasColumnName("status");

                    b.HasKey("UserId");

                    b.ToTable("doctors");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            Status = "available"
                        });
                });

            modelBuilder.Entity("assestment_JuaJoseZapata.Models.Patient", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("user_id");

                    b.HasKey("UserId");

                    b.ToTable("patients");

                    b.HasData(
                        new
                        {
                            UserId = 2
                        });
                });

            modelBuilder.Entity("assestment_JuaJoseZapata.Models.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("CreationDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("creation_date");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("name");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("update_date");

                    b.HasKey("Id");

                    b.ToTable("role");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreationDate = new DateTime(2024, 11, 15, 10, 35, 0, 475, DateTimeKind.Local).AddTicks(3366),
                            Name = "doctor"
                        },
                        new
                        {
                            Id = 2,
                            CreationDate = new DateTime(2024, 11, 15, 10, 35, 0, 475, DateTimeKind.Local).AddTicks(3408),
                            Name = "patient"
                        });
                });

            modelBuilder.Entity("assestment_JuaJoseZapata.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("CreationDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("creation_date");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("email");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("name");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("password");

                    b.Property<int>("RoleId")
                        .HasColumnType("int")
                        .HasColumnName("role_id");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("update_date");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreationDate = new DateTime(2024, 11, 15, 10, 35, 0, 594, DateTimeKind.Local).AddTicks(508),
                            Email = "zapata.devs@gmail.com",
                            Name = "Juan Jose",
                            Password = "$2a$11$vaS.10P3zWLE6Hd7z3vXEuuBFqp6C1loHTh0JMQQaDETM8qTzqiM.",
                            RoleId = 1
                        },
                        new
                        {
                            Id = 2,
                            CreationDate = new DateTime(2024, 11, 15, 10, 35, 0, 713, DateTimeKind.Local).AddTicks(1646),
                            Email = "user@example.com",
                            Name = "Test",
                            Password = "$2a$11$NC4PJbRi2wxYgOhN775JhO/xckWBdbrOJzWbe5Wsm47UqugCJ0XJO",
                            RoleId = 2
                        });
                });

            modelBuilder.Entity("assestment_JuaJoseZapata.Models.Doctor", b =>
                {
                    b.HasOne("assestment_JuaJoseZapata.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("assestment_JuaJoseZapata.Models.Patient", b =>
                {
                    b.HasOne("assestment_JuaJoseZapata.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("assestment_JuaJoseZapata.Models.User", b =>
                {
                    b.HasOne("assestment_JuaJoseZapata.Models.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });
#pragma warning restore 612, 618
        }
    }
}
