using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroduccionClases;

public class Gerente: Empleado, IGenerarReporte
{
    public override double CalcularSueldo()
    {
        return Sueldo + (HorasExtras * 20);
    }

    public void GenerarReporte()
    {
        Console.WriteLine("Generando reporte...");
    }

    public void M()
    {
        this.Nombre = "";
        this.Clave = "";
    }
}
