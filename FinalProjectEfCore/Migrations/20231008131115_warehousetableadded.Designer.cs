﻿// <auto-generated />
using System;
using FinalProjectEfCore.DataSource;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FinalProjectEfCore.Migrations
{
    [DbContext(typeof(LoadDb))]
    [Migration("20231008131115_warehousetableadded")]
    partial class warehousetableadded
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.32")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FinalProjectEfCore.model.Client", b =>
                {
                    b.Property<int>("Client_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Client_EMail")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("Client_Fax")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Client_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("Client_Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Client_Website_Url")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Company_fk")
                        .HasColumnType("int");

                    b.HasKey("Client_Id");

                    b.HasIndex("Company_fk");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("FinalProjectEfCore.model.Company", b =>
                {
                    b.Property<int>("Company_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Company_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.HasKey("Company_Id");

                    b.ToTable("Company");
                });

            modelBuilder.Entity("FinalProjectEfCore.model.Login", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("login");
                });

            modelBuilder.Entity("FinalProjectEfCore.model.Product", b =>
                {
                    b.Property<int>("Product_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Product_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<int?>("UnitOfMesurement_Id")
                        .HasColumnType("int");

                    b.Property<int>("WareHouse_fk")
                        .HasColumnType("int");

                    b.HasKey("Product_Id");

                    b.HasIndex("UnitOfMesurement_Id");

                    b.HasIndex("WareHouse_fk");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("FinalProjectEfCore.model.ProductUnit", b =>
                {
                    b.Property<int>("Product_Id")
                        .HasColumnType("int");

                    b.Property<int>("UnitOfMesurement_Id")
                        .HasColumnType("int");

                    b.HasKey("Product_Id", "UnitOfMesurement_Id");

                    b.HasIndex("UnitOfMesurement_Id");

                    b.ToTable("ProductUnit");
                });

            modelBuilder.Entity("FinalProjectEfCore.model.Supplier", b =>
                {
                    b.Property<int>("Supplier_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Company_fk")
                        .HasColumnType("int");

                    b.Property<string>("Supplier_EMail")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("Supplier_Fax")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Supplier_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("Supplier_Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Supplier_Website_Url")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Supplier_Id");

                    b.HasIndex("Company_fk");

                    b.ToTable("Suppliers");
                });

            modelBuilder.Entity("FinalProjectEfCore.model.UnitOfMesurement", b =>
                {
                    b.Property<int>("UnitOfMesurement_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("UnitOfMesurement_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.HasKey("UnitOfMesurement_Id");

                    b.ToTable("UnitOfMesurement");
                });

            modelBuilder.Entity("FinalProjectEfCore.model.WareHouse", b =>
                {
                    b.Property<int>("WareHouse_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Company_fk")
                        .HasColumnType("int");

                    b.Property<string>("WareHouse_Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("WareHouse_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.HasKey("WareHouse_Id");

                    b.HasIndex("Company_fk");

                    b.ToTable("wareHouses");
                });

            modelBuilder.Entity("FinalProjectEfCore.model.Client", b =>
                {
                    b.HasOne("FinalProjectEfCore.model.Company", "Company")
                        .WithMany("Clients")
                        .HasForeignKey("Company_fk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FinalProjectEfCore.model.Product", b =>
                {
                    b.HasOne("FinalProjectEfCore.model.UnitOfMesurement", null)
                        .WithMany("Products")
                        .HasForeignKey("UnitOfMesurement_Id");

                    b.HasOne("FinalProjectEfCore.model.WareHouse", "WareHouse")
                        .WithMany("Products")
                        .HasForeignKey("WareHouse_fk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FinalProjectEfCore.model.ProductUnit", b =>
                {
                    b.HasOne("FinalProjectEfCore.model.Product", "Product")
                        .WithMany("productUnits")
                        .HasForeignKey("Product_Id")
                        .IsRequired();

                    b.HasOne("FinalProjectEfCore.model.UnitOfMesurement", "UnitOfMesurement")
                        .WithMany("productUnits")
                        .HasForeignKey("UnitOfMesurement_Id")
                        .IsRequired();
                });

            modelBuilder.Entity("FinalProjectEfCore.model.Supplier", b =>
                {
                    b.HasOne("FinalProjectEfCore.model.Company", "Company")
                        .WithMany("Suppliers")
                        .HasForeignKey("Company_fk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FinalProjectEfCore.model.WareHouse", b =>
                {
                    b.HasOne("FinalProjectEfCore.model.Company", "Company")
                        .WithMany("WareHouse")
                        .HasForeignKey("Company_fk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
