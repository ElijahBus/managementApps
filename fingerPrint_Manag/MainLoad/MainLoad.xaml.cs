using fingerPrint_Manag.ViewsModels;
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
using fingerPrint_Manag.Views;
using System.Data.Sql;


namespace fingerPrint_Manag.MainLoad
{
    /// <summary>
    /// Interaction logic for MainLoad.xaml
    /// </summary>
    public partial class MainLoad : Window
    {
        public MainLoad()
        {
            InitializeComponent();

        }

        /// <summary>
        /// Home button clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Home_clicked(object sender, RoutedEventArgs e)
        {
            MainLoadFrame.Navigate(new Uri("Views/HomeView.xaml", UriKind.RelativeOrAbsolute));
            titletexbox.Text = "Attendance";
        }


        /// <summary>
        /// Log in button in file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FileLogIn_Clicked(object sender, RoutedEventArgs e)
        {
            this.Hide();
            LogIn _login = new LogIn();
            _login.Show();
        }

        // file.exit button that close the program
        private void FileExit_clicked(object sender, RoutedEventArgs e)
        {
            Close();
            Application.Current.Shutdown();
        }


        /// <summary>
        /// event to occurs when the administration fileiten is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FileAdmin_clicked(object sender, RoutedEventArgs e)
        {
            MainLoadFrame.Navigate(new Uri("Views/AdministratorHomeView.xaml", UriKind.RelativeOrAbsolute));
            titletexbox.Text = "Administration";
           
        }

        /// <summary>
        /// the fisrt page to be displayed after LogIn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainLoad_loaded(object sender, RoutedEventArgs e)
        {
            MainLoadFrame.Navigate(new Uri("Views/HomeView.xaml", UriKind.RelativeOrAbsolute));
            titletexbox.Text = "Attendance";
 
        }


   


    }
}
