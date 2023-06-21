﻿// <auto-generated />
using System;
using KR.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace KR.Migrations
{
    [DbContext(typeof(SakilaDbContext))]
    partial class SakilaDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ActorFilm", b =>
                {
                    b.Property<int>("ActorsActorId")
                        .HasColumnType("int");

                    b.Property<int>("FilmsFilmId")
                        .HasColumnType("int");

                    b.HasKey("ActorsActorId", "FilmsFilmId");

                    b.HasIndex("FilmsFilmId");

                    b.ToTable("ActorFilm");
                });

            modelBuilder.Entity("CategoryFilm", b =>
                {
                    b.Property<int>("CategoriesCategoryId")
                        .HasColumnType("int");

                    b.Property<int>("FilmsFilmId")
                        .HasColumnType("int");

                    b.HasKey("CategoriesCategoryId", "FilmsFilmId");

                    b.HasIndex("FilmsFilmId");

                    b.ToTable("CategoryFilm");
                });

            modelBuilder.Entity("KR.Models.Actor", b =>
                {
                    b.Property<int>("ActorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("actor_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ActorId"));

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("first_name");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("last_name");

                    b.Property<DateTime>("LastUpdate")
                        .HasColumnType("datetime2")
                        .HasColumnName("last_update");

                    b.HasKey("ActorId");

                    b.ToTable("actor", null, t =>
                        {
                            t.ExcludeFromMigrations();
                        });
                });

            modelBuilder.Entity("KR.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("category_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"));

                    b.Property<DateTime>("LastUpdate")
                        .HasColumnType("datetime2")
                        .HasColumnName("last_update");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("name");

                    b.HasKey("CategoryId");

                    b.ToTable("category", null, t =>
                        {
                            t.ExcludeFromMigrations();
                        });
                });

            modelBuilder.Entity("KR.Models.Film", b =>
                {
                    b.Property<int>("FilmId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("film_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FilmId"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("description");

                    b.Property<int>("LanguageId")
                        .HasColumnType("int")
                        .HasColumnName("language_id");

                    b.Property<DateTime>("LastUpdate")
                        .HasColumnType("datetime2")
                        .HasColumnName("last_update");

                    b.Property<short>("Length")
                        .HasColumnType("smallint")
                        .HasColumnName("length");

                    b.Property<int?>("OriginalLanguageId")
                        .HasColumnType("int")
                        .HasColumnName("original_language_id");

                    b.Property<string>("Rating")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("rating");

                    b.Property<string>("ReleaseYear")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("release_year");

                    b.Property<byte>("RentalDuration")
                        .HasColumnType("tinyint")
                        .HasColumnName("rental_duration");

                    b.Property<decimal>("RentalRate")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("rental_rate");

                    b.Property<decimal>("ReplacementCost")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("replacement_cost");

                    b.Property<string>("SpecialFeatures")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("special_features");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("title");

                    b.HasKey("FilmId");

                    b.ToTable("film", null, t =>
                        {
                            t.ExcludeFromMigrations();
                        });
                });

            modelBuilder.Entity("KR.Models.FilmActor", b =>
                {
                    b.Property<int>("ActorId")
                        .HasColumnType("int")
                        .HasColumnName("actor_id");

                    b.Property<int>("FilmId")
                        .HasColumnType("int")
                        .HasColumnName("film_id");

                    b.Property<DateTime>("LastUpdate")
                        .HasColumnType("datetime2")
                        .HasColumnName("last_update");

                    b.HasIndex("ActorId");

                    b.HasIndex("FilmId");

                    b.ToTable("film_actor", null, t =>
                        {
                            t.ExcludeFromMigrations();
                        });
                });

            modelBuilder.Entity("KR.Models.FilmCategory", b =>
                {
                    b.Property<int>("CategoryId")
                        .HasColumnType("int")
                        .HasColumnName("category_id");

                    b.Property<int>("FilmId")
                        .HasColumnType("int")
                        .HasColumnName("film_id");

                    b.Property<DateTime>("LastUpdate")
                        .HasColumnType("datetime2")
                        .HasColumnName("last_update");

                    b.ToTable("film_category", null, t =>
                        {
                            t.ExcludeFromMigrations();
                        });
                });

            modelBuilder.Entity("KR.Models.Language", b =>
                {
                    b.Property<int>("LanguageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("language_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LanguageId"));

                    b.Property<DateTime>("LastUpdate")
                        .HasColumnType("datetime2")
                        .HasColumnName("last_update");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("name");

                    b.HasKey("LanguageId");

                    b.ToTable("language", null, t =>
                        {
                            t.ExcludeFromMigrations();
                        });
                });

            modelBuilder.Entity("ActorFilm", b =>
                {
                    b.HasOne("KR.Models.Actor", null)
                        .WithMany()
                        .HasForeignKey("ActorsActorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KR.Models.Film", null)
                        .WithMany()
                        .HasForeignKey("FilmsFilmId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CategoryFilm", b =>
                {
                    b.HasOne("KR.Models.Category", null)
                        .WithMany()
                        .HasForeignKey("CategoriesCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KR.Models.Film", null)
                        .WithMany()
                        .HasForeignKey("FilmsFilmId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("KR.Models.FilmActor", b =>
                {
                    b.HasOne("KR.Models.Actor", "Actor")
                        .WithMany()
                        .HasForeignKey("ActorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KR.Models.Film", "Film")
                        .WithMany()
                        .HasForeignKey("FilmId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Actor");

                    b.Navigation("Film");
                });
#pragma warning restore 612, 618
        }
    }
}
