using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroduccionClases;

public class Cliente
{
    public string nombre;
    public string email;
    public string direccion;
    public string telefono;
    public int edad;

    public Cliente()
    {
        nombre = "por defecto";
    }

    public Cliente(string nombre, string email, string direccion, string telefono, int edad)
    {
        this.edad = edad;
        this.email = email;
        this.nombre= nombre;
        this.direccion =direccion;
        this.telefono = telefono;
    }
}
