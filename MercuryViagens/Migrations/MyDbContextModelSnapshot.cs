﻿// <auto-generated />
using System;
using MercuryViagens.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MercuryViagens.Migrations
{
    [DbContext(typeof(MyDbContext))]
    partial class MyDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.26")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("MercuryViagens.Models.Destino", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("descricao");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("nome");

                    b.HasKey("Id");

                    b.ToTable("destino");
                });

            modelBuilder.Entity("MercuryViagens.Models.Imagem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<byte[]>("Conteudo")
                        .IsRequired()
                        .HasColumnType("longblob")
                        .HasColumnName("conteudo");

                    b.Property<int>("DestinoId")
                        .HasColumnType("int")
                        .HasColumnName("fk_destino_id");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("nome");

                    b.HasKey("Id");

                    b.HasIndex("DestinoId");

                    b.ToTable("imagem");
                });

            modelBuilder.Entity("MercuryViagens.Models.PacoteViagem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<DateTime>("DataIda")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("data_ida");

                    b.Property<DateTime>("DataVolta")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("data_volta");

                    b.Property<int>("DestinoId")
                        .HasColumnType("int")
                        .HasColumnName("fk_destino_id");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("nome");

                    b.Property<int>("NumMaxPrestacoes")
                        .HasColumnType("int")
                        .HasColumnName("num_max_prestacoes");

                    b.Property<double>("Preco")
                        .HasColumnType("double")
                        .HasColumnName("preco");

                    b.HasKey("Id");

                    b.HasIndex("DestinoId");

                    b.ToTable("pacoteviagem");
                });

            modelBuilder.Entity("MercuryViagens.Models.Imagem", b =>
                {
                    b.HasOne("MercuryViagens.Models.Destino", "Destino")
                        .WithMany()
                        .HasForeignKey("DestinoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Destino");
                });

            modelBuilder.Entity("MercuryViagens.Models.PacoteViagem", b =>
                {
                    b.HasOne("MercuryViagens.Models.Destino", "Destino")
                        .WithMany()
                        .HasForeignKey("DestinoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Destino");
                });
#pragma warning restore 612, 618
        }
    }
}
