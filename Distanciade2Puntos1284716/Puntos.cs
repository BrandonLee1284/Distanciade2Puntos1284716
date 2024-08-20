using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Distanciade2Puntos1284716
{
    internal class Puntos : INotifyPropertyChanged
    {
        private double _punto1X;
        private double _punto1Y;
        private double _punto2X;
        private double _punto2Y;
        private string _resultado;

        public double Punto1X
        {
            get => _punto1X;
            set
            {
                if (_punto1X != value)
                {
                    _punto1X = value;
                    OnPropertyChanged();
                }
            }
        }

        public double Punto1Y
        {
            get => _punto1Y;
            set
            {
                if (_punto1Y != value)
                {
                    _punto1Y = value;
                    OnPropertyChanged();
                }
            }
        }

        public double Punto2X
        {
            get => _punto2X;
            set
            {
                if (_punto2X != value)
                {
                    _punto2X = value;
                    OnPropertyChanged();
                }
            }
        }

        public double Punto2Y
        {
            get => _punto2Y;
            set
            {
                if (_punto2Y != value)
                {
                    _punto2Y = value;
                    OnPropertyChanged();
                }
            }
        }

        public string Resultado
        {
            get => _resultado;
            set
            {
                if (_resultado != value)
                {
                    _resultado = value;
                    OnPropertyChanged();
                }
            }
        }

        public ICommand CalcularDistanciaCommand { get; }

        public Puntos()
        {
            CalcularDistanciaCommand = new Command(CalcularDistancia);
        }

        private void CalcularDistancia()
        {
            Punto punto1 = new Punto(Punto1X, Punto1Y);
            Punto punto2 = new Punto(Punto2X, Punto2Y);

            double distancia = Distancias.CalcularDistancia(punto1, punto2);

            Resultado = $"La distancia entre los puntos es: {distancia:F2}";
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

