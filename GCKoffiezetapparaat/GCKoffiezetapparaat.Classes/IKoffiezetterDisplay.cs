using System.Threading.Tasks;

namespace GC.Koffiezetapparaat.Classes
{
    public interface IKoffiezetterDisplay
    {
        string Melding { get; }
        void ToonMelding(string melding);
    }
}