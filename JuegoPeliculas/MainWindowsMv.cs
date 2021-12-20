using Microsoft.Toolkit.Mvvm.ComponentModel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoPeliculas
{

    class MainWindowsMv : ObservableObject
    {
        servicios.ServicioJson servicioJson = new servicios.ServicioJson();

        private String intentoAdivinarUsuario;

        public String IntentoAdivinarUsuario
        {
            get { return IntentoAdivinarUsuario; }
            set { SetProperty(ref intentoAdivinarUsuario, value); }
        }

        private ObservableCollection<Pelicula> listaPeliculas;

        public ObservableCollection<Pelicula> ListaPeliculas
        {
            get { return listaPeliculas; }
            set { SetProperty(ref listaPeliculas, value); }
        }
        private int total;

        public int Total
        {
            get { return total; }
            set
            {
                SetProperty(ref total, value);
            }
        }

        private ObservableCollection<String> dificultad = new ObservableCollection<string>();

        public ObservableCollection<String> Dificultad
        {
            get { return dificultad; }
            set { SetProperty(ref dificultad, value); }
        }

        public void CrearListaDificultad()
        {
            Dificultad.Add("Facil");
            Dificultad.Add("Normal");
            Dificultad.Add("Dificil");
        }

        private ObservableCollection<String> genero = new ObservableCollection<string>();

        public ObservableCollection<String> Genero
        {
            get { return genero; }
            set { SetProperty(ref genero, value); }
        }

        public void CrearListaGeneros()
        {
            Genero.Add("Accion");
            Genero.Add("Drama");
            Genero.Add("Terror");
            Genero.Add("Comedia");
            Genero.Add("Ciencia Ficcion");
        }


        private Pelicula peliculaSeleccionada;

        public Pelicula PeliculaSeleccionada
        {
            get { return peliculaSeleccionada; }
            set { SetProperty(ref peliculaSeleccionada, value); }
        }


        private int actual;

        public int Actual
        {
            get { return actual; }
            set
            {
                SetProperty(ref actual, value);
            }
        }




        /* Mover a un servicio del JSON para que cargue*/

       

        public MainWindowsMv()
        {
           
            CrearListaGeneros();
            CrearListaDificultad();
            ListaPeliculas = servicioJson.CargarJson();
            PeliculaSeleccionada = ListaPeliculas[0];/* Moverlo a la clase partida */
            Total = ListaPeliculas.Count;
            Actual = 1;
        }




        public void Siguiente()
        {
            if (Actual < Total)
            {
                Actual++;
                PeliculaSeleccionada = ListaPeliculas[Actual - 1];
            }
        }

        public void Anterior()
        {
            if (Actual > 1)
            {
                Actual--;
                PeliculaSeleccionada = ListaPeliculas[Actual - 1];
            }
        }

        public void QuitarSeleccion()
        {
            PeliculaSeleccionada = null;
        }


    }
}
