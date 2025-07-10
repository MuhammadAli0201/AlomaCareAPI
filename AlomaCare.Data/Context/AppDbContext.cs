using AlomaCare.Context;
using AlomaCare.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Emit;
using System.Text.Json;

namespace AlomaCare.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }


        //Diagnosis Form CRUDS
        public DbSet<Organism> Organisms { get; set; }
        public DbSet<FungalOrganism> FungalOrganisms { get; set; }
        public DbSet<Antimicrobial> Antimicrobials { get; set; }
        public DbSet<CongenitalInfectionOrganism> CongenitalInfectionOrganisms { get; set; }
        public DbSet<SonarFinding> SonarFindings { get; set; }
        //Manage FAQ CRUDS
        public DbSet<Faq> Faqs { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<PasswordReset> PasswordResets { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Maternal> Maternals { get; set; }
        public DbSet<PatientCompleteInfo> PatientCompleteInfos { get; set; }
        public DbSet<HelpResource> HelpResources { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
               .ToTable("users")
               .HasOne(u => u.UserRole)
               .WithOne(r => r.User)
               .HasForeignKey<UserRole>(r => r.UserId);

            modelBuilder.Entity<UserRole>()
                .HasKey(x => x.UserRoleId);

            modelBuilder.Entity<PasswordReset>()
                .HasIndex(pr => new { pr.UserId, pr.CreatedAtUtc })
                .HasDatabaseName("IX_PasswordResets_UserId_CreatedAtUtc");

            modelBuilder.Entity<User>()
                .HasMany<Patient>(u => u.Patients)
                .WithOne(p => p.CreatedByUser)
                .HasForeignKey(p => p.CreatedByUserId);

            modelBuilder.Entity<Patient>()
                .HasOne(p => p.PatientCompleteInfo)
                .WithOne(c => c.Patient)
                .HasForeignKey<PatientCompleteInfo>(c => c.PatientId)
                .OnDelete(DeleteBehavior.Cascade);
            
            modelBuilder.Entity<Patient>()
                .HasOne(p => p.Maternal)
                .WithOne(c => c.Patient)
                .HasForeignKey<Maternal>(c => c.PatientId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<PatientCompleteInfo>()
                .Property(e => e.CongenitalInfectionOrganism)
                .HasConversion(
                    v => JsonSerializer.Serialize(v, (JsonSerializerOptions)null),
                    v => JsonSerializer.Deserialize<List<int>>(v, (JsonSerializerOptions)null))
                .HasColumnType("nvarchar(max)");

            modelBuilder.Entity<PatientCompleteInfo>()
                .Property(e => e.BsOrganism)
                .HasConversion(
                    v => JsonSerializer.Serialize(v, (JsonSerializerOptions)null),
                    v => JsonSerializer.Deserialize<List<int>>(v, (JsonSerializerOptions)null))
                .HasColumnType("nvarchar(max)");

            modelBuilder.Entity<PatientCompleteInfo>()
                .Property(e => e.SepsisSite)
                .HasConversion(
                    v => JsonSerializer.Serialize(v, (JsonSerializerOptions)null),
                    v => JsonSerializer.Deserialize<List<string>>(v, (JsonSerializerOptions)null))
                .HasColumnType("nvarchar(max)");

            modelBuilder.Entity<PatientCompleteInfo>()
                .Property(e => e.FungalOrganism)
                .HasConversion(
                    v => JsonSerializer.Serialize(v, (JsonSerializerOptions)null),
                    v => JsonSerializer.Deserialize<List<int>>(v, (JsonSerializerOptions)null))
                .HasColumnType("nvarchar(max)");

            modelBuilder.Entity<PatientCompleteInfo>()
                .Property(e => e.LateSepsisAbx)
                .HasConversion(
                    v => JsonSerializer.Serialize(v, (JsonSerializerOptions)null),
                    v => JsonSerializer.Deserialize<List<int>>(v, (JsonSerializerOptions)null))
                .HasColumnType("nvarchar(max)");

            modelBuilder.Entity<PatientCompleteInfo>()
                .Property(e => e.SonarFindings)
                .HasConversion(
                    v => JsonSerializer.Serialize(v, (JsonSerializerOptions)null),
                    v => JsonSerializer.Deserialize<List<int>>(v, (JsonSerializerOptions)null))
                .HasColumnType("nvarchar(max)");

            modelBuilder.Entity<PatientCompleteInfo>()
                .Property(e => e.RespiratoryDiagnosis)
                .HasConversion(
                    v => JsonSerializer.Serialize(v, (JsonSerializerOptions)null),
                    v => JsonSerializer.Deserialize<List<string>>(v, (JsonSerializerOptions)null))
                .HasColumnType("nvarchar(max)");

            modelBuilder.Entity<PatientCompleteInfo>()
                .Property(e => e.RespSupportAfter)
                .HasConversion(
                    v => JsonSerializer.Serialize(v, (JsonSerializerOptions)null),
                    v => JsonSerializer.Deserialize<List<string>>(v, (JsonSerializerOptions)null))
                .HasColumnType("nvarchar(max)");

            modelBuilder.Entity<PatientCompleteInfo>()
                .Property(e => e.AeeGNotDoneReason)
                .HasConversion(
                    v => JsonSerializer.Serialize(v, (JsonSerializerOptions)null),
                    v => JsonSerializer.Deserialize<List<string>>(v, (JsonSerializerOptions)null))
                .HasColumnType("nvarchar(max)");

            modelBuilder.Entity<PatientCompleteInfo>()
                .Property(e => e.CoolingNotDoneReason)
                .HasConversion(
                    v => JsonSerializer.Serialize(v, (JsonSerializerOptions)null),
                    v => JsonSerializer.Deserialize<List<string>>(v, (JsonSerializerOptions)null))
                .HasColumnType("nvarchar(max)");

            modelBuilder.Entity<PatientCompleteInfo>()
                .Property(e => e.CoolingType)
                .HasConversion(
                    v => JsonSerializer.Serialize(v, (JsonSerializerOptions)null),
                    v => JsonSerializer.Deserialize<List<string>>(v, (JsonSerializerOptions)null))
                .HasColumnType("nvarchar(max)");

            modelBuilder.Entity<PatientCompleteInfo>()
                .Property(e => e.TypeNecSurgery)
                .HasConversion(
                    v => JsonSerializer.Serialize(v, (JsonSerializerOptions)null),
                    v => JsonSerializer.Deserialize<List<string>>(v, (JsonSerializerOptions)null))
                .HasColumnType("nvarchar(max)");

            modelBuilder.Entity<PatientCompleteInfo>()
                .Property(e => e.RopFindings)
                .HasConversion(
                    v => JsonSerializer.Serialize(v, (JsonSerializerOptions)null),
                    v => JsonSerializer.Deserialize<List<string>>(v, (JsonSerializerOptions)null))
                .HasColumnType("nvarchar(max)");

            modelBuilder.Entity<PatientCompleteInfo>()
                .Property(e => e.RopSurgery)
                .HasConversion(
                    v => JsonSerializer.Serialize(v, (JsonSerializerOptions)null),
                    v => JsonSerializer.Deserialize<List<string>>(v, (JsonSerializerOptions)null))
                .HasColumnType("nvarchar(max)");

            modelBuilder.Entity<PatientCompleteInfo>()
                .Property(e => e.MetabolicComplications)
                .HasConversion(
                    v => JsonSerializer.Serialize(v, (JsonSerializerOptions)null),
                    v => JsonSerializer.Deserialize<List<string>>(v, (JsonSerializerOptions)null))
                .HasColumnType("nvarchar(max)");

            modelBuilder.Entity<PatientCompleteInfo>()
                .Property(e => e.GlucoseAbnormalities)
                .HasConversion(
                    v => JsonSerializer.Serialize(v, (JsonSerializerOptions)null),
                    v => JsonSerializer.Deserialize<List<string>>(v, (JsonSerializerOptions)null))
                .HasColumnType("nvarchar(max)");

            modelBuilder.Entity<PatientCompleteInfo>()
                      .Property(e => e.OutcomeSection)
                      .HasConversion(
                          v => JsonSerializer.Serialize(v, (JsonSerializerOptions)null),
                          v => JsonSerializer.Deserialize<List<string>>(v, (JsonSerializerOptions)null))
                      .HasColumnType("nvarchar(max)");

            modelBuilder.Entity<PatientCompleteInfo>()
                .Property(e => e.FeedsOnDischarge)
                .HasConversion(
                    v => JsonSerializer.Serialize(v, (JsonSerializerOptions)null),
                    v => JsonSerializer.Deserialize<List<string>>(v, (JsonSerializerOptions)null))
                .HasColumnType("nvarchar(max)");

            modelBuilder.Entity<PatientCompleteInfo>()
                .Property(e => e.KmcType)
                .HasConversion(
                    v => JsonSerializer.Serialize(v, (JsonSerializerOptions)null),
                    v => JsonSerializer.Deserialize<List<string>>(v, (JsonSerializerOptions)null))
                .HasColumnType("nvarchar(max)");

            base.OnModelCreating(modelBuilder);
        }
    }
}

