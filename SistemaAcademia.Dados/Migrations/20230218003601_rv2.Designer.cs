﻿// <auto-generated />
using System;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

using SistemaAcademia.Dados;

#nullable disable

namespace SistemaAcademia.Dados.Migrations
{
    [DbContext(typeof(SistemaAcademiaDbContext))]
    [Migration("20230218003601_rv2")]
    partial class rv2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SistemaAcademia.Dados.Entidades.Aluno", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Bairro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CEP")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cidade")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Complemento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DataNascimento")
                        .HasColumnType("datetime2");

                    b.Property<string>("EstadoUF")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Logradouro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeCompleto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Alunos");
                });

            modelBuilder.Entity("SistemaAcademia.Dados.Entidades.AlunoTelefone", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<long>("AlunoId")
                        .HasColumnType("bigint");

                    b.Property<string>("DDD")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PossuiWhatsApp")
                        .HasColumnType("bit");

                    b.Property<int>("Tipo")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AlunoId");

                    b.ToTable("AlunosTelefones");
                });

            modelBuilder.Entity("SistemaAcademia.Dados.Entidades.Exercicio", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Exercicios");
                });

            modelBuilder.Entity("SistemaAcademia.Dados.Entidades.Treino", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<long>("AlunoId")
                        .HasColumnType("bigint");

                    b.Property<long>("NumeroAtualTreino")
                        .HasColumnType("bigint");

                    b.Property<long>("NumeroMaximoTreino")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("AlunoId");

                    b.ToTable("Treino");
                });

            modelBuilder.Entity("SistemaAcademia.Dados.Entidades.TreinoExercicio", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<long>("ExercicioId")
                        .HasColumnType("bigint");

                    b.Property<long>("NumeroRepeticoes")
                        .HasColumnType("bigint");

                    b.Property<long>("NumeroSeries")
                        .HasColumnType("bigint");

                    b.Property<long>("TreinoId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("ExercicioId");

                    b.HasIndex("TreinoId");

                    b.ToTable("TreinosExercicios");
                });

            modelBuilder.Entity("SistemaAcademia.Dados.Entidades.TreinoHistorico", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<long>("AlunoId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime2");

                    b.Property<long>("ProximoTreinoId")
                        .HasColumnType("bigint");

                    b.Property<long>("UltimoTreinoId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("AlunoId");

                    b.HasIndex("ProximoTreinoId");

                    b.HasIndex("UltimoTreinoId");

                    b.ToTable("TreinosHistoricos");
                });

            modelBuilder.Entity("SistemaAcademia.Dados.Entidades.AlunoTelefone", b =>
                {
                    b.HasOne("SistemaAcademia.Dados.Entidades.Aluno", "Aluno")
                        .WithMany("Telefones")
                        .HasForeignKey("AlunoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Aluno");
                });

            modelBuilder.Entity("SistemaAcademia.Dados.Entidades.Treino", b =>
                {
                    b.HasOne("SistemaAcademia.Dados.Entidades.Aluno", "Aluno")
                        .WithMany("Treinos")
                        .HasForeignKey("AlunoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Aluno");
                });

            modelBuilder.Entity("SistemaAcademia.Dados.Entidades.TreinoExercicio", b =>
                {
                    b.HasOne("SistemaAcademia.Dados.Entidades.Exercicio", "Exercicio")
                        .WithMany("Treinos")
                        .HasForeignKey("ExercicioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SistemaAcademia.Dados.Entidades.Treino", "Treino")
                        .WithMany("Treinos")
                        .HasForeignKey("TreinoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Exercicio");

                    b.Navigation("Treino");
                });

            modelBuilder.Entity("SistemaAcademia.Dados.Entidades.TreinoHistorico", b =>
                {
                    b.HasOne("SistemaAcademia.Dados.Entidades.Aluno", "Aluno")
                        .WithMany("HistoricosTreinos")
                        .HasForeignKey("AlunoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SistemaAcademia.Dados.Entidades.Treino", "ProximoTreino")
                        .WithMany("HistoricosProximosTreinos")
                        .HasForeignKey("ProximoTreinoId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("SistemaAcademia.Dados.Entidades.Treino", "UltimoTreino")
                        .WithMany("HistoricosUltimosTreinos")
                        .HasForeignKey("UltimoTreinoId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Aluno");

                    b.Navigation("ProximoTreino");

                    b.Navigation("UltimoTreino");
                });

            modelBuilder.Entity("SistemaAcademia.Dados.Entidades.Aluno", b =>
                {
                    b.Navigation("HistoricosTreinos");

                    b.Navigation("Telefones");

                    b.Navigation("Treinos");
                });

            modelBuilder.Entity("SistemaAcademia.Dados.Entidades.Exercicio", b =>
                {
                    b.Navigation("Treinos");
                });

            modelBuilder.Entity("SistemaAcademia.Dados.Entidades.Treino", b =>
                {
                    b.Navigation("HistoricosProximosTreinos");

                    b.Navigation("HistoricosUltimosTreinos");

                    b.Navigation("Treinos");
                });
#pragma warning restore 612, 618
        }
    }
}
