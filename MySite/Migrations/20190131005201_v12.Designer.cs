﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MySite.Data;

namespace MySite.Migrations
{
    [DbContext(typeof(DbProductsAndGroupsContext))]
    [Migration("20190131005201_v12")]
    partial class v12
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("MySite.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Discription");

                    b.Property<int>("ImageId");

                    b.Property<string>("Title")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("categories");
                });

            modelBuilder.Entity("MySite.Models.GropsAndProducts", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("GroupId");

                    b.Property<int?>("GroupsId");

                    b.Property<int>("ProductId");

                    b.HasKey("Id");

                    b.HasIndex("GroupsId");

                    b.ToTable("gropsAndProducts");
                });

            modelBuilder.Entity("MySite.Models.Groups", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CategoryId");

                    b.Property<string>("Discription")
                        .IsRequired();

                    b.Property<string>("Title")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("groups");
                });

            modelBuilder.Entity("MySite.Models.Images", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ImageName");

                    b.Property<int>("ImageSize");

                    b.Property<string>("ImageType");

                    b.Property<int>("ProductId");

                    b.HasKey("Id");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("MySite.Models.Products", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Count");

                    b.Property<int>("Discount");

                    b.Property<string>("Discription");

                    b.Property<int>("ImageId");

                    b.Property<int>("Price");

                    b.Property<string>("Title")
                        .IsRequired();

                    b.Property<string>("Unit")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("products");
                });

            modelBuilder.Entity("MySite.Models.GropsAndProducts", b =>
                {
                    b.HasOne("MySite.Models.Groups")
                        .WithMany("groupAndProducts")
                        .HasForeignKey("GroupsId");
                });
#pragma warning restore 612, 618
        }
    }
}
