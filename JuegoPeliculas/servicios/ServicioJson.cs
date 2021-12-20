using Microsoft.Toolkit.Mvvm.ComponentModel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoPeliculas.servicios
{
    class ServicioJson:ObservableObject
    {

        public  ObservableCollection<Pelicula> CargarJson()
        {
            ObservableCollection<Pelicula> listaPeliculas = new ObservableCollection<Pelicula>();
            String peliculasJson = File.ReadAllText("peliculas.json");
            listaPeliculas = JsonConvert.DeserializeObject<ObservableCollection<Pelicula>>(peliculasJson);
            return listaPeliculas;
        }
    }
}
