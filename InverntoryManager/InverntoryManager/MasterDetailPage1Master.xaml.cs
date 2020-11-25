using InverntoryManager.Pages;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace InverntoryManager
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterDetailPage1Master : ContentPage
    {
        public ListView ListView;

        public MasterDetailPage1Master()
        {
            InitializeComponent();

            BindingContext = new MasterDetailPage1MasterViewModel();
            ListView = MenuItemsListView;
        }

        class MasterDetailPage1MasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<MasterDetailPage1MasterMenuItem> MenuItems { get; set; }

            public MasterDetailPage1MasterViewModel()
            {
                MenuItems = new ObservableCollection<MasterDetailPage1MasterMenuItem>(new[]
                {
                    new MasterDetailPage1MasterMenuItem { Id = 0, Icon="editProfile", Title = "Dashboard", TargetType = typeof(HomePage) },
                    new MasterDetailPage1MasterMenuItem { Id = 1, Icon="SettingIcon", Title = "Settings", TargetType = typeof(ServiceURLPage) },
                    new MasterDetailPage1MasterMenuItem { Id = 2, Icon="trash", Title = "Logout", TargetType = typeof(LoginPage) },
                });
            }

            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}