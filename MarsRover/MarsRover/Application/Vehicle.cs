namespace  ExplorationOfMars
{
    
    public class Vehicle : IVehicle { 
        public IPosition Position {get;set;}
        public IRegion Region {get;set;}

        public Vehicle(IPosition position, IRegion region)
        {
            Position = position;
            Region = region;
        }

        protected virtual void Move()
        {
            Console.WriteLine("Vehicle Move");
        }
        protected virtual void Turn(Commands command)
        {
            Console.WriteLine("Vehicle Turn");
        }

        public virtual void ApplyCommand(string commands)
        {
             Console.WriteLine("Vehicle ApplyCommand");
        } 

        public virtual string InputMovementCommandsForVehicle()
        {
            Console.WriteLine("Input Movement Commands");
            return "";
        }

        public virtual void PrintCurrentState()
        {
            Console.WriteLine("Print Current State");
        }

    }
}
