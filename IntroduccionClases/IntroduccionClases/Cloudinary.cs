using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroduccionClases
{
    public class Cloudinary : IArchivo
    {
        public bool SubirArchivo(string base64)
        {
            Console.WriteLine("Subiendo archivo en los servidores de cloudinary...");
            return true;
        }
    }
}
