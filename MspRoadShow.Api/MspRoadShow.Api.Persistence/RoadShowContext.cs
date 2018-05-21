using Microsoft.EntityFrameworkCore;
using MspRoadShow.Api.Business.Entities;

namespace MspRoadShow.Api.Persistence
{
    public class RoadShowContext : DbContext
    {
        public DbSet<Attendee> Attendees { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<CitySponsor> CitySponsors { get; set; }
        public DbSet<EvaluateQuestion> EvaluateQuestions { get; set; }
        public DbSet<QuizAnswer> QuizAnswers { get; set; }
        public DbSet<QuizQuestion> QuizQuestions { get; set; }
        public DbSet<Speaker> Speakers { get; set; }
        public DbSet<Speech> Speeches { get; set; }
        public DbSet<SpeechAttendee> SpeechAttedees { get; set; }
        public DbSet<Sponsor> Sponsors { get; set; }

        public RoadShowContext(DbContextOptions<RoadShowContext> options):base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.HasDefaultSchema("msproadshow");
            CreateAttendeeTable(modelBuilder);
            CreateCityTable(modelBuilder);
            CreateCitySponsorTable(modelBuilder);
            CreateEvaluateQuestionTable(modelBuilder); 
            CreateQuizAnswerTable(modelBuilder);
            CreateQuizQuestionTable(modelBuilder);
            CreateSpeakerTable(modelBuilder); 
            CreateSpeechTable(modelBuilder);
            CreateSpeechAttendeeTable(modelBuilder);
            CreateSponsorsTable(modelBuilder);
        }

        private void CreateAttendeeTable(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Attendee>().ToTable("Attendees");
            modelBuilder.Entity<Attendee>().HasKey(pk => pk.Id);

            modelBuilder.Entity<Attendee>().Property(p => p.Email).HasMaxLength(30).IsRequired();
            modelBuilder.Entity<Attendee>().Property(p => p.FirstName).HasMaxLength(15).IsRequired();
            modelBuilder.Entity<Attendee>().Property(p => p.LastName).HasMaxLength(15).IsRequired();
            modelBuilder.Entity<Attendee>().Property(p => p.Activity).HasMaxLength(15).IsRequired();
            modelBuilder.Entity<Attendee>().Property(p => p.Company).HasMaxLength(20);
            modelBuilder.Entity<Attendee>().Property(p => p.Position).HasMaxLength(20);
            modelBuilder.Entity<Attendee>().Property(p => p.CreatedAt);
            modelBuilder.Entity<Attendee>().Property(p => p.Score);

            modelBuilder.Entity<Attendee>().HasOne(a => a.City)
    .WithOne(ac => ac.Attendee)
    .HasForeignKey<AttendeeCity>(fk => fk.AttendeesId);
        }

        private void CreateCityTable(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<City>().ToTable("Cities");
            modelBuilder.Entity<City>().HasKey(pk => pk.Id);

            modelBuilder.Entity<City>().Property(p => p.Name).HasMaxLength(10).IsRequired();
            modelBuilder.Entity<City>().Property(p => p.Place).HasMaxLength(100).IsRequired();
            modelBuilder.Entity<City>().Property(p => p.StartDate).IsRequired().IsRequired();
            modelBuilder.Entity<City>().Property(p => p.EndDate).IsRequired().IsRequired();
        }

        private void CreateCitySponsorTable(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CitySponsor>().ToTable("CitySponsors");
            modelBuilder.Entity<CitySponsor>().HasKey(pk => new
            {
                pk.CityId,
                pk.SponsorId
            });

            modelBuilder.Entity<CitySponsor>().Property(p => p.SponsorId);
            modelBuilder.Entity<CitySponsor>().Property(p => p.CityId);

            modelBuilder.Entity<CitySponsor>().HasOne(s => s.Sponsor).WithMany(sp => sp.CitiesList).HasForeignKey(fk => fk.SponsorId);
            modelBuilder.Entity<CitySponsor>().HasOne(s => s.City).WithMany(c => c.SponsorList).HasForeignKey(fk => fk.CityId);
        }

        private void CreateEvaluateQuestionTable(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EvaluateQuestion>().ToTable("EvaluateQuestions");
            modelBuilder.Entity<EvaluateQuestion>().HasKey(pk => pk.Id);

            modelBuilder.Entity<EvaluateQuestion>().Property(p => p.Text).HasMaxLength(50);
            modelBuilder.Entity<EvaluateQuestion>().Property(p => p.IsMultipleChoisePossible);
            modelBuilder.Entity<EvaluateQuestion>().Property(p => p.Answers);
        }

