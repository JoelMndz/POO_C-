using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroduccionClases;

public class Vendedor : Empleado, IGenerarReporte
{
    public override double CalcularSueldo()
    {
        return this.Sueldo + (HorasExtras * 4);
    }

    public void GenerarReporte()
    {
        Console.WriteLine("Generando reporte...");
    }
}
