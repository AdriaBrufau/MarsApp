﻿// <auto-generated />
using MarsApp;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MarsApp.Migrations
{
    [DbContext(typeof(MarsAppDbContext))]
    [Migration("20220508161406_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("MarsApp.Entities.MapSizeEntity", b =>
                {
                    b.Property<int>("MapID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MapID"), 1L, 1);

                    b.Property<int>("X_Axis")
                        .HasColumnType("int");

                    b.Property<int>("Y_Axis")
                        .HasColumnType("int");

                    b.HasKey("MapID");

                    b.ToTable("Maps");

                    b.HasData(
                        new
                        {
                            MapID = 1,
                            X_Axis = 3,
                            Y_Axis = 4
                        });
                });

            modelBuilder.Entity("MarsApp.Entities.RoverEntity", b =>
                {
                    b.Property<int>("RoverID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RoverID"), 1L, 1);

                    b.Property<int>("Compass")
                        .HasColumnType("int");

                    b.Property<bool>("IsAlive")
                        .HasColumnType("bit");

                    b.Property<int>("Or_Grade")
                        .HasColumnType("int");

                    b.Property<string>("Order")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("X_Position")
                        .HasColumnType("int");

                    b.Property<int>("Y_Position")
                        .HasColumnType("int");

                    b.HasKey("RoverID");

                    b.ToTable("Rovers");

                    b.HasData(
                        new
                        {
                            RoverID = 1,
                            Compass = 0,
                            IsAlive = true,
                            Or_Grade = 0,
                            Order = "",
                            X_Position = 0,
                            Y_Position = 0
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
