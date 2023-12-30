using System;

using GEPM_Tool.ViewModels;

using Windows.UI.Xaml.Controls;

namespace GEPM_Tool.Views
{
    public sealed partial class ToolsPage : Page
    {
        private ToolsViewModel ViewModel => DataContext as ToolsViewModel;

        public ToolsPage()
        {
            InitializeComponent();
        }
    }
}
