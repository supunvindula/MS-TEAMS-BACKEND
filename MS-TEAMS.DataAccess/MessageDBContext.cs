using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MS_TEAMS.Models;

namespace MS_TEAMS.DataAccess
{
    public class MessageDBContext: DbContext
    {
        public DbSet<Message> Messages { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<MemberTeam> MemberTeams { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=localhost; Database=MyMSTeams; Trusted_Connection=True;";
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var xians = new Team { Id = 1, Name = "Xians" };
            var internalSystems = new Team { Id = 2, Name = "Internal Systems" };
            modelBuilder.Entity<Team>().HasData(new Team[] { 
                new Team {Id=1,Name="Xians"},
                new Team {Id=2,Name="Internal Systems"},
            });
            modelBuilder.Entity<Group>().HasData(new Group[] {
                new Group {Id=1,Name="General",TeamId=1},
                new Group {Id=2,Name="Celebration",TeamId=1},
                new Group {Id=3,Name="Industry Collaborations",TeamId=1},
                new Group {Id=4,Name="Innovatives",TeamId=1},
                new Group {Id=5,Name="Marketing Updates",TeamId=1},
                new Group {Id=6,Name="Technology Updates",TeamId=1},
            });
            modelBuilder.Entity<Group>().HasData(new Group[] {
                new Group {Id=7,Name="General",TeamId=2},
                new Group {Id=8,Name="Career Developments",TeamId=2},
                new Group {Id=9,Name="Cloud Notifications",TeamId=2},
            });
            modelBuilder.Entity<Member>().HasData(new Member[] { 
                new Member {Id=1, email= "supunV@99x.io", Name="Supun Vindula" },
                new Member {Id=2, email= "indikaR@99x.io", Name="Indika Rathnasekara" },
                new Member {Id=3, email= "savinduB@99x.io", Name="Savindu Bandara" },
                new Member {Id=4, email= "shenaliF@99x.io", Name="Shenali Fernando" },
                new Member {Id=5, email= "chamindaV@99x.io", Name="Chaminda Vithanage" },
                new Member {Id=6, email= "cassandraM@99x.io", Name="Cassandra Mascarenhas" },
            });
            modelBuilder.Entity<Message>().HasData(new Message[]
            {
                new Message{ Id = 4,MessageBody = "How are you all?",created = DateTime.Now,MemberId=1,GroupId = 7},
                new Message{ Id = 5,MessageBody = "Hii",created = DateTime.Now,MemberId=2,GroupId = 7},
                new Message{ Id = 6,MessageBody = "There is a power cut today",created = DateTime.Now,MemberId=3,GroupId = 7},
                new Message{ Id = 7,MessageBody = "Will See you on other size",created = DateTime.Now,MemberId=4,GroupId = 7},
                new Message{ Id = 8,MessageBody = "It is okay Savindu",created = DateTime.Now,MemberId=1,GroupId = 7},
                new Message{ Id = 9,MessageBody = "Hello Career Developments",created = DateTime.Now,MemberId=1,GroupId = 8},

            });

            //modelBuilder.Entity<MemberTeam>().HasOne(mt => mt.Member).WithMany().HasForeignKey(mt => mt.MemberId);
            //modelBuilder.Entity<MemberTeam>().HasOne(mt => mt.Team).WithMany().HasForeignKey(mt => mt.TeamId);
            modelBuilder.Entity<MemberTeam>().HasKey(q => new { q.TeamId, q.MemberId });
            modelBuilder.Entity<MemberTeam>().HasOne(mt => mt.Team).WithMany(t => t.MemberTeams).HasForeignKey(mt=> mt.TeamId);
            modelBuilder.Entity<MemberTeam>().HasOne(mt => mt.Member).WithMany(m => m.MemberTeams).HasForeignKey(mt => mt.MemberId);
            modelBuilder.Entity<MemberTeam>().HasData(new MemberTeam[] { 
                new MemberTeam {Id=1,MemberId = 1, TeamId = 1},
                new MemberTeam {Id=2,MemberId = 2, TeamId = 1},
                new MemberTeam {Id=3,MemberId = 3, TeamId = 1},
                new MemberTeam {Id=4,MemberId = 4, TeamId = 1},
                new MemberTeam {Id=5,MemberId = 5, TeamId = 1},
                new MemberTeam {Id=6,MemberId = 6, TeamId = 1},
                new MemberTeam {Id=7,MemberId = 1, TeamId = 2},
                new MemberTeam {Id=8,MemberId = 2, TeamId = 2},
                new MemberTeam {Id=9,MemberId = 3, TeamId = 2},

            });
            
        }
    }
}
