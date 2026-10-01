namespace MisClasesReserva;

public abstract class Person
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Documento { get; set; }
    public int Edad { get; set; }

    public Person (int id, string nombre, string documento, int edad)
    {
        Id = id;
        Nombre = nombre;
        Documento = documento;
        Edad = edad;
    }


}

