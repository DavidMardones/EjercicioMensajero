using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MensajeroModel.DAL
{
    public class MensajesDALArchivos : IMensajesDAL
    {
        private static string url = Directory.GetCurrentDirectory();
        private static string archivo = url + "/mensajes.txt";
        public void AgregarMensaje(Mensaje mensaje)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(archivo, true))
                {
                    writer.WriteLine(mensaje.Nombre + ";" + mensaje.Texto + ";" + mensaje.Tipo);
                    writer.Flush();
                }
            } catch (Exception ex)
            {

            }
        }

            public List<Mensaje> ObtenerMensajes()
            {

            }
        }
    }

