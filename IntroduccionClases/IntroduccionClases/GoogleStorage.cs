using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroduccionClases
{
    public class GoogleStorage: IArchivo
    {
        public bool SubirArchivo(string base64)
        {
            Console.WriteLine("Subiendo archivo en los servidores de google storage...");
            return true;
        }
    }
}
