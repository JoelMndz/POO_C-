// See https://aka.ms/new-console-template for more information

using IntroduccionClases;
/*
Vendedor vendedor = new Vendedor();
vendedor.Sueldo = 500;
vendedor.HorasExtras = 10;

var empleados = new List<Empleado>();
empleados.Add(vendedor);
empleados.Add(new Gerente() { Sueldo = 900, HorasExtras = 20});

//Sueldo el vendedor 540
//Sueldo del gerente 1300
var total = empleados.Sum(x => x.CalcularSueldo());
Console.WriteLine($"Total a pagar = {total}");

IGenerarReporte trabajador = new Vendedor();
trabajador.GenerarReporte();
Console.WriteLine(vendedor.MostrarInformacion());
*/
/*
//Inyeccion de dependencia
IArchivo archivo = new ArchivoLocal();

Api api = new(archivo);

api.SubirImagen("base64:,wkeggUYGUGuygiugy");*/

int divisor, dividendo;
float resultado;

do
{
    try
    {
        Console.WriteLine("Ingresa el dividendo: ");
        dividendo = int.Parse(Console.ReadLine());
        break;
    }
    catch (FormatException)
    {
        Console.WriteLine("Debes ingresar solo números enteros");
    }
    
} while (true);

do
{
    try
    {
        Console.WriteLine("Ingrese el divisor: ");
        divisor = int.Parse(Console.ReadLine());
        break;
    }
    catch (FormatException)
    {
        Console.WriteLine("Debes ingresar solo números enteros");
    }
    catch (Exception error)
    {
        Console.WriteLine(error.Message);
    }

} while (true);


try 
{    
    resultado = dividendo / divisor;
    Console.WriteLine("Resultado ->" + resultado);
}
catch (DivideByZeroException error)
{
    Console.WriteLine("NO puedes dividir para 0");
}