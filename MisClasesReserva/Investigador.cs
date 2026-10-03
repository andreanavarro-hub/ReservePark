using System;
using System.Collections.Generic;
using System.Text;

namespace MisClasesReserva
{
}
internal class Researcher : Person
{
    public Researcher(int id, string nombre, string documento, int edad) : base(id, nombre, documento, edad)
    {
        Id = id;
        Name = nombre;
        Documento = documento;
        Edad = edad;
    }

}

