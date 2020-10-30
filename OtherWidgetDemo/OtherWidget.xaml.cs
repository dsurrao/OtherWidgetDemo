using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace OtherWidgetDemo
{
    public partial class OtherWidget : ContentView
    {
        private string _selectedOption;

        public static readonly BindableProperty OptionsProperty = BindableProperty.Create(
            "Options",                // the name of the bindable property
            typeof(List<string>),   // the bindable property type
            typeof(OtherWidget),    // the parent object type
            new List<string>());    // the default value for the property

        public List<string> Options
        {
            get => (List<string>)GetValue(OtherWidget.OptionsProperty);
            set => SetValue(OtherWidget.OptionsProperty, value);
        }

        public string SelectedOption
        {
            get
            {
                return _selectedOption;
            }

            set
            {
                if (_selectedOption != value)
                {
                    _selectedOption = value;
                    OnPropertyChanged("SelectedOption");
                }
            }
        }

        public OtherWidget()
        {
            InitializeComponent();
            this.BindingContext = this;
        }

        void picker_SelectedIndexChanged(System.Object sender, System.EventArgs e)
        {
            object selectedItem = ((Picker)sender).SelectedItem;
            if (selectedItem != null)
            {                
                if (selectedItem.Equals("Other"))
                {
                    SelectedOption = "";
                    other.IsEnabled = true;
                }
                else
                {
                    SelectedOption = (string)selectedItem;
                    other.IsEnabled = false;
                }

                other.Text = null; // clear text field
            }
        }

        void other_TextChanged(System.Object sender, System.EventArgs e)
        {
            string otherText = ((Entry)sender).Text;
            if (otherText != null)
            {
                SelectedOption = otherText;
            }
        }
    }
}
