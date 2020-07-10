using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace AirMonitor.ViewModels
{
    class DetailsViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public DetailsViewModel()
        {

        }
        private int _caqiVal = 123;
        public int CaqiVal
        {
            get => _caqiVal;
            set => SetProperty(ref _caqiVal, value);

        }
        private int _pm25Val = 34;
        public int Pm25Val
        {
            get => _pm25Val;
            set => SetProperty(ref _pm25Val, value);

        }
        private int _pm25PercentVal = 123;
        public int Pm25PercentVal
        {
            get => _pm25PercentVal;
            set => SetProperty(ref _pm25PercentVal, value);

        }
        private int _pm10Val = 34;
        public int Pm10Val
        {
            get => _pm10Val;
            set => SetProperty(ref _pm10Val, value);

        }
        private int _pm10PercentVal = 123;
        public int Pm10PercentVal
        {
            get => _pm10PercentVal;
            set => SetProperty(ref _pm10PercentVal, value);
        }
        private double _humVal = 0.11;
        public double HumVal
        {
            get => _humVal;
            set => SetProperty(ref _humVal, value);
        }
        private int _pressVal = 1000;
        public int PressVal
        {
            get => _pressVal;
            set => SetProperty(ref _pressVal, value);
        }

        private void RaisePropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        private bool SetProperty<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value)) return false;

            field = value;

            RaisePropertyChanged(propertyName);

            return true;
        }
    }
}
