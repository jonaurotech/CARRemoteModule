using System;
using System.Windows;
using System.Windows.Controls;


namespace CAR.Views
{
    /// <summary>
    /// Interaction logic for ChangePassword.xaml
    /// </summary>
    public partial class ChangePassword : Page
    {
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void bcStack_Loaded(object sender, RoutedEventArgs e)
        {
           
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            CAR.user_controls.banner bcBanner = new user_controls.banner();
            bcStack.Children.Add(bcBanner);
        }
    }
}
