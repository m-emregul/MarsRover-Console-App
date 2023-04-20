

namespace ExplorationOfMars{

    public class Rover : Vehicle {

        public Rover(IPosition position, IRegion region) : base(position, region) 
        {
            
        }

        protected override void Move()
        {
            switch (this.Position.CurrentDirection)
            {
                case Directions.N:
                    if(this.Position.PositionY < this.Region.yPoint)  this.Position.PositionY++;
                    break;
                case Directions.S:
                    if(this.Position.PositionY > 0)  this.Position.PositionY--;
                    break;
                case Directions.E:
                    if(this.Position.PositionX < this.Region.xPoint)  this.Position.PositionX++;
                    break;
                case Directions.W:
                    if(this.Position.PositionX > 0)  this.Position.PositionX--;
                    break;
            } 
        }

        protected override void Turn(Commands command)
        {
            switch (command)
            {
                case Commands.R:
                    this.Position.CurrentDirection = (Directions)(((int)this.Position.CurrentDirection + 1) % 4);
                    break;
                case Commands.L:
                    this.Position.CurrentDirection = (Directions)(((int)this.Position.CurrentDirection + 3) % 4);
                    break;
            }
        }

        public override void ApplyCommand(string commands)
        {
            foreach(char c in commands)
            {   
                if ((Commands)c == Commands.M)
                {
                    Move();
                }
                else
                {
                    Turn((Commands)c);
                }
            }
        }

        public override string InputMovementCommandsForVehicle()
        {
            string output = "";
            string[] commandNames = Enum.GetNames(typeof(Commands));
            bool validInput = false;
            
            while (!validInput)
            { 
                Console.WriteLine("Please enter movement commands for the vehicle. Be careful, commands are case sensitive (Example: MRL): ");
                string? input = Console.ReadLine();
            
                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Invalid input: Input is empty");
                    continue;
                }

                if (input.Length > 1000)
                {
                    Console.WriteLine("Invalid input: Maximum 1000 commands can be read at a time");
                    continue;
                }

                string[] unrecognizedCommands = new string[input.Length];
                int i = 0;
                foreach (char c in input)
                {
                    string charAsString = c.ToString();
                    if (!Array.Exists(commandNames, e => e == charAsString))
                    {
                        unrecognizedCommands[i] = charAsString;
                        i++;
                    }
                }
                if(i > 0)
                {
                    Console.WriteLine("Invalid input: Invalid commands : " + String.Join(", ", unrecognizedCommands.Take(i)));
                    continue;
                }

                output = input;
                validInput = true;
            }

            return output;
        }

        public override void PrintCurrentState()
        {
            Console.WriteLine("Rover Current Position : " + this.Position.PositionX + " " + this.Position.PositionY + " " + this.Position.CurrentDirection.ToString());
        }

    }

}