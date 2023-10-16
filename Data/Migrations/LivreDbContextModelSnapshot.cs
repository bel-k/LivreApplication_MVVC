﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using appPageRazor.Data;

#nullable disable

namespace appPageRazor.Data.Migrations
{
    [DbContext(typeof(LivreDbContext))]
    partial class LivreDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.11");

            modelBuilder.Entity("appPageRazor.Models.Livre", b =>
                {
                    b.Property<string>("ISBN")
                        .HasColumnType("TEXT");

                    b.Property<int>("Category")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Img")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("autor")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("createdAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ISBN");

                    b.ToTable("Livres");
                });
#pragma warning restore 612, 618
        }
    }
}
