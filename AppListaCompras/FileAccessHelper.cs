using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using UIKit;

namespace AppListaCompras
{
    public class FileAccessHelper
    {
        public static string GetLocalFilePath(string filename)
        {
            //Lineas para hacer copea de la base de datos en ruta local del celular
            /*string RutaDest = System.IO.Path.Combine("/storage/emulated/0/Android/data/com.companyname.applistacompras/files/",filename);  //System.IO.Path.Combine(FileSystem.AppDataDirectory, filename);
            
            try
            {
                using (FileStream sourceStream = File.OpenRead(System.IO.Path.Combine(FileSystem.AppDataDirectory, filename)))
                {
                    using (FileStream destStream = File.Create(RutaDest))
                    {
                        sourceStream.CopyTo(destStream);
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejar excepciones
                Console.WriteLine($"Error al copiar el archivo: {ex.Message}");
            }*/
            return System.IO.Path.Combine(FileSystem.AppDataDirectory, filename);
        }
    }
}
