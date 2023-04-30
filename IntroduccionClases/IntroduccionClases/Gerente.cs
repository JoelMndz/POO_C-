using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroduccionClases;

public class Gerente: Persona
{
    public double Sueldo { get; set; }

    public void M()
    {
        this.Nombre = "";
        this.Clave = "";
    }
}
