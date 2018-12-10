using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using GC.Koffiezetapparaat.Classes;
using GC.Koffiezetapparaat.Classes.Interfaces;

namespace GC.Koffiezetapparaat.App
{
    public partial class MainWindow : Window
    {
        private readonly Koffiezetter _koffiezetter;

        public MainWindow()
        {
            InitializeComponent();
            var koffiezetterDisplay = new KoffiezetterDisplay(ReportFunc);
            DisplayGrid.DataContext = koffiezetterDisplay;

            var waterTap = new WaterTap();
            var waterKoker = new WaterKoker();
            _koffiezetter = new Koffiezetter(koffiezetterDisplay, waterTap, waterKoker);
        }

        private void ReportFunc(string melding)
        {
            void Action()
            {
                txtMelding.Text = melding;
            }

            Dispatcher.BeginInvoke((Action) Action);
        }

        private async void HeetWaterClick(object sender, RoutedEventArgs e)
        {
            this.Cursor = Cursors.Wait;
            PrintConsumptie(null);

            var consumptie = await Task.Run(() => _koffiezetter.MaakHeetWater()).ConfigureAwait(true);

            PrintConsumptie(consumptie);
            this.Cursor = null;
        }

        private async void CafeCremeClick(object sender, RoutedEventArgs e)
        {
            this.Cursor = Cursors.Wait;
            PrintConsumptie(null);

            var consumptie = await Task.Run(() => _koffiezetter.MaakCafeCreme()).ConfigureAwait(true);

            PrintConsumptie(consumptie);
            this.Cursor = null;
        }

        private async void EspressoClick(object sender, RoutedEventArgs e)
        {
            this.Cursor = Cursors.Wait;
            PrintConsumptie(null);

            var consumptie = await Task.Run(() => _koffiezetter.MaakEspresso()).ConfigureAwait(true);

            PrintConsumptie(consumptie);
            this.Cursor = null;
        }

        private void PrintConsumptie(IList<IIngredient> ingredienten)
        {
            if (ingredienten == null || !ingredienten.Any())
            {
                txtConsumptie.Text = string.Empty;
                return;
            }

            txtConsumptie.Text = string.Join(Environment.NewLine, ingredienten.Select(x => $"- {x.Hoeveelheid} {x.Eenheid} {x.Omschrijving}"));
        }
    }
}