﻿// <auto-generated />
using System;
using Consumer.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Consumer.Repositories.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("Consumer.Domain.Entities.Electric", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("datePag");

                    b.Property<double>("kwConsumed");

                    b.Property<double>("mediaConsumed");

                    b.Property<DateTime>("readDate");

                    b.Property<int>("readNum");

                    b.Property<int?>("residenceid");

                    b.Property<double>("value");

                    b.HasKey("id");

                    b.HasIndex("residenceid");

                    b.ToTable("electrics");
                });

            modelBuilder.Entity("Consumer.Domain.Entities.Immobile", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("city");

                    b.Property<int>("identification");

                    b.Property<string>("nameOwner");

                    b.Property<DateTime>("neighborhood");

                    b.Property<DateTime>("number");

                    b.Property<double>("state");

                    b.HasKey("id");

                    b.ToTable("properties");
                });

            modelBuilder.Entity("Consumer.Domain.Entities.Electric", b =>
                {
                    b.HasOne("Consumer.Domain.Entities.Immobile", "residence")
                        .WithMany("electrics")
                        .HasForeignKey("residenceid");
                });
#pragma warning restore 612, 618
        }
    }
}
