﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MortalChicken.Context;

namespace MortalChicken.Migrations
{
    [DbContext(typeof(ChickenDbContext))]
    partial class ChickenDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.8")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MortalChicken.Models.Chicken", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<int>("Color")
                        .HasColumnType("int");

                    b.Property<int>("FarmId")
                        .HasColumnType("int");

                    b.Property<double>("Luck")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Smarts")
                        .HasColumnType("float");

                    b.Property<double>("Speed")
                        .HasColumnType("float");

                    b.Property<double>("Strength")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("FarmId");

                    b.ToTable("Chickens");
                });

            modelBuilder.Entity("MortalChicken.Models.Farm", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Seeds")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Farms");
                });

            modelBuilder.Entity("MortalChicken.Models.Chicken", b =>
                {
                    b.HasOne("MortalChicken.Models.Farm", null)
                        .WithMany("Chickens")
                        .HasForeignKey("FarmId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MortalChicken.Models.Farm", b =>
                {
                    b.Navigation("Chickens");
                });
#pragma warning restore 612, 618
        }
    }
}
