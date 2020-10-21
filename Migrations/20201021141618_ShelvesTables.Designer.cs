﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ShelvesAndBooks.Data;

namespace ShelvesAndBooks.Migrations
{
    [DbContext(typeof(Connection))]
    [Migration("20201021141618_ShelvesTables")]
    partial class ShelvesTables
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ShelvesAndBooks.Models.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("varchar(60) CHARACTER SET utf8mb4")
                        .HasMaxLength(60);

                    b.Property<string>("Description")
                        .HasColumnType("varchar(1024) CHARACTER SET utf8mb4")
                        .HasMaxLength(1024);

                    b.Property<int>("ShelveId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4")
                        .HasMaxLength(255);

                    b.Property<string>("WriterName")
                        .IsRequired()
                        .HasColumnType("varchar(60) CHARACTER SET utf8mb4")
                        .HasMaxLength(60);

                    b.HasKey("Id");

                    b.HasIndex("ShelveId");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("ShelvesAndBooks.Models.Shelve", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("varchar(40) CHARACTER SET utf8mb4")
                        .HasMaxLength(40);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("varchar(250) CHARACTER SET utf8mb4")
                        .HasMaxLength(250);

                    b.HasKey("Id");

                    b.ToTable("Shelves");
                });

            modelBuilder.Entity("ShelvesAndBooks.Models.Book", b =>
                {
                    b.HasOne("ShelvesAndBooks.Models.Shelve", "Shelve")
                        .WithMany()
                        .HasForeignKey("ShelveId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
