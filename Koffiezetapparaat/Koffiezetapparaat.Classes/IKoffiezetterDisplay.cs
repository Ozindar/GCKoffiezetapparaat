namespace Koffiezetapparaat.Classes
{
    public interface IKoffiezetterDisplay
    {
        string Melding { get; }
        void ToonMelding(string melding);
    }
}