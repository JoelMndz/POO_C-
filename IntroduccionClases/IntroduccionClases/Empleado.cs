using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroduccionClases;

public abstract class Empleado:Persona
{
    public double Sueldo { get; set; }
    public int HorasExtras { get; set; }

    public abstract double CalcularSueldo();
}
