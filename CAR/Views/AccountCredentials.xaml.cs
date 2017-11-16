using System;
using System.Windows;
using System.Windows.Controls;

namespace CAR.Views
{
    /// <summary>
    /// Interaction logic for AccountCredentials.xaml
    /// </summary>
    public partial class AccountCredentials : Page
    {
        public AccountCredentials()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            CAR.user_controls.banner acBanner = new user_controls.banner();
            acStack.Children.Add(acBanner);
        }
    }
}
