
namespace ExplorationOfMars
{
    class Program
    {
        static void Main(string[] args)
        {

            IRegion grid = new Grid();
            grid.InputSizeTwoDimensionalRegion();

            Console.WriteLine("\nFirst Rover ----- ");
            IPosition positionI = new Position(grid);
            positionI.InputPositionsForVehicle();

            IVehicle roverI = new Rover(positionI, grid);
            string commandsI = roverI.InputMovementCommandsForVehicle();

            Console.WriteLine("\nSecond Rover ----- ");
            IPosition positionII = new Position(grid);
            positionII.InputPositionsForVehicle();

            IVehicle roverII = new Rover(positionII, grid);
            string commandsII = roverII.InputMovementCommandsForVehicle();

            Console.WriteLine("\nFirst Rover ----- ");
            roverI.PrintCurrentState();
            Console.WriteLine("After Movement : " + commandsI);
            roverI.ApplyCommand(commandsI);
            roverI.PrintCurrentState();


            Console.WriteLine("\nSecond Rover ----- ");
            roverII.PrintCurrentState();
            Console.WriteLine("After Movement : " + commandsII);
            roverII.ApplyCommand(commandsII);
            roverII.PrintCurrentState();

        }
    }
    

}