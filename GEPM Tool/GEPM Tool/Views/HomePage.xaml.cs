using System;

using GEPM_Tool.ViewModels;

using Windows.UI.Xaml.Controls;

namespace GEPM_Tool.Views
{
    public sealed partial class HomePage : Page
    {
        private HomeViewModel ViewModel => DataContext as HomeViewModel;

        public HomePage()
        {
            InitializeComponent();
        }
    }
}
