namespace MisClasesReserva;

public abstract class Person
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string IdCard { get; set; }
    public int Age { get; set; }

    public Person (int id, string name, string idCard, int age)
    {
        Id = id;
        Name = name;
        IdCard = idCard;
        Age = age;
    }


}

