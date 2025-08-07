using AlomaCare.Context;
using AlomaCare.Controllers;
using AlomaCare.Data.Repositories;
using AlomaCare.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace AlomaCare.Tests.Web
{
    public class MaternalControllerTests
    {
        private readonly Mock<IMaternalRepository> _maternalRepoMock = new();
        private readonly Mock<IPatientRepository> _patientRepoMock = new();
        private readonly Mock<AppDbContext> mockContext = new ();
        private readonly MaternalController _controller;

        public MaternalControllerTests()
        {
            _controller = new MaternalController(_maternalRepoMock.Object, _patientRepoMock.Object, mockContext.Object);

            // Mock authentication
            var user = new ClaimsPrincipal(new ClaimsIdentity(new Claim[]
            {
            new Claim(ClaimTypes.Sid, "1")
            }, "mock"));
            _controller.ControllerContext = new ControllerContext
            {
                HttpContext = new DefaultHttpContext { User = user }
            };
        }

        [Fact]
        public async Task GetByPatientId_ReturnsOkResultWithMaternalRecord()
        {
            // Arrange
            var patientId = Guid.NewGuid();
            var expectedMaternal = new Maternal
            {
                Id = Guid.NewGuid(),
                PatientId = patientId,
                Name = "Jane",
                Surname = "Doe",
                HospitalNumber = "H123"
                // Add other required properties if needed
            };

            var maternalRepoMock = new Mock<IMaternalRepository>();
            var patientRepoMock = new Mock<IPatientRepository>();
            var contextMock = new Mock<AppDbContext>();

            maternalRepoMock.Setup(r => r.GetByPatientId(patientId))
                            .ReturnsAsync(expectedMaternal);

            var controller = new MaternalController(maternalRepoMock.Object, patientRepoMock.Object, mockContext.Object);

            // Act
            var result = await controller.GetByPatientId(patientId);

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result);
            var returnedMaternal = Assert.IsType<Maternal>(okResult.Value);
            Assert.Equal(expectedMaternal.Id, returnedMaternal.Id);
            Assert.Equal(expectedMaternal.PatientId, returnedMaternal.PatientId);
            Assert.Equal(expectedMaternal.Name, returnedMaternal.Name);
        }
    }
}
