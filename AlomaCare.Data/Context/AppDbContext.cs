﻿using AlomaCare.Context;
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

        //System Tables
        public DbSet<SystemSetting> SystemSettings { get; set; }


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
        public DbSet<Province> Provinces { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Suburb> Suburbs { get; set; }
        public DbSet<Hospital> Hospitals { get; set; }
        public DbSet<Unit> Units { get; set; }
        public DbSet<AuditLog> AuditLogs { get; set; }
        public DbSet<TypeOfNECSurgeryOption> TypeOfNECSurgeryOptions { get; set; }
        public DbSet<CoolingTypeOption> CoolingTypeOptions { get; set; }
        public DbSet<ReasonForNotCoolingOption> ReasonForNotCoolingOptions { get; set; }
        public DbSet<WhyaEEGNotDoneOption> WhyaEEGNotDoneOptions { get; set; }
        public DbSet<HIEOption> HIEOptions { get; set; }
        public DbSet<ParacetamolForPDAOption> ParacetamolForPDAOptions { get; set; }
        public DbSet<IbuprofenForPDAOption> IbuprofenForPDAOptions { get; set; }
        public DbSet<PDALitigationOption> PDALitigationOptions { get; set; }
        public DbSet<ROPFindingsOption> ROPFindingsOptions { get; set; }
        public DbSet<TypeOfKMCOption> TypeOfKMCOptions { get; set; }
        public DbSet<OtherNeonatalComplication> OtherNeonatalComplications { get; set; }
        public DbSet<IntropicSupportOption> IntropicSupportOptions { get; set; }
        public DbSet<AEEGOption> AEEGOptions { get; set; }
        public DbSet<CerebralCoolingOption> CerebralCoolingOptions { get; set; }
        public DbSet<NecrotisingEntrocoliisOption> NecrotisingEntrocoliisOptions { get; set; }
        public DbSet<ParentalNutritionOption> ParentalNutritionOptions { get; set; }
        public DbSet<RetinopathyOfPrematurityOption> RetinopathyOfPrematurityOptions { get; set; }
        public DbSet<ROPSurgeryOption> ROPSurgeryOptions { get; set; }
        public DbSet<NeonatalJaundiceRequirementOption> NeonatalJaundiceRequirementOptions { get; set; }
        public DbSet<ExchangeTranfusionOption> ExchangeTranfusionOptions { get; set; }
        public DbSet<MaxTotalBilirubinLevelOption> MaxTotalBilirubinLevelOptions { get; set; }
        public DbSet<BloodTransfusionOption> BloodTransfusionOptions { get; set; }
        public DbSet<PlateletTranfusionOption> PlateletTranfusionOptions { get; set; }
        public DbSet<FreshFrozenPlasmaOption> FreshFrozenPlasmaOptions { get; set; }
        public DbSet<MajorBirthDefectOption> MajorBirthDefectOptions { get; set; }
        public DbSet<KangarooCareOption> KangarooCareOptions { get; set; }
        public DbSet<Cardiovascular> Cardiovasculars { get; set; }
        public DbSet<CNS> CNSs { get; set; }
        public DbSet<Metabolic> Metabolics { get; set; }
        public DbSet<GlucoseAbnormalities> GlucoseAbnormalities { get; set; }
        public DbSet<OtherNeonatalComplicationCardiovascular> OtherNeonatalComplicationCardiovasculars { get; set; }
        public DbSet<OtherNeonatalComplicationCNS> OtherNeonatalComplicationCNSs { get; set; }
        public DbSet<OtherNeonatalComplicationMetabolic> OtherNeonatalComplicationMetabolics { get; set; }
        public DbSet<OtherNeonatalComplicationGlucoseAbnormalities> OtherNeonatalComplicationGlucoseAbnormalitiess { get; set; }

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

            modelBuilder.Entity<Patient>()
                .HasOne(p => p.Province)
                .WithMany()
                .HasForeignKey(p => p.ProvinceId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Patient>()
                .HasOne(p => p.City)
                .WithMany()
                .HasForeignKey(p => p.CityId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Patient>()
                .HasOne(p => p.Suburb)
                .WithMany()
                .HasForeignKey(p => p.SuburbId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Patient>()
                .HasOne(p => p.Hospital)
                .WithMany()
                .HasForeignKey(p => p.HospitalId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Province>()
                .HasMany(p => p.Cities)
                .WithOne(c => c.Province)
                .HasForeignKey(c => c.ProvinceId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<City>()
                .HasOne(p => p.Province)
                .WithMany(c => c.Cities)
                .HasForeignKey(c => c.ProvinceId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Suburb>()
                .HasOne(p => p.City)
                .WithMany(c => c.Suburbs)
                .HasForeignKey(c => c.CityId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Suburb>()
                .HasOne(p => p.City)
                .WithMany(c => c.Suburbs)
                .HasForeignKey(c => c.CityId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Hospital>()
                .HasOne(p => p.Province)
                .WithMany()
                .HasForeignKey(c => c.ProvinceId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Hospital>()
                .HasOne(p => p.City)
                .WithMany()
                .HasForeignKey(c => c.CityId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Hospital>()
                .HasOne(p => p.Suburb)
                .WithMany()
                .HasForeignKey(c => c.SuburbId)
                .OnDelete(DeleteBehavior.NoAction);

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

            modelBuilder.Entity<SystemSetting>().HasData(
            new SystemSetting { Id = 1, Key = "OtpExpiryMinutes", Value = "10" });


            base.OnModelCreating(modelBuilder);
        }
    }
}

