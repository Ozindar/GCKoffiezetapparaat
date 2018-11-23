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

        public void MaakThee()
        {
            _display.ToonMelding("Thee wordt gemaakt!");

            _display.ToonMelding("Water tappen!");
            var water = _waterTap.GeefWater(500);
    
            _display.ToonMelding("Water koken!");
            water = _waterkoker.Kook(water);

            _display.ToonMelding("Thee is gemaakt!");
        }
    }
}