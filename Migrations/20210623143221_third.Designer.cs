﻿// <auto-generated />
using System;
using DeliveryBookingAPI.DataLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DeliveryBookingAPI.Migrations
{
    [DbContext(typeof(DeliveryBookingAPIContext))]
    [Migration("20210623143221_third")]
    partial class third
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DeliveryBookingAPI.ModelLayer.City", b =>
                {
                    b.Property<int>("CityID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CityName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("CityID");

                    b.ToTable("City");
                });

            modelBuilder.Entity("DeliveryBookingAPI.ModelLayer.EResponse", b =>
                {
                    b.Property<int>("ResponseID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("RequestID")
                        .HasColumnType("int");

                    b.Property<bool>("status")
                        .HasColumnType("bit");

                    b.HasKey("ResponseID");

                    b.ToTable("EResponse");
                });

            modelBuilder.Entity("DeliveryBookingAPI.ModelLayer.ExecutiveDetail", b =>
                {
                    b.Property<int>("ExecutiveID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<int>("CityID")
                        .HasColumnType("int");

                    b.Property<bool>("IsVerified")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("ExecutiveID");

                    b.HasIndex("CityID");

                    b.ToTable("ExecutiveDetail");
                });

            modelBuilder.Entity("DeliveryBookingAPI.ModelLayer.UserDetail", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<int>("CityID")
                        .HasColumnType("int");

                    b.Property<bool>("IsVerified")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("UserID");

                    b.HasIndex("CityID");

                    b.ToTable("UserDetail");
                });

            modelBuilder.Entity("DeliveryBookingAPI.ModelLayer.UserRequest", b =>
                {
                    b.Property<int>("RequestID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int?>("CityID")
                        .HasColumnType("int");

                    b.Property<DateTime>("DTofPickup")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ExecutiveID")
                        .HasColumnType("int");

                    b.Property<int?>("UserID")
                        .HasColumnType("int");

                    b.Property<double>("WeightOfPackage")
                        .HasColumnType("float");

                    b.HasKey("RequestID");

                    b.HasIndex("CityID");

                    b.HasIndex("ExecutiveID");

                    b.HasIndex("UserID");

                    b.ToTable("UserRequest");
                });

            modelBuilder.Entity("DeliveryBookingAPI.ModelLayer.ExecutiveDetail", b =>
                {
                    b.HasOne("DeliveryBookingAPI.ModelLayer.City", "City")
                        .WithMany()
                        .HasForeignKey("CityID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");
                });

            modelBuilder.Entity("DeliveryBookingAPI.ModelLayer.UserDetail", b =>
                {
                    b.HasOne("DeliveryBookingAPI.ModelLayer.City", "City")
                        .WithMany()
                        .HasForeignKey("CityID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");
                });

            modelBuilder.Entity("DeliveryBookingAPI.ModelLayer.UserRequest", b =>
                {
                    b.HasOne("DeliveryBookingAPI.ModelLayer.City", "City")
                        .WithMany()
                        .HasForeignKey("CityID");

                    b.HasOne("DeliveryBookingAPI.ModelLayer.ExecutiveDetail", "ExecutiveDetail")
                        .WithMany()
                        .HasForeignKey("ExecutiveID");

                    b.HasOne("DeliveryBookingAPI.ModelLayer.UserDetail", "UserDetail")
                        .WithMany()
                        .HasForeignKey("UserID");

                    b.Navigation("City");

                    b.Navigation("ExecutiveDetail");

                    b.Navigation("UserDetail");
                });
#pragma warning restore 612, 618
        }
    }
}
