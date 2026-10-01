using System;
using System.Collections.Generic;
using System.Text;

namespace MisClasesReserva
{
}
internal class Investigador : Persona
{
    public Investigador(int id, string nombre, string documento, int edad) : base(id, nombre, documento, edad)
    {
        Id = id;
        Nombre = nombre;
        Documento = documento;
        Edad = edad;
    }

}

