using System;
using System.ComponentModel;

namespace GC.Koffiezetapparaat.Classes
{
    public class KoffiezetterDisplay : IKoffiezetterDisplay, INotifyPropertyChanged
    {
        private readonly Action<string> _reportFunc;
        public event PropertyChangedEventHandler PropertyChanged;

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