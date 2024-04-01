public class Customer
{
    // Atributos
    private string nombre;
    private string apellido;
    private string dni;

    // Constructor
    public Customer(string nombre, string apellido, string dni)
    {
        this.nombre = nombre;
        this.apellido = apellido;
        this.dni = dni;
    }

    // Propiedades
    public string Nombre
    {
        get { return nombre; }
        set { nombre = value; }
    }

    public string Apellido
    {
        get { return apellido; }
        set { apellido = value; }
    }

    public string Dni
    {
        get { return dni; }
        set { dni = value; }
    }
}
