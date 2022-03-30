using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace TennisLibrary
{
    public class Jugador 
    {
        private string nombre;
        private  readonly string[] puntuacion = { "0", "15", "30", "40", "dos iguales", "ventaja", "desventaja", "Game", "Losed" };
        private readonly List<String> Historico=new List<string>();
        private int sets;
        private int jugadasGanadas;
        private int numTituloPuntuación;
        private bool limpiarset;
        public String Nombre { get { return nombre; } set { nombre = value; } }
        public int Sets { get { return sets; } set { sets = value; } }
        public int NumTituloPuntuación { get { return numTituloPuntuación; } set { numTituloPuntuación = value; } }
        public int JugadasGanadas { get { return jugadasGanadas; } set { jugadasGanadas = value; } }
        public string Puntuacion { get { return puntuacion[NumTituloPuntuación]; } }

        int numPlayer;
        public Jugador(string Nombre,int numPlayer)
        {
            this.Nombre = Nombre;
            Sets = 0;
            jugadasGanadas = 0;
            NumTituloPuntuación = 0;
            numPlayer = this.numPlayer;
        }

       
        public void Augmentarpuntuación(Jugador otrojugador)
        {

            if (limpiarset == true)
            {
                NuevoSet(otrojugador);
                limpiarset = false;
            }
            JugadasGanadas=JugadasGanadas+1;
            
            if (JugadasGanadas < 4 && otrojugador.JugadasGanadas < 4)
            { if (JugadasGanadas == otrojugador.JugadasGanadas)
                {
                    NumTituloPuntuación = 4;
                }
                else { 
                NumTituloPuntuación = JugadasGanadas;
            }
                otrojugador.TituloP(this.JugadasGanadas);
            }
            else if (JugadasGanadas == 4 && otrojugador.JugadasGanadas < 2)
            {
                NumTituloPuntuación = 7;
                GanaSet(otrojugador);
            }


            else if (JugadasGanadas >= 4 && otrojugador.JugadasGanadas == JugadasGanadas)
            {
                NumTituloPuntuación = 4;
                otrojugador.TituloP(this.JugadasGanadas);
            }
            else if (JugadasGanadas >= 4 && otrojugador.JugadasGanadas == JugadasGanadas - 1)
            {
                NumTituloPuntuación = 5;
                otrojugador.TituloP(this.JugadasGanadas);
            }
            else
            {
                NumTituloPuntuación = 7;
                GanaSet(otrojugador);
            }
           // OnPropertyChanged("PuntuacionJ"+numPlayer);
           // OnPropertyChanged("PuntuacionJ" + numPlayer);
        }
        public void TituloP(int jg2)
        {
            if (limpiarset == true)
            {
                
                limpiarset = false;
            }
            Console.WriteLine("Jugadas 1:" + JugadasGanadas + "Jugadas 2:" + jg2);
            if (jg2 == JugadasGanadas)
            {
                NumTituloPuntuación = 4;

            }
            else if (jg2 > JugadasGanadas + 2 && JugadasGanadas > 4)
            {

                NumTituloPuntuación = 8;
            }
            else if (jg2 == JugadasGanadas + 1 && JugadasGanadas > 4)
            {

                NumTituloPuntuación = 6;
            }
            else if (JugadasGanadas < 4 && JugadasGanadas != jg2) {

                NumTituloPuntuación = jugadasGanadas;
            }
           


        }
        public void GanaSet(Jugador otrojugador)
        {
            // animacion set ganado
            sets++;
            otrojugador.PierdeSet();
            limpiarset = true;
        }

        public void PierdeSet()
        {
           
            NumTituloPuntuación = 8;
            limpiarset = true;
        }
        public void NuevoSet(Jugador otrojugador)
        {
            Historico.Add(puntuacion[NumTituloPuntuación]);
            JugadasGanadas = 0;
            otrojugador.jugadasGanadas = 0;
            NumTituloPuntuación = 0;
            otrojugador.NumTituloPuntuación = 0;
        }

    }
}
