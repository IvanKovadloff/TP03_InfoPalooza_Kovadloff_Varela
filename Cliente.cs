//esta clase tiene todo lo que tiene que ver con 1 CLiente. Guarda la informacion de un cliente. 
//no le importa ni conoce si usan consola

class Cliente{
//Propiedades
    public int DNI{get; private set;}
    public string Nombre{get; private set;}
    public string Apellido{get; private set;}
    public DateTime FechaIns{get; set;}
    public int TipoEntrada{get; set;}
    public int Cantidad{get; set;}

    //Constructor vacio
    public Cliente( ){ }
    //Constructor con parametros
    public Cliente(int dni, string nombre, string apellido, DateTime fechains, int tipoentrada, int cantidad )
    {
        DNI= dni;
        Nombre= nombre;
        Apellido= apellido;
        FechaIns= fechains;
        TipoEntrada= tipoentrada;
        Cantidad= cantidad;
    }
   
}

