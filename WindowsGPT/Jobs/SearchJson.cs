using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsGPT.Jobs
{

    class SearchJson
    {
        public static Dictionary<string, string> LeerDiccionarioDesdeJSON()
        {
            // Directorio base del proyecto
            //string directorioBase = AppDomain.CurrentDomain.BaseDirectory;
            string rutaCompleta = @"\dictionaryData.json";
            //string nombreArchivo = Path.GetRelativePath(Environment.CurrentDirectory, rutaCompleta);

            if (File.Exists(rutaCompleta))
            {
                string json = File.ReadAllText(rutaCompleta);
                return JsonConvert.DeserializeObject<Dictionary<string, string>>(json);
            }
            else
            {
                // Si el archivo no existe, retornar un diccionario vacío
                return new Dictionary<string, string>();
            }
        }
    }
}
