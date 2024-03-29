﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using app_adocao.Models;

#nullable disable

namespace app_adocao.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("app_adocao.Models.Adocao", b =>
                {
                    b.Property<int>("AdocaoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AdocaoId"));

                    b.Property<string>("Adotante")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime2");

                    b.Property<int?>("IdPet")
                        .HasColumnType("int");

                    b.Property<string>("ResponsavelLogin")
                        .HasColumnType("nvarchar(10)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("AdocaoId");

                    b.HasIndex("Adotante");

                    b.HasIndex("IdPet");

                    b.HasIndex("ResponsavelLogin");

                    b.ToTable("Adocao");
                });

            modelBuilder.Entity("app_adocao.Models.Pet", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Cor")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Dono")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Historico")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<int>("Sexo")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)");

                    b.HasKey("ID");

                    b.HasIndex("Dono");

                    b.ToTable("Pets");
                });

            modelBuilder.Entity("app_adocao.Models.Usuario", b =>
                {
                    b.Property<string>("Login")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("nvarchar(2)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Login");

                    b.ToTable("Usuarios");

                    b.UseTptMappingStrategy();
                });

            modelBuilder.Entity("app_adocao.Models.Requerente", b =>
                {
                    b.HasBaseType("app_adocao.Models.Usuario");

                    b.Property<string>("Raca")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)");

                    b.ToTable("Requerente");
                });

            modelBuilder.Entity("app_adocao.Models.Responsavel", b =>
                {
                    b.HasBaseType("app_adocao.Models.Usuario");

                    b.Property<string>("Contato")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.ToTable("Responsavel");
                });

            modelBuilder.Entity("app_adocao.Models.Adocao", b =>
                {
                    b.HasOne("app_adocao.Models.Requerente", "Requerente")
                        .WithMany("Adocoes")
                        .HasForeignKey("Adotante");

                    b.HasOne("app_adocao.Models.Pet", "Pet")
                        .WithMany()
                        .HasForeignKey("IdPet");

                    b.HasOne("app_adocao.Models.Responsavel", null)
                        .WithMany("Adocoes")
                        .HasForeignKey("ResponsavelLogin");

                    b.Navigation("Pet");

                    b.Navigation("Requerente");
                });

            modelBuilder.Entity("app_adocao.Models.Pet", b =>
                {
                    b.HasOne("app_adocao.Models.Responsavel", "Responsavel")
                        .WithMany("Pets")
                        .HasForeignKey("Dono");

                    b.Navigation("Responsavel");
                });

            modelBuilder.Entity("app_adocao.Models.Requerente", b =>
                {
                    b.HasOne("app_adocao.Models.Usuario", null)
                        .WithOne()
                        .HasForeignKey("app_adocao.Models.Requerente", "Login")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("app_adocao.Models.Responsavel", b =>
                {
                    b.HasOne("app_adocao.Models.Usuario", null)
                        .WithOne()
                        .HasForeignKey("app_adocao.Models.Responsavel", "Login")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("app_adocao.Models.Requerente", b =>
                {
                    b.Navigation("Adocoes");
                });

            modelBuilder.Entity("app_adocao.Models.Responsavel", b =>
                {
                    b.Navigation("Adocoes");

                    b.Navigation("Pets");
                });
#pragma warning restore 612, 618
        }
    }
}
