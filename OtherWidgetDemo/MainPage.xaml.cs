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
        public MainPage()
        {
            InitializeComponent();

            this.BindingContext = this;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            optionWidget1.Options = new List<string> { "Mon", "Tue", "Wed",
                "Other" };

            optionWidget2.Options = new List<string> { "Jan", "Feb", "Mar",
                "Other" };
        }
    }    
}
