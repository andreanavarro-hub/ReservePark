namespace MisClasesReserva
{
}

public abstract class Persona
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Documento { get; set; }
    public int Edad { get; set; }

    public Persona (int id, string nombre, string documento, int edad)
    {
        Id = id;
        Nombre = nombre;
        Documento = documento;
        Edad = edad;
    }


}

