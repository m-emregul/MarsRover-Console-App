namespace ExplorationOfMars{
    public interface IPosition{
        int PositionX {get; set;}
        int PositionY {get; set;}
        Directions CurrentDirection {get; set;}
        void InputPositionsForVehicle();
        
    }
}