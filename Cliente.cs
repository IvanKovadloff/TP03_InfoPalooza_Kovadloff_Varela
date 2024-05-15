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
    public Cliente(int dni, string nombre, string apellido, DateTime fechains, int tipoentrada, int cantidad ){
        DNI= dni;
        Nombre= nombre;
        Apellido= apellido;
        FechaIns= fechains;
        TipoEntrada= tipoentrada;
        Cantidad= cantidad;
    }
    public int ObtenerDni(){
        int num=0;
        do{
            Console.WriteLine("Ingrese su DNI: ");
            num=int.Parse(Console.ReadLine());
        }while(num<0);
        return num;
    }
    public string PedirPalabra(string txt)
    {
        string palabra;
        do{
        Console.WriteLine(txt);
        palabra = Console.ReadLine();
        }while (palabra == "");
        return palabra; 
    }
    public void SetearDni(){
        DNI = ObtenerDni();
    }
    public void SetearNombre(){
        Nombre = PedirPalabra("Ingrese su nombre: ");
    }
    public void SetearApellido(){
        Apellido = PedirPalabra("Ingrese su apellido: ");
    }
    public DateTime ObtenerFecha(){
        bool pude=false;
        string fecha;
        DateTime f1;
        do
        {
            Console.WriteLine();
            fecha= Console.ReadLine();
            pude=DateTime.TryParse(fecha,out f1);
        }while(!pude);
        return f1;
    }
}
