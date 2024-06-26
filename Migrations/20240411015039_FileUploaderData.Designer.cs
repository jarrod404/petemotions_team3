﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PetEmotionsApp.Data;

#nullable disable

namespace PetEmotionsApp.Migrations
{
    [DbContext(typeof(PetEmotionsAppContext))]
    [Migration("20240411015039_FileUploaderData")]
    partial class FileUploaderData
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.2");

            modelBuilder.Entity("PetEmotionsApp.Models.FileUpload", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<byte[]>("FileContent")
                        .IsRequired()
                        .HasColumnType("BLOB");

                    b.Property<string>("emotion")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("fileDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("type")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("FileUpload");
                });
#pragma warning restore 612, 618
        }
    }
}
