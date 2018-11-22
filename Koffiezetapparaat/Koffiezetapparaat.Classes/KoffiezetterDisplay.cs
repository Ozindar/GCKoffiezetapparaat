using System;
using System.Collections;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Koffiezetapparaat.Classes
{
    public class KoffiezetterDisplay : IKoffiezetterDisplay, INotifyPropertyChanged
    {
    

        public KoffiezetterDisplay()
        {
            ToonMelding("Initialiseren...");
        }

        private string _melding;
        public string Melding
        {
            get
            {
                return _melding;
            }
            set
            {
                _melding = value;
                NotifyPropertyChanged();
            }
        }

        public void ToonMelding(string melding)
        {
            Melding = melding;
            
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}