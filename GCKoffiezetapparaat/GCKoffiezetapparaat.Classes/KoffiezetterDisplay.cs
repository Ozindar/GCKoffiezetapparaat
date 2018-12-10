using System;
using GC.Koffiezetapparaat.Classes.Interfaces;

namespace GC.Koffiezetapparaat.Classes
{
    public class KoffiezetterDisplay : IKoffiezetterDisplay
    {
        private readonly Action<string> _reportFunc;

        public KoffiezetterDisplay(Action<string> reportFunc)
        {
            _reportFunc = reportFunc;

            ToonMelding("Initialiseren...");
        }

        private string _melding;
        public string Melding
        {
            get => _melding;
            set
            {
                _melding = value;
                _reportFunc(value);
            }
        }

        public void ToonMelding(string melding)
        {
            Melding = melding;
        }
    }
}