using MisClasesReserva;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace MisClasesReserva
{
}
public class Researcher : Person
{
    public Researcher(int id, string name, string idCard, int age) : base(id,name, idCard, age)
    {
        Id = id;
        Name = name;
        IdCard = idCard;
        Age = age;
    }

}

