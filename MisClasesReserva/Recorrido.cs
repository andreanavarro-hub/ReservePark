using System;
using System.Collections.Generic;
using System.Text;

namespace MisClasesReserva
{
    internal class Tour
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public int Dificulty { get; set; } = 3;
        public double Price { get; set; }
        public Guide GuideInCharge { get; set; }
        public List<Visitante> Visitors { get; set; } = new ();

        public Tour(string name, double price, Guide guideInCharge)
        {
            Name = name;
            Price = price;
            GuideInCharge = guideInCharge;

        }


        public string MostrarVisitantes(List<Visitante> Visitantes)
        {

            string personas = $"Listado de visitantes para el recorrido {this.Name}";
            foreach(Visitante v in Visitantes)  //Cuidado: Creo que hay que convertir el tipo de visitante a persona (Parsear)
            {
                personas += $"{v.Name} {v.IdCard}"; //Cambiar esto


            }

            return personas;

        }




    }
}
