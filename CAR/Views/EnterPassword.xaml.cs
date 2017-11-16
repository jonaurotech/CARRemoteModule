using System;
using System.Windows;
using System.Windows.Controls;


namespace CAR.Views
{
    /// <summary>
    /// Interaction logic for EnterPassword.xaml
    /// </summary>
    public partial class EnterPassword : Page
    {
        public EnterPassword()
        {
            InitializeComponent();
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            CAR.user_controls.banner bepBanner = new user_controls.banner();
            bepStack.Children.Add(bepBanner);
        }
    }
}
