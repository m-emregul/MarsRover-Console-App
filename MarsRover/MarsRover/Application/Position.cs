namespace ExplorationOfMars{

    public class Position : IPosition {
        public int PositionX {get; set;}
        public int PositionY {get; set;}
        public Directions CurrentDirection {get; set;}
        public IRegion Region {get; set;}

        public Position(IRegion region){
            this.Region = region;
        }

        public Position(IRegion region, Directions currentDirection, int positionX, int positionY) 
        {
            this.Region = region;
            this.CurrentDirection = currentDirection;
            this.PositionX =  positionX; 
            this.PositionY = positionY;
        }

        public void InputPositionsForVehicle()
        {
            if(this.Region == null)
            {
                Console.WriteLine("There must be a region for the position");
                return;
            }

            int inputValueXaxis = 0;
            int inputValueYaxis = 0;
            bool validInput = false;

            while (!validInput)
            { 
                Console.WriteLine("Please enter a position for the vehicle. Positions must be inside the region. Valid input must be two integers and a letter separated by a space, 5 3 N-> : ");
                string? input = Console.ReadLine();
            
                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Invalid input: Input is empty");
                    continue;
                }

                int spaceIndex = input.IndexOf(' ');
                if (spaceIndex == -1 || spaceIndex == 0)
                {
                    Console.WriteLine("Invalid input: There must be two space character and they can not be at the beginning");
                    continue;
                }

                spaceIndex = input.IndexOf(' ', spaceIndex+1);
                if (spaceIndex == input.Length - 1 || input.Count(c => c == ' ') != 2)
                {
                    Console.WriteLine("Invalid input: There must be two space character and they can not be at the end");
                    continue;
                }

                string[] inputArray = input.Split(' ');

                bool successXaxis = int.TryParse(inputArray[0], out inputValueXaxis);
                bool successYaxis = int.TryParse(inputArray[1], out inputValueYaxis);

                if(!successXaxis || !successYaxis || inputValueXaxis < 0 || inputValueYaxis < 0 || inputValueXaxis > this.Region.xPoint || inputValueYaxis > this.Region.yPoint)
                {
                    Console.WriteLine("Invalid input: Invalid integer or positon is out of boundaries of the grid");
                    continue;
                }

                if(inputArray[2].Length != 1 || Enum.IsDefined(typeof(Directions), inputArray[2]) == false)
                {
                    Console.WriteLine("Invalid input: Invalid direction");
                    continue;
                }

                this.CurrentDirection = (Directions)Enum.Parse(typeof(Directions), inputArray[2], false);
                validInput = true;
            }

            this.PositionX = inputValueXaxis;
            this.PositionY = inputValueYaxis;           

        }


    }
}