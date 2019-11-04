using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Syncfusion.UI.Xaml.Charts;

namespace PieChart_CS
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            SfChart chart = new SfChart();
            ViewModel viewModel = new ViewModel();
            chart.DataContext = viewModel;
            chart.Header = "Weight Report";
            chart.Legend = new ChartLegend();

            // Defining the PieSeries with adornments.
            PieSeries series = new PieSeries();
            series.XBindingPath = "Name";
            series.YBindingPath = "Weight";
            series.ItemsSource = viewModel.Data;
            series.AdornmentsInfo = new ChartAdornmentInfo()
            {
                ShowLabel = true
            };
            chart.Series.Add(series);

            //Setting chart as Window's Content. 
            Content = chart;
        }
    }
}
