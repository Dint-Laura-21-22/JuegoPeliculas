using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace JuegoPeliculas
{
    class Partida : ObservableObject
    {
        private bool partidaIniciada;
        private int puntuacion;






        public bool PartidaIniciada
        {
            get { return partidaIniciada; }
            set { SetProperty(ref partidaIniciada, value); }
        }

        public int Puntuacion
        {
            get { return puntuacion; }
            set { SetProperty(ref puntuacion, value); }
        }

        public Partida(bool partidaIniciada, int puntuacion)
        {
            PartidaIniciada = partidaIniciada;
            Puntuacion = puntuacion;
        }
    }
}
