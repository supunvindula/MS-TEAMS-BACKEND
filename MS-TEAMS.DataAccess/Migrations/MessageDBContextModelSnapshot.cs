﻿// <auto-generated />
using System;
using MS_TEAMS.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MS_TEAMS.DataAccess.Migrations
{
    [DbContext(typeof(MessageDBContext))]
    partial class MessageDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MS_TEAMS.Models.Group", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int>("TeamId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TeamId");

                    b.ToTable("Groups");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "General",
                            TeamId = 1
                        },
                        new
                        {
                            Id = 2,
                            Name = "Celebration",
                            TeamId = 1
                        },
                        new
                        {
                            Id = 3,
                            Name = "Industry Collaborations",
                            TeamId = 1
                        },
                        new
                        {
                            Id = 4,
                            Name = "Innovatives",
                            TeamId = 1
                        },
                        new
                        {
                            Id = 5,
                            Name = "Marketing Updates",
                            TeamId = 1
                        },
                        new
                        {
                            Id = 6,
                            Name = "Technology Updates",
                            TeamId = 1
                        },
                        new
                        {
                            Id = 7,
                            Name = "General",
                            TeamId = 2
                        },
                        new
                        {
                            Id = 8,
                            Name = "Career Developments",
                            TeamId = 2
                        },
                        new
                        {
                            Id = 9,
                            Name = "Cloud Notifications",
                            TeamId = 2
                        });
                });

            modelBuilder.Entity("MS_TEAMS.Models.Member", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.HasKey("Id");

                    b.ToTable("Members");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Supun Vindula",
                            email = "supunV@99x.io"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Indika Rathnasekara",
                            email = "indikaR@99x.io"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Savindu Bandara",
                            email = "savinduB@99x.io"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Shenali Fernando",
                            email = "shenaliF@99x.io"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Chaminda Vithanage",
                            email = "chamindaV@99x.io"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Cassandra Mascarenhas",
                            email = "cassandraM@99x.io"
                        });
                });

            modelBuilder.Entity("MS_TEAMS.Models.MemberTeam", b =>
                {
                    b.Property<int>("TeamId")
                        .HasColumnType("int");

                    b.Property<int>("MemberId")
                        .HasColumnType("int");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.HasKey("TeamId", "MemberId");

                    b.HasIndex("MemberId");

                    b.ToTable("MemberTeams");

                    b.HasData(
                        new
                        {
                            TeamId = 1,
                            MemberId = 1,
                            Id = 1
                        },
                        new
                        {
                            TeamId = 1,
                            MemberId = 2,
                            Id = 2
                        },
                        new
                        {
                            TeamId = 1,
                            MemberId = 3,
                            Id = 3
                        },
                        new
                        {
                            TeamId = 1,
                            MemberId = 4,
                            Id = 4
                        },
                        new
                        {
                            TeamId = 1,
                            MemberId = 5,
                            Id = 5
                        },
                        new
                        {
                            TeamId = 1,
                            MemberId = 6,
                            Id = 6
                        },
                        new
                        {
                            TeamId = 2,
                            MemberId = 1,
                            Id = 7
                        },
                        new
                        {
                            TeamId = 2,
                            MemberId = 2,
                            Id = 8
                        },
                        new
                        {
                            TeamId = 2,
                            MemberId = 3,
                            Id = 9
                        });
                });

            modelBuilder.Entity("MS_TEAMS.Models.Message", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("GroupId")
                        .HasColumnType("int");

                    b.Property<int>("MemberId")
                        .HasColumnType("int");

                    b.Property<string>("MessageBody")
                        .IsRequired()
                        .HasMaxLength(5000)
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("created")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("GroupId");

                    b.HasIndex("MemberId");

                    b.ToTable("Messages");

                    b.HasData(
                        new
                        {
                            Id = 4,
                            GroupId = 7,
                            MemberId = 1,
                            MessageBody = "How are you all?",
                            created = new DateTime(2022, 3, 2, 23, 11, 23, 91, DateTimeKind.Local).AddTicks(8468)
                        },
                        new
                        {
                            Id = 5,
                            GroupId = 7,
                            MemberId = 2,
                            MessageBody = "Hii",
                            created = new DateTime(2022, 3, 2, 23, 11, 23, 95, DateTimeKind.Local).AddTicks(1203)
                        },
                        new
                        {
                            Id = 6,
                            GroupId = 7,
                            MemberId = 3,
                            MessageBody = "There is a power cut today",
                            created = new DateTime(2022, 3, 2, 23, 11, 23, 95, DateTimeKind.Local).AddTicks(1219)
                        },
                        new
                        {
                            Id = 7,
                            GroupId = 7,
                            MemberId = 4,
                            MessageBody = "Will See you on other size",
                            created = new DateTime(2022, 3, 2, 23, 11, 23, 95, DateTimeKind.Local).AddTicks(1221)
                        },
                        new
                        {
                            Id = 8,
                            GroupId = 7,
                            MemberId = 1,
                            MessageBody = "It is okay Savindu",
                            created = new DateTime(2022, 3, 2, 23, 11, 23, 95, DateTimeKind.Local).AddTicks(1222)
                        },
                        new
                        {
                            Id = 9,
                            GroupId = 8,
                            MemberId = 1,
                            MessageBody = "Hello Career Developments",
                            created = new DateTime(2022, 3, 2, 23, 11, 23, 95, DateTimeKind.Local).AddTicks(1223)
                        });
                });

            modelBuilder.Entity("MS_TEAMS.Models.Team", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("Id");

                    b.ToTable("Team");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Xians"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Internal Systems"
                        });
                });

            modelBuilder.Entity("MS_TEAMS.Models.Group", b =>
                {
                    b.HasOne("MS_TEAMS.Models.Team", "Team")
                        .WithMany()
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Team");
                });

            modelBuilder.Entity("MS_TEAMS.Models.MemberTeam", b =>
                {
                    b.HasOne("MS_TEAMS.Models.Member", "Member")
                        .WithMany("MemberTeams")
                        .HasForeignKey("MemberId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MS_TEAMS.Models.Team", "Team")
                        .WithMany("MemberTeams")
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Member");

                    b.Navigation("Team");
                });

            modelBuilder.Entity("MS_TEAMS.Models.Message", b =>
                {
                    b.HasOne("MS_TEAMS.Models.Group", "Group")
                        .WithMany()
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MS_TEAMS.Models.Member", "Member")
                        .WithMany()
                        .HasForeignKey("MemberId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Group");

                    b.Navigation("Member");
                });

            modelBuilder.Entity("MS_TEAMS.Models.Member", b =>
                {
                    b.Navigation("MemberTeams");
                });

            modelBuilder.Entity("MS_TEAMS.Models.Team", b =>
                {
                    b.Navigation("MemberTeams");
                });
#pragma warning restore 612, 618
        }
    }
}
