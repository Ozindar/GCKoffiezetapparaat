using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using GC.Koffiezetapparaat.Classes;

namespace GC.Koffiezetapparaat.App
{
    public partial class MainWindow : Window
    {
        private readonly Koffiezetter _koffiezetter;

        public MainWindow()
        {
            InitializeComponent();

            var koffiezetterDisplay = new KoffiezetterDisplay();
            DisplayGrid.DataContext = koffiezetterDisplay;

            var waterTap = new WaterTap();
            var waterKoker = new WaterKoker();
            _koffiezetter = new Koffiezetter(koffiezetterDisplay, waterTap, waterKoker);
        }

        private async void TheeClick(object sender, RoutedEventArgs e)
        {
            await Task.Run(() => _koffiezetter.MaakThee());
        }
    }
}