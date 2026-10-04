using System;
using System.Collections.Generic;
using System.Text;
using MisClasesReserva;

namespace MisClasesReserva;

public class Guide:Person
{
    public Guide (int id, string name, string idCard, int age) : base(id, name, idCard, age)
    {
        Id = id;
        Name = name;
        IdCard = idCard;
        Age = age;
    }
}
