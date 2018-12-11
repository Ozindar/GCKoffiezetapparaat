using System.Collections.Generic;
using GC.Koffiezetapparaat.Classes.Interfaces;

namespace GC.Koffiezetapparaat.Classes
{
    public class Koffiezetter
    {
        private readonly IKoffiezetterDisplay _display;
        private readonly IWaterTap _waterTap;
        private readonly IWaterKoker _waterkoker;

        public Koffiezetter(IKoffiezetterDisplay display, IWaterTap waterTap, IWaterKoker waterkoker)
        {
            _display = display;
            _waterTap = waterTap;
            _waterkoker = waterkoker;
        }

        public IList<IIngredient> MaakHeetWater()
        {
            var ingredientenLijst = new List<IIngredient>();

            _display.ToonMelding("Heet water wordt gemaakt!");

            _display.ToonMelding("Water tappen!");
            var water = _waterTap.GeefWater(500);

            _display.ToonMelding("Water koken!");
            water = _waterkoker.Kook(water);

            ingredientenLijst.Add(water);
            _display.ToonMelding("Heet water is gemaakt!");

            return ingredientenLijst;
        }

        public IList<IIngredient> MaakCafeCreme()
        {
            _display.ToonMelding("Cafe Creme kan niet nog niet gemaakt worden.");
            return new List<IIngredient>();
        }

        public IList<IIngredient> MaakEspresso()
        {
            _display.ToonMelding("Espresso kan niet nog niet gemaakt worden.");
            return new List<IIngredient>();
        }
    }
}