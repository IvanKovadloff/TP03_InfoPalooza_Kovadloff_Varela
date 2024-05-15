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
    public DateTime ObtenerFecha(){
        DateTime f1;
        f1=DateTime.Today;
        return f1;
    }
    public int MenúTipoEntrada (int maximo, int minimo){
    int opcion= 0;
    do {
        Console.WriteLine("Menú ");
        Console.WriteLine("opciones: ");
        Console.WriteLine("1. Día 1 , valor a abonar $45000 ");
        Console.WriteLine("2. Día 2, valor a abonar $60000");
        Console.WriteLine("3. Día 3, valor a abonar $30000");
        Console.WriteLine("4. Full Pass, valor a abonar $100000");
        opcion = int.Parse(Console.ReadLine());
    }while(opcion<minimo &&opcion>maximo);
    return opcion;
    
}
    public int ObtenerCantidad(){
         int num=0;
    do{
        Console.WriteLine("Ingrese la cantidad de personas: ");
        num = int.Parse(Console.ReadLine());
    }while(num<0);
    return num;
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
    public void SetearFecha(){
        FechaIns = ObtenerFecha();
    }
    public void SetearEntrada(){
        TipoEntrada = MenúTipoEntrada(4,1);
    }
    public void SetearCantidad(){
        Cantidad=ObtenerCantidad();
    }
}
