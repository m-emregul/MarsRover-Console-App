
namespace ExplorationOfMars
{
    public interface IVehicle{
        IPosition Position { get; set; }
        IRegion Region { get; set; }
        void ApplyCommand(string commands);
        string InputMovementCommandsForVehicle();
        void PrintCurrentState();
    }
}
