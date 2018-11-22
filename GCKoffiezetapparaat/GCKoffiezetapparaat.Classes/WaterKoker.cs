namespace GC.Koffiezetapparaat.Classes
{
    public class WaterKoker : IWaterKoker
    {
        public Water Kook(Water water)
        {
            water.Temperatuur = 100;
            return water;
        }
    }
}