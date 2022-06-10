using MarsRoverCore.CommandCenter;
using MarsRoverCore.Mars;
using NUnit.Framework;

namespace MarsRoverTests
{
    public class PlateauTests
    {
        [Test]
        public void Plateau_IsCreated_With_The_Correct_Size()
        {
            // Arrange
            var plateau = new Plateau();

            var commandCenter = new CommandCenter();

            var createPlateauCommand = new CreatePlateauCommand(plateau, "5 5");

            const int expectedWidth = 5;

            const int expectedHeight = 5;

            // Act
            commandCenter.SendCommand(createPlateauCommand);

            var actualWidth = plateau.Width();

            var actualHeight = plateau.Height();

            // Assert
            Assert.AreEqual(expectedWidth, actualWidth);

            Assert.AreEqual(expectedHeight, actualHeight);
        }
    }
}