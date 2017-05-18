using System.Data.Entity;
using NSubstitute;
using NUnit.Framework;
using OrangeBricks.Web.Controllers.Property.Commands;
using OrangeBricks.Web.Models;
using System.Linq;

namespace OrangeBricks.Web.Tests.Controllers.Property.Commands
{
    [TestFixture]
    public class BookViewingCommandHandlerTest
    {
        private BookViewingCommandHandler _handler;
        private IOrangeBricksContext _context;
        private IDbSet<Models.Property> _properties;

        [SetUp]
        public void SetUp()
        {
            _context = Substitute.For<IOrangeBricksContext>();
            _properties = Substitute.For<IDbSet<Models.Property>>();
            _context.Properties.Returns(_properties);
            _handler = new BookViewingCommandHandler(_context);
        }

        [Test]
        public void AddViewingForProperty()
        {
            // Arrange
            var command = new BookViewingCommand
            {
                PropertyId = 1
            };

            var property = new Models.Property
            {
                Description = "Test Property",       
            };

            _properties.Find(1).Returns(property);

            // Act
            _handler.Handle(command);

            // Assert
            _context.Properties.Received(1).Find(1);
            _context.Received(1).SaveChanges();
            Assert.True(property.Viewings.Any());
        }
    }
}
