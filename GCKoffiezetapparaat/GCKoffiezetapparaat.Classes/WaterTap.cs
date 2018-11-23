using System.Threading;

namespace GC.Koffiezetapparaat.Classes
{
    public class WaterTap : IWaterTap
    {
        public Water GeefWater(int milliliter)
        {
            Thread.Sleep(2000);
            return new Water
            {
                Milliliter = milliliter,
                Temperatuur = 15
            };
        }
    }
}