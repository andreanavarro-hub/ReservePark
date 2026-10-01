using System;
using System.Collections.Generic;
using System.Text;

namespace MisClasesReserva
{
}
internal class Tiquete
{
    public int Id { get; set; } = 0; //Generar aleat.
    public string Documento { get; set; }
    public DateTime Fecha { get; set; }

    public Tiquete(string documento)
    {
        Documento = documento;

    }

}
