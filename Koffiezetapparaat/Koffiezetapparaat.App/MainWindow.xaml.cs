using System.Threading;
using System.Windows;
using Koffiezetapparaat.Classes;

namespace Koffiezetapparaat.App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly KoffiezetterDisplay _koffiezetterDisplay;

        public MainWindow()
        {
            InitializeComponent();

            _koffiezetterDisplay = new KoffiezetterDisplay();
            this.DisplayGrid.DataContext = _koffiezetterDisplay;
        }

        private void TheeClick(object sender, RoutedEventArgs e)
        {
           _koffiezetterDisplay.ToonMelding("Uw thee wordt gemaakt!");
            //TODO hier de echte implementatie!
            Thread.Sleep(5000);
            _koffiezetterDisplay.ToonMelding("Uw thee is klaar!");
        }
    }
}