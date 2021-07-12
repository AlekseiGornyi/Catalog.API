using Catalog.API.Controllers;
using Catalog.BLL.Interfaces;
using Catalog.BLL.Models;
using Catalog.DAL.EntityDTO;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Catalog.UnitTest.Api.Controller
{
    public class AuthorControllerTests
    {
        [Fact]
        public async Task GetAuthorId_WithUnexistingItem_ReturnsCode500()
        {
            // Arrange            
            var repositoryStub = new Mock<IAuthor_Service>();
            repositoryStub.Setup(repo => repo.GetAuthor(It.IsAny<long>())).Returns<Author_Resultset>(null);
           
            var controller = new AuthorController(repositoryStub.Object);
            // Act
            var result = await controller.GetAuthourId(It.IsAny<long>());

            // Assert
            Assert.IsType<NotFoundResult>(result);            
        }
    }
}
