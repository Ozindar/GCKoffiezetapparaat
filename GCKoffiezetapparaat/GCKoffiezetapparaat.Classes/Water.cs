using GC.Koffiezetapparaat.Classes.Interfaces;

namespace GC.Koffiezetapparaat.Classes
{
    public class Water : IIngredient
    {
        public int Milliliter { get; set; }
        public decimal Temperatuur { get; set; }

        public string Omschrijving => $"water ({Temperatuur} graden).";
        public decimal Hoeveelheid => Milliliter;
        public string Eenheid => "ml";
    }
}