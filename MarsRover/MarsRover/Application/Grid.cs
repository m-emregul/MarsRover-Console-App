namespace  ExplorationOfMars
{
    public class Grid : Region{

        public Grid() : base()
        {

        }

        public Grid(int xPoint, int yPoint) : base(xPoint, yPoint)
        {

        }

        public override void InputSizeTwoDimensionalRegion()
        {
            int inputValueXaxis = 0;
            int inputValueYaxis = 0;
            bool validInput = false;

            while (!validInput)
            { 
                Console.WriteLine("Please enter bottom-right and upper-left points of grid. Valid input must be two integers separated by a space, 5 5 -> : ");
                string? input = Console.ReadLine();

                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Invalid input: Input is empty");
                    continue;
                }

                int spaceIndex = input.IndexOf(' ');
                if (spaceIndex == -1 || spaceIndex == 0 || spaceIndex == input.Length - 1 || input.Count(c => c == ' ') != 1)
                {
                    Console.WriteLine("Invalid input: There must be only one space character and it must be between integers");
                    continue;
                }

                string[] inputArray = input.Split(' ');

                bool successXaxis = int.TryParse(inputArray[0], out inputValueXaxis);
                bool successYaxis = int.TryParse(inputArray[1], out inputValueYaxis);

                if(!successXaxis || !successYaxis || inputValueXaxis < 1 || inputValueYaxis < 1)
                {
                    Console.WriteLine("Invalid input: Invalid integer");
                    continue;
                }

                validInput = true;
            }
            
            this.xPoint = inputValueXaxis;
            this.yPoint = inputValueYaxis;

        }    
    } 

}