        private void CreateQuizAnswerTable(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<QuizAnswer>().ToTable("QuizQuestionAnswers");
            modelBuilder.Entity<QuizAnswer>().HasKey(pk => pk.Id);

            modelBuilder.Entity<QuizAnswer>().Property(p => p.Text).HasMaxLength(15);
            modelBuilder.Entity<QuizAnswer>().Property(p => p.IsCorrect);

            modelBuilder.Entity<QuizAnswer>().HasOne(qa => qa.Question).WithMany(q => q.Answers).HasForeignKey(fk => fk.QuestionId);
        }

        private void CreateQuizQuestionTable(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<QuizQuestion>().ToTable("QuizQuestions");
            modelBuilder.Entity<QuizQuestion>().HasKey(pk => pk.Id);

            modelBuilder.Entity<QuizQuestion>().Property(p => p.Title).HasMaxLength(20);
            modelBuilder.Entity<QuizQuestion>().Property(p => p.IsMultipleChoiseActive);

            modelBuilder.Entity<QuizQuestion>().HasOne(qq => qq.Speech).WithMany(s => s.Questions).HasForeignKey(fk => fk.SpeechId);
        }

        private void CreateSpeakerTable(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Speaker>().ToTable("Speakers");
            modelBuilder.Entity<Speaker>().HasKey(pk => pk.Id);

            modelBuilder.Entity<Speaker>().Property(p => p.Name).HasMaxLength(50).IsRequired();
            modelBuilder.Entity<Speaker>().Property(p => p.SpeakerBio).HasMaxLength(500);
            modelBuilder.Entity<Speaker>().Property(p => p.PhotoUrl).HasMaxLength(100);
            modelBuilder.Entity<Speaker>().Property(p => p.Note);
        }

        private void CreateSpeechTable(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Speech>().ToTable("Speeches");
            modelBuilder.Entity<Speech>().HasKey(pk => pk.Id);

            modelBuilder.Entity<Speech>().Property(p => p.StartTime).IsRequired();
            modelBuilder.Entity<Speech>().Property(p => p.EndTime).IsRequired();
            modelBuilder.Entity<Speech>().Property(p => p.Name).HasMaxLength(50).IsRequired();
            modelBuilder.Entity<Speech>().Property(p => p.Description).HasMaxLength(500).IsRequired();
            modelBuilder.Entity<Speech>().Property(p => p.Location).HasMaxLength(20);
            modelBuilder.Entity<Speech>().Property(p => p.IsActive).IsRequired();
        }

        private void CreateSpeechAttendeeTable(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SpeechAttendee>().ToTable("SpeechAttendees");
            modelBuilder.Entity<SpeechAttendee>().HasKey(pk => pk.Id);
            modelBuilder.Entity<SpeechAttendee>().HasIndex(i=>
            new
            {
                i.SpeechId,
                i.AttendeeId
            });

            modelBuilder.Entity<SpeechAttendee>().Property(p => p.Comment).HasMaxLength(200);
            modelBuilder.Entity<SpeechAttendee>().Property(p => p.Rating).IsRequired(false);

            modelBuilder.Entity<SpeechAttendee>().HasOne(sa => sa.Attendee).WithMany(a => a.SpeechesList).HasForeignKey(fk => fk.AttendeeId); 
            modelBuilder.Entity<SpeechAttendee>().HasOne(sa => sa.Speech).WithMany(s => s.AttendeesList).HasForeignKey(fk => fk.SpeechId);
        }

        private void CreateSponsorsTable(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Sponsor>().ToTable("Sponsors");
            modelBuilder.Entity<Sponsor>().HasKey(pk => pk.Id);

            modelBuilder.Entity<Sponsor>().Property(p => p.Name).HasMaxLength(50).IsRequired();
            modelBuilder.Entity<Sponsor>().Property(p => p.LogoUrl).HasMaxLength(100).IsRequired();
            modelBuilder.Entity<Sponsor>().Property(p => p.SponsorLevel).HasMaxLength(10).IsRequired();
            modelBuilder.Entity<Sponsor>().Property(p => p.IsActiveSponsor).IsRequired();
        }

        private void CreateAttendeeCityTable(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AttendeeCity>().ToTable("AttendeeCity");
            modelBuilder.Entity<AttendeeCity>().HasKey(pk => pk.Id);

            modelBuilder.Entity<AttendeeCity>().HasOne(ac => ac.City)
                .WithMany(c => c.Attendees)
                .HasForeignKey(fk => fk.CityId);
        }
    }
}
