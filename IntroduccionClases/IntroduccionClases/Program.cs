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

//Inyeccion de dependencia
IArchivo archivo = new ArchivoLocal();

Api api = new(archivo);

api.SubirImagen("base64:,wkeggUYGUGuygiugy");