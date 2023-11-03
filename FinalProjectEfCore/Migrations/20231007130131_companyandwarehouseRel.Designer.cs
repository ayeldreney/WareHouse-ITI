﻿// <auto-generated />
using FinalProjectEfCore.DataSource;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FinalProjectEfCore.Migrations
{
    [DbContext(typeof(LoadDb))]
    [Migration("20231007130131_companyandwarehouseRel")]
    partial class companyandwarehouseRel
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.32")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FinalProjectEfCore.model.Company", b =>
                {
                    b.Property<int>("Company_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Company_Name")
                        .HasColumnType("nvarchar(max)");

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

            modelBuilder.Entity("FinalProjectEfCore.model.WareHouse", b =>
                {
                    b.Property<int>("WareHouse_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Company_fk")
                        .HasColumnType("int");

                    b.Property<string>("WareHouse_Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WareHouse_Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("WareHouse_Id");

                    b.HasIndex("Company_fk");

                    b.ToTable("WareHouse");
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
