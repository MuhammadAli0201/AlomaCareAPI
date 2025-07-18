using AlomaCare.Context;
using AlomaCare.Controllers;
using AlomaCare.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace AlomaCare.Tests.Web
{
    public class PatientControllerTests
    {
        private readonly AppDbContext _dbContext;
        private readonly PatientController _controller;

        public PatientControllerTests()
        {
            var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;
            _dbContext = new AppDbContext(options);

            // Seed test data
            _dbContext.Patients.AddRange(new List<Patient>
        {
            new Patient
            {
                Id = Guid.NewGuid(),
                HospitalNumber = "HOSP001",
                Name = "John",
                Surname = "Doe",
                DateOfBirth = DateTime.Now.AddYears(-1),
                DateOfAdmission = DateTime.Now.AddMonths(-1),
                Gender = "Male",
                PlaceOfBirth = "CityA",
                ProvinceId = 1,
                CityId = 1,
                SuburbId = 1,
                HospitalId = 1,
                ModeOfDelivery = "Normal",
                InitialResuscitation = new List<string> { "None" },
                OneMinuteApgar = "8",
                FiveMinuteApgar = "9",
                TenMinuteApgar = "10",
                OutcomeStatus = "Alive",
                TransferHospital = "",
                BirthHivPcr = "",
                DiedInDeliveryRoom = false,
                DiedWithin12Hours = false,
                MothersGtNumber = "",
                ConditionAtBirth = "",
                SyphilisSerology = "",
                SingleOrMultipleBirths = "Single",
                ObstetricCauseOfDeath = "",
                NeonatalCauseOfDeath = "",
                AvoidableFactors = "",
                CreatedByUserId = 1
            },
            new Patient
            {
                Id = Guid.NewGuid(),
                HospitalNumber = "HOSP002",
                Name = "Jane",
                Surname = "Smith",
                DateOfBirth = DateTime.Now.AddYears(-2),
                DateOfAdmission = DateTime.Now.AddMonths(-2),
                Gender = "Female",
                PlaceOfBirth = "CityB",
                ProvinceId = 2,
                CityId = 2,
                SuburbId = 2,
                HospitalId = 2,
                ModeOfDelivery = "C-Section",
                InitialResuscitation = new List<string> { "Oxygen" },
                OneMinuteApgar = "7",
                FiveMinuteApgar = "8",
                TenMinuteApgar = "9",
                OutcomeStatus = "Alive",
                TransferHospital = "",
                BirthHivPcr = "",
                DiedInDeliveryRoom = false,
                DiedWithin12Hours = false,
                MothersGtNumber = "",
                ConditionAtBirth = "",
                SyphilisSerology = "",
                SingleOrMultipleBirths = "Single",
                ObstetricCauseOfDeath = "",
                NeonatalCauseOfDeath = "",
                AvoidableFactors = "",
                CreatedByUserId = 1
            }
        });
            _dbContext.SaveChanges();

            _controller = new PatientController(_dbContext);

            // Mock authentication
            var user = new ClaimsPrincipal(new ClaimsIdentity(new Claim[]
            {
            new Claim(ClaimTypes.Name, "testuser"),
            new Claim(ClaimTypes.Sid, "1")
            }, "mock"));
            _controller.ControllerContext = new ControllerContext
            {
                HttpContext = new DefaultHttpContext { User = user }
            };
        }

        [Fact]
        public void GetAll_ReturnsAllPatients()
        {
            // Act
            var result = _controller.GetAll();

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result);
            var patients = Assert.IsAssignableFrom<List<Patient>>(okResult.Value);
            Assert.Equal(2, patients.Count);
            Assert.Contains(patients, p => p.Name == "John" && p.Surname == "Doe");
            Assert.Contains(patients, p => p.Name == "Jane" && p.Surname == "Smith");
        }
    }
}
