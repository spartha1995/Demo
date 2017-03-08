using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Demo.Data;

namespace Demo.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20170308031918_Frirst")]
    partial class Frirst
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.0-rtm-22752")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Demo.Data.Catagory", b =>
                {
                    b.Property<int>("CatagoryId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CatagoryName")
                        .IsRequired()
                        .HasAnnotation("MaxLength", 150);

                    b.HasKey("CatagoryId");

                    b.ToTable("Catagorys");
                });
        }
    }
}
