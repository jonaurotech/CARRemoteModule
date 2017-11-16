using CAR.Views;
using Microsoft.Practices.Prism.Commands;
using System.Collections.Generic;
using System.Windows.Controls;

using System;
using System.Windows.Input;

namespace CAR.View_models
{
    public class DefaultViewModel
    {
        public IList<TabModel> ViewModelList { get; set; }
        public ICommand SelectionChangedCommand { get; private set; }

        public DefaultViewModel()
        {
            ViewModelList = new List<TabModel>
            {
                new TabModel {Name = "Receive an Asset" , Content = new CreateAssetView(), IsSelected = true },
                new TabModel {Name = "Select Asset" , Content = new AssetListView(), IsSelected = false }
            };

            SelectionChangedCommand = new DelegateCommand<object>(ExecuteSelectionChanged);
        }

        private void ExecuteSelectionChanged(object obj)
        {
            
        }
    }

    public class TabModel
    {
        public string Name { get; set; }
        public UserControl Content { get; set; }
        public bool IsSelected { get; set; }
    }
}
