using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace GC.Koffiezetapparaat.Classes
{
    public class KoffiezetterDisplay : IKoffiezetterDisplay, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public KoffiezetterDisplay()
        {
            ToonMelding("Initialiseren...");
        }

        private string _melding;
        public string Melding
        {
            get => _melding;
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

        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}