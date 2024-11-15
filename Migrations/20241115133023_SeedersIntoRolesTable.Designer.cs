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
    [Migration("20241115133023_SeedersIntoRolesTable")]
    partial class SeedersIntoRolesTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

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
                            CreationDate = new DateTime(2024, 11, 15, 8, 30, 22, 877, DateTimeKind.Local).AddTicks(2022),
                            Name = "doctor"
                        },
                        new
                        {
                            Id = 2,
                            CreationDate = new DateTime(2024, 11, 15, 8, 30, 22, 877, DateTimeKind.Local).AddTicks(2054),
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