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

namespace fingerPrint_Manag.Views
{
    /// <summary>
    /// Interaction logic for StatisticsView.xaml
    /// </summary>
    public partial class StatisticsView : UserControl
    {
        public StatisticsView()
        {
            InitializeComponent();
            GetPresentation();
        }

        public class Presentation
        {
            public string Name { get; set; }
            public string Function { get; set; }
            public int Number { get; set; }
        }

        public void GetPresentation()
        {
          List<Presentation> _presentation = new List<Presentation>();


            new Presentation()
            {
                Name = "Elijah",
                Function = "SA",
                Number = 1820,

            };

            new Presentation()
            {
                Name = "Alain",
                Function = "SE",
                Number = 2040,
            };

            new Presentation()
            {
                Name = "Gedeon",
                Function = "CE",
                Number = 1456,
            };


            new Presentation()
            {
                Name = "Regiss",
                Function = "CI",
                Number = 1435,
            };

     //       StatisticsDatagrid.ItemsSource = _presentation;

           

        }
    }
}
