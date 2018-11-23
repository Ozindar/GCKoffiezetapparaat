using System.Threading;

namespace GC.Koffiezetapparaat.Classes
{
    public class WaterKoker : IWaterKoker
    {
        public Water Kook(Water water)
        {
            Thread.Sleep(2000);
            water.Temperatuur = 100;
            return water;
        }
    }
}