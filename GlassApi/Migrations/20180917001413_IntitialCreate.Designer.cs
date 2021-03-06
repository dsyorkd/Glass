﻿// <auto-generated />
using GlassApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GlassApi.Migrations
{
    [DbContext(typeof(GlassDbContext))]
    [Migration("20180917001413_IntitialCreate")]
    partial class IntitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-preview2-35157");

            modelBuilder.Entity("GlassApi.Models.Sensor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<string>("Class");

                    b.Property<string>("HardwareId");

                    b.Property<string>("Manufacturer");

                    b.Property<string>("Name");

                    b.Property<string>("Serial");

                    b.Property<string>("Type");

                    b.HasKey("Id");

                    b.ToTable("Sensors");
                });
#pragma warning restore 612, 618
        }
    }
}
