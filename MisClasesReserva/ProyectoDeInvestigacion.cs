using System;
using System.Collections.Generic;
using System.Text;

namespace MisClasesReserva
{
}
internal class ProyectoDeInvestigacion
{
    public int Id { get; set; }
    public string Nombre { get; set; } = "";
    public DateTime FechaIncicio { get; set; } //Por defecto
    public DateTime FechaFinalizacion { get; set; } // Por defecto
    public List<Investigador> Investigadores { get; set; } // Requerido
    public List<Especie> EspeciesInvestigadas { get; set; } //Se instancia la lista

    public ProyectoDeInvestigacion(string nombre, List<Investigador> investigadores)
    {
        Nombre = nombre;
        Investigadores = investigadores;
        EspeciesInvestigadas = new List<Especie>();

    }
}