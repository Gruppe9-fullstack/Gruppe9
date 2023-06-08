﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Gruppe9.Migrations
{
    [DbContext(typeof(BokContext))]
    [Migration("20230608151105_UpdateBokSchema")]
    partial class UpdateBokSchema
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.5");

            modelBuilder.Entity("Gruppe9.Models.Bok", b =>
                {
                    b.Property<string>("ISBN")
                        .HasColumnType("TEXT");

                    b.Property<int>("AntallSider")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Forfatter")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Forlag")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Tittel")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("UtgittÅr")
                        .HasColumnType("INTEGER");

                    b.HasKey("ISBN");

                    b.ToTable("Bok");
                });
#pragma warning restore 612, 618
        }
    }
}
