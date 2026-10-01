using MisClasesReserva;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MisClasesReserva
{
}
internal class Visitante : Persona
{
    public Tiquete TiqueteVisitante { get; set; } //En constructor se instancia porque requiere de los datos
    public bool EsEstudiante { get; set; }
    public string Categoria { get; private set; }

    public Visitante(Tiquete tiqueteVisitante, int id, string nombre, string documento, int edad) : base(id, nombre, documento, edad)
    {
        TiqueteVisitante = new Tiquete(documento);
        Nombre = nombre;
        Id = id;
        Documento = documento;
        Edad = edad;
    }

    public DeterminarCategoria(int Edad, ) //Fecha nacicimiento ??
    { }



}
