using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace OtherWidgetDemo
{
    public class MainPageViewModel: INotifyPropertyChanged
    {
        private string _selectedOption1 = "";
        private string _selectedOption2 = "";
        private List<string> _options = new List<string> { "Mon", "Tue", "Thu",
            "Other" };

        public event PropertyChangedEventHandler PropertyChanged;

        public MainPageViewModel()
        {
        }

        public string SelectedOption1
        {
            get
            {
                return _selectedOption1;
            }

            set
            {
                if (_selectedOption1 != value)
                {
                    _selectedOption1 = value;
                    OnPropertyChanged("SelectedOption1");
                }
            }
        }

        public string SelectedOption2
        {
            get
            {
                return _selectedOption2;
            }

            set
            {
                if (_selectedOption2 != value)
                {
                    _selectedOption2 = value;
                    OnPropertyChanged("SelectedOption2");
                }
            }
        }

        public List<string> Options
        {
            get
            {
                return _options;
            }

            set
            {
                if (_options != value)
                {
                    _options = value;
                    OnPropertyChanged("Options");
                }
            }
        }

        protected virtual void OnPropertyChanged(string propertyName = "")
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}

