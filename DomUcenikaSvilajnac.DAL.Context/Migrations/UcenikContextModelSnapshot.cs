﻿// <auto-generated />
using DomUcenikaSvilajnac.DAL.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace DomUcenikaSvilajnac.DAL.Context.Migrations
{
    [DbContext(typeof(UcenikContext))]
    partial class UcenikContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DomUcenikaSvilajnac.Common.Models.Ucenik", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Ime");

                    b.HasKey("Id");

                    b.ToTable("Ucenici");
                });
#pragma warning restore 612, 618
        }
    }
}
