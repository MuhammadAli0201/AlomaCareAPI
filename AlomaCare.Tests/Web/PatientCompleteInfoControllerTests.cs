using AlomaCare.Controllers;
using AlomaCare.Data.Repositories;
using AlomaCare.Models;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace AlomaCare.Tests.Web
{
    public class PatientCompleteInfoControllerTests
    {
        [Fact]
        public async Task CreateOrUpdate_CreatesNew_WhenNoExistingRecord()
        {
            // Arrange
            var mockRepo = new Mock<IPatientCompleteInfoRepository>();
            var patientId = Guid.NewGuid();

            var input = new PatientCompleteInfo
            {
                PatientId = patientId,
                NeonatalSepsis = "Yes"
            };

            mockRepo.Setup(r => r.GetByPatientId(patientId))
                    .ReturnsAsync((PatientCompleteInfo)null); // No existing record

            var controller = new PatientCompleteInfoController(mockRepo.Object);

            // Act
            var result = await controller.CreateOrUpdate(input);

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result);
            var returnedValue = Assert.IsType<PatientCompleteInfo>(okResult.Value);
            Assert.Equal(input.PatientId, returnedValue.PatientId);

            mockRepo.Verify(r => r.AddAsync(It.Is<PatientCompleteInfo>(p => p.PatientId == patientId)), Times.Once);
            mockRepo.Verify(r => r.UpdateAsync(It.IsAny<PatientCompleteInfo>()), Times.Never);
        }
    }
}
