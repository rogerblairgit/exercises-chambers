using DMS.Core.Services;
using DMS.Domain.Models;
using DMS.Infrastructure.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace DMS.Tests.Services
{
    [TestClass]
    public class PdfServiceTests
    {
        [TestMethod]
        public void Check_Can_Upload_With_Correct_Model()
        {
            // Arrange
            var repository = new Mock<IRepository<Pdf>>();
            var service = new PdfService(repository.Object);
            var pdf = new Pdf
            {
                Filename = "Document1",
                Location = @"\\server1\documents\",
                Size = 10
            };

            // Act
            var result = service.Upload(pdf);

            // Assert
            repository.Verify(c => c.Add(It.IsAny<Pdf>()), Times.AtLeastOnce());
        }
    }
}
