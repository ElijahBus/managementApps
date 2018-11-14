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
using System.Windows.Shapes;
using fingerPrint_Manag.MainLoad;

namespace fingerPrint_Manag
{
    /// <summary>
    /// Interaction logic for LogIn.xaml
    /// </summary>
    public partial class LogIn : Window
    {

       
        

        public LogIn()
        {
            InitializeComponent();
            
        }

        private void logIn_clicked(object sender
            , RoutedEventArgs e)
        {

            this.Hide();
            MainLoad.MainLoad _mainload = new MainLoad.MainLoad();
            _mainload.Show();
           
        }
    }
}
