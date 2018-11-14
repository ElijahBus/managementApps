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
using fingerPrint_Manag.Views;
using fingerPrint_Manag.ViewsModels;

namespace fingerPrint_Manag.Views
{
    /// <summary>
    /// Interaction logic for AdministratorHomeView.xaml
    /// </summary>
    public partial class AdministratorHomeView : UserControl
    {
        public AdministratorHomeView()
        {
            InitializeComponent();
        }

        /// <summary>
        /// the statistics view 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void Statistics_leftButtonDown(object sender, MouseButtonEventArgs e)
        {
            AdministratorHomeViewFrame.Navigate(new Uri("Views/StatisticsView.xaml", UriKind.RelativeOrAbsolute));
        }
        


        /// <summary>
        /// the Add members view
        /// </summary>
        /// <param name="e"></param>
        private void addmembers_leftMousebuttonDown(object sender, MouseButtonEventArgs e)
        /// <param name="sender"></param>
        {
            AdministratorHomeViewFrame.Navigate(new Uri("Views/AddMembersView.xaml", UriKind.RelativeOrAbsolute));
            
        }

        /// <summary>
        /// the view memebers view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MembersView_mouseleftbuttondown(object sender, MouseButtonEventArgs e)
        {
            AdministratorHomeViewFrame.Navigate(new Uri("Views/ViewMembersView.xaml", UriKind.RelativeOrAbsolute));
        }
    }
}
