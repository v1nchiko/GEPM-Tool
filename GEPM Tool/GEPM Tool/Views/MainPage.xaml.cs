using System;

using GEPM_Tool.ViewModels;

using Windows.UI.Xaml.Controls;

namespace GEPM_Tool.Views
{
    public sealed partial class MainPage : Page
    {
        private MainViewModel ViewModel => DataContext as MainViewModel;

        public MainPage()
        {
            InitializeComponent();
        }
    }
}
