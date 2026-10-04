using MisClasesReserva;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace MisClasesReserva
{
}
internal class Visitante : Person
{
    public Tiquete TiqueteVisitante { get; set; }
    public bool EsEstudiante { get; set; }
    public string Categoria { get; private set; }

    public Visitante(Tiquete tiqueteVisitante, int id, string nombre, string documento, int edad) : base(id, nombre, documento, edad)
    {
        TiqueteVisitante = new Tiquete(documento);
        Name = nombre;
        Id = id;
        IdCard = documento;
        Age = edad;
    }

}
