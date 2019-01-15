﻿// <auto-generated />
using CityInfo.API.ResourceManipulation.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace CityInfo.API.ResourceManipulation.Migrations
{
    [DbContext(typeof(CityInfoContext))]
    [Migration("20190115095016_CityInfoDbPointOfInterset")]
    partial class CityInfoDbPointOfInterset
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CityInfo.API.ResourceManipulation.Entities.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("CityInfo.API.ResourceManipulation.Entities.PointOfInterest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CityId");

                    b.Property<string>("Description");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("PointsOfInterest");
                });

            modelBuilder.Entity("CityInfo.API.ResourceManipulation.Entities.PointOfInterest", b =>
                {
                    b.HasOne("CityInfo.API.ResourceManipulation.Entities.City", "City")
                        .WithMany("PointsOfInterest")
                        .HasForeignKey("CityId");
                });
#pragma warning restore 612, 618
        }
    }
}
