namespace ConsoleApp1.Classes
{
    public class LiquidContainer : Container, HazardNotifier
    {
        public LiquidContainer(int Weight, int Height, int ConteinerWeight, int Depth, int MaxWeight) : base(Weight, Height, ConteinerWeight, Depth, MaxWeight)
        {
            this.Kind = 'L';

        }
    }

}