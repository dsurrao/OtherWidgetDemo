using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace OtherWidgetDemo
{
    public partial class OtherWidget : ContentView
    {
        public static readonly BindableProperty OptionsProperty = BindableProperty.Create(
            "Options",                // the name of the bindable property
            typeof(List<string>),   // the bindable property type
            typeof(OtherWidget),    // the parent object type
            new List<string>());    // the default value for the property

        public static readonly BindableProperty SelectedOptionProperty = BindableProperty.Create(
            "SelectedOption",                // the name of the bindable property
            typeof(string),   // the bindable property type
            typeof(OtherWidget),    // the parent object type
            "",                 // the default value for the property
            defaultBindingMode: BindingMode.TwoWay); 

        public List<string> Options
        {
            get => (List<string>)GetValue(OtherWidget.OptionsProperty);
            set => SetValue(OtherWidget.OptionsProperty, value);
        }

        public string SelectedOption
        {
            get => (string)GetValue(OtherWidget.SelectedOptionProperty);
            set => SetValue(OtherWidget.SelectedOptionProperty, value);
        }

        public OtherWidget()
        {
            InitializeComponent();
        }

        void picker_SelectedIndexChanged(Object sender, EventArgs e)
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

        void other_TextChanged(Object sender, EventArgs e)
        {
            string otherText = ((Entry)sender).Text;
            if (otherText != null)
            {
                SelectedOption = otherText;
            }
        }
    }
}
