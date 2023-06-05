using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroduccionClases
{
    public class ArchivoLocal : IArchivo
    {
        public bool SubirArchivo(string base64)
        {
            Console.WriteLine("Guardando en local el archivo");
            return true;
        }
    }
}
