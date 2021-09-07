using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primera.Interfaz
{
    public class JuntaNombre : INotifyPropertyChanged
    {
        private string nombre, apellido, nombre_completo;

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }

        public string Nombre
        {
            get { return Nombre; }
            set { Nombre = value;

                OnPropertyChanged("Nombre_Completo");
            }


        }

        public string Apellido
        {
            get { return Apellido; }
            set { Apellido = value;
                OnPropertyChanged("Nombre_Completo");
            }
        }

        public string Nombre_Completo
        {
            get { nombre_completo = Nombre + " " + Apellido; return nombre_completo; }
            set { }
        }
    }
}
