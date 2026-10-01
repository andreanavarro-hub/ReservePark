using System;
using System.Collections.Generic;
using System.Text;

namespace MisClasesReserva
{
    internal class Recorrido
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = "";
        public int Dificultad { get; set; } = 3;
        public double Costo { get; set; }
        public Guia GuiaACargo { get; set; }
        public List<Visitante> Visitantes { get; set; } = new ();

        public Recorrido (string nombre, double costo, Guia guiaACargo)
        {
            Nombre = nombre;
            Costo = costo;
            GuiaACargo = guiaACargo;

        }

        //Metodo para mostrar visitantes inscritos en el recorrido y mostrar detalles generales
        public string MostrarVisitantes(List<Visitante> Visitantes)
        {

            string personas = $"Listado de visitantes para el recorrido {this.Nombre}";
            foreach(Visitante v in Visitantes)  //Cuidado: Creo que hay que convertir el tipo de visitante a persona (Parsear)
            {
                personas += $"{v.Nombre} {v.Documento}";


            }

            return personas;

        }




    }
}
