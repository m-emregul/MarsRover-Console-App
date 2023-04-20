using ExplorationOfMars;

namespace MarsRoverTest
{
    [TestClass]
    public class MarsExplorationTests
    {
        [TestMethod]
        public void ApplyCommand_RightPositionI()
        {
            IRegion grid = new Grid(5,5);
            IPosition position = new Position(grid, Directions.N, 1, 2);
            IVehicle roverTest = new Rover(position, grid);

            string commands = "LMLMLMLMM";
            var validateObject = new
            {
                PositionX = 1,
                PositionY = 3,
                CurrentDirection = Directions.N,
            };

            roverTest.ApplyCommand(commands);

            Assert.AreEqual(
                validateObject,
                new { PositionX = roverTest.Position.PositionX, PositionY = roverTest.Position.PositionY, CurrentDirection = roverTest.Position.CurrentDirection }
            );

        }


        [TestMethod]
        public void ApplyCommand_RightPositionII()
        {
            IRegion grid = new Grid(5, 5);
            IPosition position = new Position(grid, Directions.E, 3, 3);
            IVehicle roverTest = new Rover(position, grid);

            string commands = "MMRMMRMRRM";
            var validateObject = new
            {
                PositionX = 5,
                PositionY = 1,
                CurrentDirection = Directions.E,
            };

            roverTest.ApplyCommand(commands);

            Assert.AreEqual(
                validateObject,
                new { PositionX = roverTest.Position.PositionX, PositionY = roverTest.Position.PositionY, CurrentDirection = roverTest.Position.CurrentDirection }
            );

        }

        [TestMethod]
        public void ApplyCommand_BorderCheckI()
        {
            IRegion grid = new Grid(1, 1);
            IPosition position = new Position(grid, Directions.N, 1, 1);
            IVehicle roverTest = new Rover(position, grid);

            string commands = "MMMRMMM";
            var validateObject = new
            {
                PositionX = 1,
                PositionY = 1,
                CurrentDirection = Directions.E,
            };

            roverTest.ApplyCommand(commands);

            Assert.AreEqual(
                validateObject,
                new { PositionX = roverTest.Position.PositionX, PositionY = roverTest.Position.PositionY, CurrentDirection = roverTest.Position.CurrentDirection }
            );

        }

        [TestMethod]
        public void ApplyCommand_BorderCheckII()
        {
            IRegion grid = new Grid(1, 1);
            IPosition position = new Position(grid, Directions.N, 1, 1);
            IVehicle roverTest = new Rover(position, grid);

            string commands = "LMMMLMMMMM";
            var validateObject = new
            {
                PositionX = 0,
                PositionY = 0,
                CurrentDirection = Directions.S,
            };

            roverTest.ApplyCommand(commands);

            Assert.AreEqual(
                validateObject,
                new { PositionX = roverTest.Position.PositionX, PositionY = roverTest.Position.PositionY, CurrentDirection = roverTest.Position.CurrentDirection }
            );

        }
    }
}