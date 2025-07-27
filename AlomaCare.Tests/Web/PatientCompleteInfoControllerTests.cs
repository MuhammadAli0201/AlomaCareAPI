using AlomaCare.Controllers;
using AlomaCare.Data.Repositories;
using AlomaCare.Models.DTOs;
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
            var mockRepo = new Mock<DiagnosisTreatmentFormRepository>();
            var patientId = Guid.NewGuid();

            var input = new PatientCompleteInfoDTO
            {
                PatientId = patientId,
                NeonatalSepsis = "Yes"
            };

            mockRepo.Setup(r => r.GetByPatientId(patientId))
                    .ReturnsAsync((PatientCompleteInfoDTO)null); // No existing record

            var controller = new DiagnosisTreatmentFormController(mockRepo.Object);

            // Act
            var result = await controller.CreateOrUpdate(input);

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result);
            var returnedValue = Assert.IsType<PatientCompleteInfoDTO>(okResult.Value);
            Assert.Equal(input.PatientId, returnedValue.PatientId);

            //mockRepo.Verify(r => r.AddAsync(It.Is<PatientCompleteInfoDTO>(p => p.PatientId == patientId)), Times.Once);
            mockRepo.Verify(r => r.UpdateAsync(It.IsAny<PatientCompleteInfoDTO>()), Times.Never);
        }
    }
}
