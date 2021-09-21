using MacroscopTest.Models;
using MacroscopTest.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MacroscopTest.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CamerasListPage : ContentPage
    {
        private CamerasListViewModel camerasListViewModel { get; set; } = new CamerasListViewModel();
        
        public CamerasListPage()
        {
            InitializeComponent();
            this.BindingContext = camerasListViewModel;
        }

        private void updateButton_Clicked(object sender, EventArgs e)
        {
            camerasListViewModel.Update();
        }
    }
}