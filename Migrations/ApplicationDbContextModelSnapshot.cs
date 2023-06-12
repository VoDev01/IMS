﻿// <auto-generated />
using System;
using IMS.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace IMS.Migrations
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

            modelBuilder.Entity("CountryMoviePage", b =>
                {
                    b.Property<int>("CountriesId")
                        .HasColumnType("int");

                    b.Property<int>("MoviesPagesId")
                        .HasColumnType("int");

                    b.HasKey("CountriesId", "MoviesPagesId");

                    b.HasIndex("MoviesPagesId");

                    b.ToTable("CountryMoviePage");
                });

            modelBuilder.Entity("CountryMoviePageItem", b =>
                {
                    b.Property<int>("CountriesId")
                        .HasColumnType("int");

                    b.Property<int>("MoviePageItemsId")
                        .HasColumnType("int");

                    b.HasKey("CountriesId", "MoviePageItemsId");

                    b.HasIndex("MoviePageItemsId");

                    b.ToTable("CountryMoviePageItem");
                });

            modelBuilder.Entity("GenreMoviePage", b =>
                {
                    b.Property<int>("GenresId")
                        .HasColumnType("int");

                    b.Property<int>("MoviesPagesId")
                        .HasColumnType("int");

                    b.HasKey("GenresId", "MoviesPagesId");

                    b.HasIndex("MoviesPagesId");

                    b.ToTable("GenreMoviePage");
                });

            modelBuilder.Entity("GenreMoviePageItem", b =>
                {
                    b.Property<int>("GenresId")
                        .HasColumnType("int");

                    b.Property<int>("MoviePageItemsId")
                        .HasColumnType("int");

                    b.HasKey("GenresId", "MoviePageItemsId");

                    b.HasIndex("MoviePageItemsId");

                    b.ToTable("GenreMoviePageItem");
                });

            modelBuilder.Entity("IMS.Models.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(75)
                        .HasColumnType("nvarchar(75)");

                    b.HasKey("Id");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("IMS.Models.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.HasKey("Id");

                    b.ToTable("Genres");
                });

            modelBuilder.Entity("IMS.Models.MoviePage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CoverUrl")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("Description")
                        .HasMaxLength(2000)
                        .HasColumnType("nvarchar(2000)");

                    b.Property<string>("EditorAnnotation")
                        .HasMaxLength(75)
                        .HasColumnType("nvarchar(75)");

                    b.Property<int?>("EndYear")
                        .HasColumnType("int");

                    b.Property<int?>("FilmLenght")
                        .HasColumnType("int");

                    b.Property<string>("ImdbId")
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<int>("KinopoiskId")
                        .HasColumnType("int");

                    b.Property<string>("LastSync")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("NameEn")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("NameRu")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PosterUrl")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("PosterUrlPreview")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("ProductionStatus")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("RatingAgeLimits")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<float?>("RatingImdb")
                        .HasColumnType("real");

                    b.Property<int?>("RatingImdbVoteCount")
                        .HasColumnType("int");

                    b.Property<float?>("RatingKinopoisk")
                        .HasColumnType("real");

                    b.Property<int?>("RatingKinopoiskVoteCount")
                        .HasColumnType("int");

                    b.Property<int>("ReviewsCount")
                        .HasColumnType("int");

                    b.Property<string>("ShortDescription")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Slogan")
                        .HasMaxLength(75)
                        .HasColumnType("nvarchar(75)");

                    b.Property<int?>("StartYear")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("WebUrl")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<int?>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("MoviesPages");
                });

            modelBuilder.Entity("IMS.Models.MoviePageItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ImdbId")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("KinopoiskId")
                        .HasColumnType("int");

                    b.Property<string>("NameEn")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("NameOriginal")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("NameRu")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("PageIndex")
                        .HasColumnType("int");

                    b.Property<string>("PosterUrl")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("PosterUrlPreview")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<float?>("RatingImdb")
                        .HasColumnType("real");

                    b.Property<float?>("RatingKinopoisk")
                        .HasColumnType("real");

                    b.Property<string>("Type")
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<int?>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("MoviePageItems");
                });

            modelBuilder.Entity("IMS.Models.Rating", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.Property<string>("RatingComment")
                        .HasMaxLength(10000)
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RatingNum")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MovieId");

                    b.HasIndex("UserId");

                    b.ToTable("Ratings");
                });

            modelBuilder.Entity("IMS.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(35)
                        .HasColumnType("nvarchar(35)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("NickName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<byte[]>("ProfilePicture")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Surname")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("UserUrlId")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("CountryMoviePage", b =>
                {
                    b.HasOne("IMS.Models.Country", null)
                        .WithMany()
                        .HasForeignKey("CountriesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("IMS.Models.MoviePage", null)
                        .WithMany()
                        .HasForeignKey("MoviesPagesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CountryMoviePageItem", b =>
                {
                    b.HasOne("IMS.Models.Country", null)
                        .WithMany()
                        .HasForeignKey("CountriesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("IMS.Models.MoviePageItem", null)
                        .WithMany()
                        .HasForeignKey("MoviePageItemsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GenreMoviePage", b =>
                {
                    b.HasOne("IMS.Models.Genre", null)
                        .WithMany()
                        .HasForeignKey("GenresId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("IMS.Models.MoviePage", null)
                        .WithMany()
                        .HasForeignKey("MoviesPagesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GenreMoviePageItem", b =>
                {
                    b.HasOne("IMS.Models.Genre", null)
                        .WithMany()
                        .HasForeignKey("GenresId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("IMS.Models.MoviePageItem", null)
                        .WithMany()
                        .HasForeignKey("MoviePageItemsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("IMS.Models.Rating", b =>
                {
                    b.HasOne("IMS.Models.MoviePage", "Movie")
                        .WithMany("Ratings")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("IMS.Models.User", "User")
                        .WithMany("MoviesRatings")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Movie");

                    b.Navigation("User");
                });

            modelBuilder.Entity("IMS.Models.User", b =>
                {
                    b.HasOne("IMS.Models.Country", "Country")
                        .WithMany()
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("IMS.Models.MoviePage", b =>
                {
                    b.Navigation("Ratings");
                });

            modelBuilder.Entity("IMS.Models.User", b =>
                {
                    b.Navigation("MoviesRatings");
                });
#pragma warning restore 612, 618
        }
    }
}
