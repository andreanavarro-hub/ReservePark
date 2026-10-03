using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace MisClasesReserva
{
}
internal class Researcher : Person
{
    public Researcher(int id, string name, string IdCard, int Age) : base(id,name, IdCard, Age)
    {
        Id = id;
        Name = name;
        IdCard = idCard;
        Age = edad;
    }

}

