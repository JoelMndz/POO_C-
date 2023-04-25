// See https://aka.ms/new-console-template for more information

using IntroduccionClases;
/*
Cliente cliente = new Cliente("Joel","joel@gmail.com","calle 13","29854989",23);

Console.WriteLine(cliente.MotrarInformacion(false, true));
*/
var empresa = new Empresa() {
    Nombre = "AbiDev",
    Email = "abidev@gmail.com",
    Telefono="0986565",
    Direccion = "Calle 13"
};


Console.WriteLine(empresa.Codigo);
