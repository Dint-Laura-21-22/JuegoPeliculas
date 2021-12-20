using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace JuegoPeliculas.servicios
{
    class ServicioDialogo
    {
        public ServicioDialogo()
        {
        }

        public enum tipoArchivo { JSON, Imagen };



        public string ObtenerRutaArchivoLocal(in tipoArchivo tipo)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            string ruta = "";
            switch (tipo)
            {
                case tipoArchivo.JSON:
                    openFileDialog.Filter = "Archivos JSON(*.json)|*.json";
                    break;
                case tipoArchivo.Imagen:
                    openFileDialog.Filter = "Imagen JPEG(*.jpeg)|*.jpeg|Imagen JPG(*.jpg)|*.jpg";
                    break;
            }
            if (openFileDialog.ShowDialog() == true)
                ruta = Path.GetFullPath(openFileDialog.FileName);
            return ruta;

        }
        public string ObtenerRutaArchivoGuardar(in tipoArchivo tipo)
        {

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            string ruta = "";
            switch (tipo)
            {
                case tipoArchivo.JSON:
                    saveFileDialog.Filter = "Archivos JSON(*.json)|*.json";
                    break;
                case tipoArchivo.Imagen:
                    saveFileDialog.Filter = "Imagen JPEG(*.jpeg)|*.jpeg|Imagen JPG(*.jpg)|*.jpg";
                    break;
            }
            if (saveFileDialog.ShowDialog() == true)
                ruta = Path.GetFullPath(saveFileDialog.FileName);

            return ruta;

        }
        public void MostrarMensaje(in string texto, in string tituloVentana, in MessageBoxImage icono)
        {

            MessageBox.Show(texto, tituloVentana, MessageBoxButton.OK, icono);

        }
    }
}
