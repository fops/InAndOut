// <auto-generated />
using System;
using InAndOut.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace InAndOut.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210830100927_personuri")]
    partial class personuri
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("InAndOut.Models.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Eesnimi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Isikukood")
                        .HasColumnType("int");

                    b.Property<string>("Lisainfo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Maksmine")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Perekonnanimi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UrituseIdId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UrituseIdId");

                    b.ToTable("Persons");
                });

            modelBuilder.Entity("InAndOut.Models.Yritused", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Aeg")
                        .HasColumnType("datetime2");

                    b.Property<string>("Place")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("YritusName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Yritused");
                });

            modelBuilder.Entity("InAndOut.Models.Person", b =>
                {
                    b.HasOne("InAndOut.Models.Yritused", "UrituseId")
                        .WithMany()
                        .HasForeignKey("UrituseIdId");

                    b.Navigation("UrituseId");
                });
#pragma warning restore 612, 618
        }
    }
}
