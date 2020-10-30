using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace OtherWidgetDemo
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        MainPageViewModel _vm;

        public MainPage()
        {
            InitializeComponent();

            _vm = new MainPageViewModel();

            this.BindingContext = _vm;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }
    }    
}
