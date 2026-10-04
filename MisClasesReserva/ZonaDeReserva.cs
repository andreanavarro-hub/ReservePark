using System;
using System.Collections.Generic;
using System.Text;

namespace MisClasesReserva
{
    internal class ZonaDeReserva
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = "";
        public string TipoReserva { get; set; } = "";
        public double Hectareas { get; set; }
        public int NivelProteccion { get; set; }
        public int CapacidadMaxima { get; set; }
        public List<Species> SpeciesList { get; set; } = new();



    }
}
