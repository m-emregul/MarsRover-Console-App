namespace  ExplorationOfMars
{
    public class Region : IRegion{
        public int xPoint { get;set;}
        public int yPoint { get;set;} 
        public Region(){

        }

        public Region(int xPoint, int yPoint)
        {
            this.xPoint = xPoint;
            this.yPoint = yPoint;
        }

        public virtual void  InputSizeTwoDimensionalRegion()
        {
            Console.WriteLine("Enter the length of the X and Y axes");
        }
    }
}