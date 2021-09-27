using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Microcharts;
using SkiaSharp;
using Xamarin.Forms;
using Microcharts.Forms;
namespace graficos
{
    public partial class MainPage : ContentPage
    {


        private readonly List<Microcharts.ChartEntry> _entries = new List<Microcharts.ChartEntry>()
 {
     new Microcharts.ChartEntry(200)
     {
     Label = "Enero",
     ValueLabel = "99",
     Color = SKColor.Parse("#FF0033"),
     },
     new Microcharts.ChartEntry(400)
     {
     Label = "Febrero",
     ValueLabel = "400",
     Color = SKColor.Parse("#FF8000"),
     },
     new Microcharts.ChartEntry(300)
     {
     Label = "Marzo",
     ValueLabel = "400",
     Color = SKColor.Parse("#FFE600"),
     },
     new Microcharts.ChartEntry(250)
     {
     Label = "Abril",
     ValueLabel = "350",
     Color = SKColor.Parse("#1AB34D"),
     },
     new Microcharts.ChartEntry(650)
     {
     Label = "Mayo",
     ValueLabel = "550",
     Color = SKColor.Parse("#1A66FF"),
     },
     new Microcharts.ChartEntry(500)
     {
     Label = "Junio",
     ValueLabel = "700",
     Color = SKColor.Parse("#801AB3"),
     } };




        public MainPage()
        {
            InitializeComponent();
            Diagramacircular.Chart = new DonutChart { Entries = _entries };
            Diagramabarras.Chart = new BarChart { Entries = _entries };
            Diagramapuntos.Chart = new PointChart { Entries = _entries };
            Diagramaradial.Chart = new RadialGaugeChart { Entries = _entries };
            Diagramalineas.Chart = new LineChart { Entries = _entries };
        }
    }
}
