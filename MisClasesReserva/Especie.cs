using System;
using System.Collections.Generic;
using System.Text;

namespace MisClasesReserva
{
}
internal class Especie
{
    public string NombreComun { get; set; } = "";
    public string NombreCientifico { get; set; } = "";
    public string ReinoBiologico { get; set; } = "";
    public string Estado { get; set; } = "";
    public int Poblacion { get; set; }

    public string MostrarDetalles()
    {

        return $" Detalles de la especie: \nNombre Común: {NombreComun}\nNombre científico: {NombreCientifico}\nReino Biológico: {Estado}\nNombre científico: {Poblacion}";

    }

}
}
