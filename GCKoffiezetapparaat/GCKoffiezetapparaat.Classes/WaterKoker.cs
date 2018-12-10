using System.Threading;
using GC.Koffiezetapparaat.Classes.Interfaces;

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