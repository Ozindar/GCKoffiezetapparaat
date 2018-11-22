namespace GC.Koffiezetapparaat.Classes
{
    public class WaterTap : IWaterTap
    {
        public Water GeefWater(int milliliter)
        {
            return new Water
            {
                Milliliter = milliliter,
                Temperatuur = 15
            };
        }
    }
}