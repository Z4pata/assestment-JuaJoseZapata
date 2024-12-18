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
    [Migration("20241115151017_SeedDataToDoctorsTable")]
    partial class SeedDataToDoctorsTable
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

                    b.Property<int?>("Status")
                        .HasColumnType("int")
                        .HasColumnName("status");

                    b.HasKey("UserId");

                    b.ToTable("doctors");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            Status = 0
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
                            CreationDate = new DateTime(2024, 11, 15, 10, 10, 16, 743, DateTimeKind.Local).AddTicks(3266),
                            Name = "doctor"
                        },
                        new
                        {
                            Id = 2,
                            CreationDate = new DateTime(2024, 11, 15, 10, 10, 16, 743, DateTimeKind.Local).AddTicks(3307),
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
                            CreationDate = new DateTime(2024, 11, 15, 10, 10, 16, 863, DateTimeKind.Local).AddTicks(83),
                            Email = "zapata.devs@gmail.com",
                            Name = "Juan Jose",
                            Password = "$2a$11$jDoL1Iy2QoNC8oWno98W..Cjqj8Yg4OS3QBw/PsaoPLm4CcTlZ9Oi",
                            RoleId = 1
                        },
                        new
                        {
                            Id = 2,
                            CreationDate = new DateTime(2024, 11, 15, 10, 10, 16, 983, DateTimeKind.Local).AddTicks(6223),
                            Email = "user@example.com",
                            Name = "Test",
                            Password = "$2a$11$koC9CJomS.oO90vEPgt91ukCCsCqIaRuoxLe6Nwh9CKsV7GSOpUGS",
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
