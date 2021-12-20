using Azure.Storage.Blobs;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoPeliculas.servicios
{
    class ServicioAzure
    {
        public const String CONEXIONURL = "DefaultEndpointsProtocol=https;AccountName=juegopeliculaslaura;AccountKey=0vyanB8oq03TsZhqm2tH8ExWHcwoFuggfrBJENjj63rjpXLcQohqx5jd/ZKnjFz8hkTfO6IIsK9RfiqQiq7tGQ==EndpointSuffix=core.windows.net";
        public String SubirImagenNube(string ruta)
        {
            String nombreContenedorAzure = "imagenes";
            String rutaImagen = ruta;

            var cliente = new BlobServiceClient(CONEXIONURL);
            var clienteContenedor = cliente.GetBlobContainerClient(nombreContenedorAzure);

            Stream streamImagen = File.OpenRead(rutaImagen);
            string nombreImagen = Path.GetFileName(rutaImagen);
            try
            {
                clienteContenedor.UploadBlob(nombreImagen, streamImagen);
            }
            catch (Exception e)
            {
                new ServicioDialogo().MostrarMensaje("Se encontro un error", "Error subiendo la imagen a Azure", System.Windows.MessageBoxImage.Error);
            }
            var clienteBlobImagen = clienteContenedor.GetBlobClient(nombreImagen);
            return clienteBlobImagen.Uri.AbsoluteUri;


        }
    }
}
