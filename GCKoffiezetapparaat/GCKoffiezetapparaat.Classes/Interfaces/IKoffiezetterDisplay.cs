using System.Threading.Tasks;

namespace GC.Koffiezetapparaat.Classes.Interfaces
{
    public interface IKoffiezetterDisplay
    {
        string Melding { get; }
        void ToonMelding(string melding);
    }
}