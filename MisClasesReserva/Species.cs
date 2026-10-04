using System;
using System.Collections.Generic;
using System.Text;

namespace MisClasesReserva;

public class Species
{
    public string CommonName { get; set; } = "";
    public string ScientificName { get; set; } = "";
    public string Kingdom { get; set; } = "";
    public string ConservationStatus { get; set; } = "";
    public int Population { get; set; }

    public string ShowDetails()
    {

        return $" Detalles de la especie: \nNombre Común: {CommonName}\nNombre científico: {ScientificName}\nReino Biológico: {ConservationStatus}\nNombre científico: {Population}";

    }

}

