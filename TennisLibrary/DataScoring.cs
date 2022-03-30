using System;
using System.Windows;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace TennisLibrary
{
   public  class DataScoring : INotifyPropertyChanged
    {



        public  Jugador jugador1;
        public  Jugador jugador2;

        
        public String NombreJ1 { get { return jugador1.Nombre; }  }
        public int SetsJ1 { get { return jugador1.Sets; }  }
         public string PuntuacionJ1 { get { return jugador1.Puntuacion; } }
        public String NombreJ2 { get { return jugador2.Nombre; } }
        public int SetsJ2 { get { return jugador2.Sets; }  }
        public string PuntuacionJ2 { get { return jugador2.Puntuacion; } }



        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string property)
        {
           
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            
        }
        public void InitGame(string nombre1, string nombre2)
        {
            jugador1 = new Jugador(nombre1,1);
            jugador2 = new Jugador(nombre2,2);
        }
        public  void AugmentarPuntuación(Jugador ganador, Jugador perdedor)
        {

            ganador.Augmentarpuntuación(perdedor);
            var a= PuntuacionJ1;
           

        }
        public  string Something()
        {

            return "Algo";
        }
    }
}

