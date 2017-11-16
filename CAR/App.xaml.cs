using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Prism;


namespace CAR
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public object User { get; private set; }
     
       
        public void LoadUser(object user)
        {
            User = user;
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            
            base.OnStartup(e);
            
         
        }

       
        private void ConfigureContainer()
        {
         


        }

    }


}
