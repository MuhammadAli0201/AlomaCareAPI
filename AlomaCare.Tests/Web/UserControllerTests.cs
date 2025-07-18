using AlomaCare.Context;
using AlomaCare.Controllers;
using AlomaCare.Helpers;
using AlomaCare.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Moq;
using Xunit;

namespace AlomaCare.Tests.Web
{
    public class UserControllerTests
    {
        private readonly UserController _controller;
        private readonly AppDbContext _dbContext;
        private readonly Mock<IWebHostEnvironment> _envMock = new();

        public UserControllerTests()
        {
            var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseInMemoryDatabase(databaseName: "TestDb")
                .Options;
            _dbContext = new AppDbContext(options);
            _controller = new UserController(_dbContext, _envMock.Object);
        }

        [Fact]
        public async Task Authenticate_ReturnsOk_WhenCredentialsAreValidAndApproved()
        {
            // Arrange
            var password = "Password1!";
            var hashedPassword = PasswordHasher.Hashpassword(password);

            var user = new User
            {
                FirstName = "Test",
                LastName = "User",
                Usernumber = "HPCSA123",
                Email = "test@email.com",
                Password = hashedPassword,
                Role = "Doctor",
                IsVerified = true
            };
            await _dbContext.Users.AddAsync(user);
            await _dbContext.SaveChangesAsync();

            var userRole = new UserRole
            {
                UserRoleId = System.Guid.NewGuid(),
                UserId = user.Id,
                Approved = true
            };
            await _dbContext.UserRoles.AddAsync(userRole);
            user.UserRole = userRole;
            await _dbContext.SaveChangesAsync();

            var loginUser = new User
            {
                Usernumber = "HPCSA123",
                Password = password
            };

            // Act
            var result = await _controller.Authenticate(loginUser);

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result);
            Assert.Contains("Login Success", okResult.Value.ToString());
        }

        [Fact]
        public async Task RegisterUser_ReturnsBadRequest_WhenUserObjectIsNull()
        {
            // Act
            var result = await _controller.RegisterUser(null);

            // Assert
            Assert.IsType<BadRequestResult>(result);
        }
    }
}
