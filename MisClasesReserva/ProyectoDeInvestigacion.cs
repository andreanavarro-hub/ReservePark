using MisClasesReserva;
using System;
using System.Collections.Generic;
using System.Text;

namespace MisClasesReserva
{
}
internal class ProyectoDeInvestigacion
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public DateTime FechaIncicio { get; set; } //Por defecto
    public DateTime FechaFinalizacion { get; set; } // Por defecto
    public List<Researcher> Investigadores { get; set; } // Requerido
    public List<Species> EspeciesInvestigadas { get; set; } //Se instancia la lista

    public ProyectoDeInvestigacion(string nombre, List<Researcher> investigadores)
    {
        Name = nombre;
        Investigadores = investigadores;
        EspeciesInvestigadas = new List<Species>();

    }
}