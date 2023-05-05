﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using PostgresSQL.API.DBContext;

#nullable disable

namespace PostgresSQL.API.Migrations
{
    [DbContext(typeof(EF_DataContext))]
    [Migration("20230505234153_InitialDatabase")]
    partial class InitialDatabase
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseSerialColumns(modelBuilder);

            modelBuilder.Entity("PostgresSQL.API.Model.Order", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("address")
                        .HasColumnType("text");

                    b.Property<DateTime>("createdon")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("name")
                        .HasColumnType("text");

                    b.Property<string>("phone")
                        .HasColumnType("text");

                    b.Property<Guid>("product_id")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("productid")
                        .HasColumnType("uuid");

                    b.HasKey("id");

                    b.HasIndex("productid");

                    b.ToTable("order");
                });

            modelBuilder.Entity("PostgresSQL.API.Model.Product", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("brand")
                        .HasColumnType("text");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<double?>("price")
                        .HasColumnType("double precision");

                    b.Property<string>("size")
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("product");
                });

            modelBuilder.Entity("PostgresSQL.API.Model.Order", b =>
                {
                    b.HasOne("PostgresSQL.API.Model.Product", "product")
                        .WithMany("orders")
                        .HasForeignKey("productid");

                    b.Navigation("product");
                });

            modelBuilder.Entity("PostgresSQL.API.Model.Product", b =>
                {
                    b.Navigation("orders");
                });
#pragma warning restore 612, 618
        }
    }
}