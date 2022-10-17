﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Sport.Data;

#nullable disable

namespace Sport.Migrations
{
    [DbContext(typeof(SportContext))]
    partial class SportContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.10");

            modelBuilder.Entity("CoachGame", b =>
                {
                    b.Property<int>("CoachesCoachID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("GamesGameId")
                        .HasColumnType("INTEGER");

                    b.HasKey("CoachesCoachID", "GamesGameId");

                    b.HasIndex("GamesGameId");

                    b.ToTable("CoachGame");
                });

            modelBuilder.Entity("CoachTeam", b =>
                {
                    b.Property<int>("CoachID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TeamsTeamId")
                        .HasColumnType("INTEGER");

                    b.HasKey("CoachID", "TeamsTeamId");

                    b.HasIndex("TeamsTeamId");

                    b.ToTable("CoachTeam");
                });

            modelBuilder.Entity("CoachTraining", b =>
                {
                    b.Property<int>("CoachID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TrainingId")
                        .HasColumnType("INTEGER");

                    b.HasKey("CoachID", "TrainingId");

                    b.HasIndex("TrainingId");

                    b.ToTable("CoachTraining");
                });

            modelBuilder.Entity("GamePlayer", b =>
                {
                    b.Property<int>("GamesGameId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PlayersPlayerID")
                        .HasColumnType("INTEGER");

                    b.HasKey("GamesGameId", "PlayersPlayerID");

                    b.HasIndex("PlayersPlayerID");

                    b.ToTable("GamePlayer");
                });

            modelBuilder.Entity("PlayerTeam", b =>
                {
                    b.Property<int>("PlayersPlayerID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TeamsTeamId")
                        .HasColumnType("INTEGER");

                    b.HasKey("PlayersPlayerID", "TeamsTeamId");

                    b.HasIndex("TeamsTeamId");

                    b.ToTable("PlayerTeam");
                });

            modelBuilder.Entity("PlayerTraining", b =>
                {
                    b.Property<int>("PlayerID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TrainingId")
                        .HasColumnType("INTEGER");

                    b.HasKey("PlayerID", "TrainingId");

                    b.HasIndex("TrainingId");

                    b.ToTable("PlayerTraining");
                });

            modelBuilder.Entity("Sport.Models.Adress", b =>
                {
                    b.Property<int>("AdressId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("StreetNumber")
                        .HasColumnType("INTEGER");

                    b.Property<string>("StreetNumberAddition")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Zipcode")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("AdressId");

                    b.ToTable("Adress");
                });

            modelBuilder.Entity("Sport.Models.Club", b =>
                {
                    b.Property<int>("ClubId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Active")
                        .HasColumnType("TEXT");

                    b.Property<int?>("AdressId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ClubId");

                    b.HasIndex("AdressId");

                    b.ToTable("Clubs");
                });

            modelBuilder.Entity("Sport.Models.Coach", b =>
                {
                    b.Property<int>("CoachID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Active")
                        .HasColumnType("TEXT");

                    b.Property<DateOnly?>("BirthDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("CoachID");

                    b.ToTable("Coach");
                });

            modelBuilder.Entity("Sport.Models.Game", b =>
                {
                    b.Property<int>("GameId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<TimeSpan>("Duration")
                        .HasColumnType("TEXT");

                    b.Property<int>("GuestTeamTeamId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("HomeTeamTeamId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Innings")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ScoreId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("StartTime")
                        .HasColumnType("TEXT");

                    b.HasKey("GameId");

                    b.HasIndex("GuestTeamTeamId");

                    b.HasIndex("HomeTeamTeamId");

                    b.HasIndex("ScoreId");

                    b.ToTable("Games");
                });

            modelBuilder.Entity("Sport.Models.Player", b =>
                {
                    b.Property<int>("PlayerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Active")
                        .HasColumnType("TEXT");

                    b.Property<DateOnly?>("BirthDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("PlayerNumber")
                        .HasColumnType("INTEGER");

                    b.HasKey("PlayerID");

                    b.ToTable("Player");
                });

            modelBuilder.Entity("Sport.Models.Score", b =>
                {
                    b.Property<int>("ScoreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("GuestPoints")
                        .HasColumnType("INTEGER");

                    b.Property<int>("HomePoints")
                        .HasColumnType("INTEGER");

                    b.HasKey("ScoreId");

                    b.ToTable("Score");
                });

            modelBuilder.Entity("Sport.Models.Team", b =>
                {
                    b.Property<int>("TeamId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Active")
                        .HasColumnType("TEXT");

                    b.Property<int?>("ClubId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("TeamName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("TeamId");

                    b.HasIndex("ClubId");

                    b.ToTable("Team");
                });

            modelBuilder.Entity("Sport.Models.Training", b =>
                {
                    b.Property<int>("TrainingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Datum")
                        .HasColumnType("TEXT");

                    b.Property<int?>("TeamId")
                        .HasColumnType("INTEGER");

                    b.HasKey("TrainingId");

                    b.HasIndex("TeamId");

                    b.ToTable("Training");
                });

            modelBuilder.Entity("CoachGame", b =>
                {
                    b.HasOne("Sport.Models.Coach", null)
                        .WithMany()
                        .HasForeignKey("CoachesCoachID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Sport.Models.Game", null)
                        .WithMany()
                        .HasForeignKey("GamesGameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CoachTeam", b =>
                {
                    b.HasOne("Sport.Models.Coach", null)
                        .WithMany()
                        .HasForeignKey("CoachID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Sport.Models.Team", null)
                        .WithMany()
                        .HasForeignKey("TeamsTeamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CoachTraining", b =>
                {
                    b.HasOne("Sport.Models.Coach", null)
                        .WithMany()
                        .HasForeignKey("CoachID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Sport.Models.Training", null)
                        .WithMany()
                        .HasForeignKey("TrainingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GamePlayer", b =>
                {
                    b.HasOne("Sport.Models.Game", null)
                        .WithMany()
                        .HasForeignKey("GamesGameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Sport.Models.Player", null)
                        .WithMany()
                        .HasForeignKey("PlayersPlayerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PlayerTeam", b =>
                {
                    b.HasOne("Sport.Models.Player", null)
                        .WithMany()
                        .HasForeignKey("PlayersPlayerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Sport.Models.Team", null)
                        .WithMany()
                        .HasForeignKey("TeamsTeamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PlayerTraining", b =>
                {
                    b.HasOne("Sport.Models.Player", null)
                        .WithMany()
                        .HasForeignKey("PlayerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Sport.Models.Training", null)
                        .WithMany()
                        .HasForeignKey("TrainingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Sport.Models.Club", b =>
                {
                    b.HasOne("Sport.Models.Adress", "Adress")
                        .WithMany()
                        .HasForeignKey("AdressId");

                    b.Navigation("Adress");
                });

            modelBuilder.Entity("Sport.Models.Game", b =>
                {
                    b.HasOne("Sport.Models.Team", "GuestTeam")
                        .WithMany()
                        .HasForeignKey("GuestTeamTeamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Sport.Models.Team", "HomeTeam")
                        .WithMany()
                        .HasForeignKey("HomeTeamTeamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Sport.Models.Score", "Score")
                        .WithMany()
                        .HasForeignKey("ScoreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("GuestTeam");

                    b.Navigation("HomeTeam");

                    b.Navigation("Score");
                });

            modelBuilder.Entity("Sport.Models.Team", b =>
                {
                    b.HasOne("Sport.Models.Club", null)
                        .WithMany("Teams")
                        .HasForeignKey("ClubId");
                });

            modelBuilder.Entity("Sport.Models.Training", b =>
                {
                    b.HasOne("Sport.Models.Team", "Team")
                        .WithMany()
                        .HasForeignKey("TeamId");

                    b.Navigation("Team");
                });

            modelBuilder.Entity("Sport.Models.Club", b =>
                {
                    b.Navigation("Teams");
                });
#pragma warning restore 612, 618
        }
    }
}
