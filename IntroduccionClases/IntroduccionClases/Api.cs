using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroduccionClases
{
    public class Api
    {
        IArchivo archivo;
        public Api(IArchivo archivo)
        {
            this.archivo = archivo;
        }

        public void SubirImagen(string base64)
        {
            archivo.SubirArchivo(base64);
        }
    }
}
