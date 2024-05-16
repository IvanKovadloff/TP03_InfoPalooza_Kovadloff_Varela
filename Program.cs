// See https://aka.ms/new-console-template for more information
//Este program tiene todo lo que tiene que ver con la interface con el usuario /consola
using System.Collections.Generic;
List<string> lista = new List <string>();
int opcion= 0, id=0;
Cliente objcliente= new Cliente();

do{
    opcion = Menú(5, 1);
    switch(opcion){
    case 1: //Agregar cliente
        int dni, tipoentrada, cantidad;
        string nombre, apellido;
        DateTime fechains;
        dni= ObtenerDni();
        nombre = PedirPalabra("Ingrese su nombre: ");
        apellido = PedirPalabra("Ingrese su apellido: ");
        fechains= ObtenerFecha();
        tipoentrada = MenúTipoEntrada(4, 1) ;
        cantidad= ObtenerCantidad();
        objcliente = new Cliente(dni,nombre,apellido,fechains,tipoentrada,cantidad);
        Ticketera.AgregarCliente(objcliente);

    break;
    
    case 2: //Obtener estadisticas
        lista=Ticketera.EstadísticasTicketera();
        foreach(string palabra in lista)
        {
            Console.WriteLine(palabra);
        }
        
    break;
    
    case 3: //Buscar personas
        id=PedirNum("Ingrese el id del cliente que busca: ");
        objcliente=Ticketera.BuscarCliente(id);
        if(objcliente==null)
        {
            Console.WriteLine("Esa persona no existe");
        }
        else
        {
            MostarPersona(objcliente);
        }
    break;

    case 4://Cambiar entrada
        id=PedirNum("Ingrese el id del cliente que busca: ");
        tipoentrada = MenúTipoEntrada(4, 1);
        cantidad= ObtenerCantidad();
        if(Ticketera.CambiarEntrada(id,tipoentrada,cantidad))
        {
            Console.WriteLine("Se realizó el cambio con éxito :)");
        }
        else
        {
            Console.WriteLine("No se pudo realizar el cambio :(");
        }
    
    break;

    case 5://Salir
    break;
    }
}while(opcion !=5);


static int Menú (int maximo, int minimo){
    int opcion= 0;
    do {
        Console.WriteLine("Menú ");
        Console.WriteLine("opciones: ");
        Console.WriteLine("1. Nueva Inscripción. ");
        Console.WriteLine("2. Obtener Estadísticas del Evento.");
        Console.WriteLine("3. Buscar Cliente. ");
        Console.WriteLine("4. Cambiar entrada de un Cliente.  ");
        Console.WriteLine("5. Salir. ");
        opcion = int.Parse(Console.ReadLine());
    }while(opcion<minimo &&opcion>maximo);
    return opcion;
}
static void MostarPersona(Cliente cliente)
    {
        Console.WriteLine($"DNI: {cliente.DNI}");
        Console.WriteLine($"Nombre: {cliente.Nombre}");
        Console.WriteLine($"Apellido: {cliente.Apellido}");
        Console.WriteLine($"Fecha de inscripción: {cliente.FechaIns}");
        Console.WriteLine($"Tipo de entrada:{cliente.TipoEntrada}");
        Console.WriteLine($"Cantidad:{cliente.Cantidad}");
    }
static int PedirNum(string txt){
    int num=0;
    do{
        Console.WriteLine(txt);
        num=int.Parse(Console.ReadLine());

    }while(num<0);
    return num;

 }
static int ObtenerDni(){
        int num=0;
        do{
            Console.WriteLine("Ingrese su DNI: ");
            num=int.Parse(Console.ReadLine());
        }while(num<0);
        return num;
    }
static string PedirPalabra(string txt)
    {
        string palabra;
        do{
        Console.WriteLine(txt);
        palabra = Console.ReadLine();
        }while (palabra == "");
        return palabra; 
    }
static DateTime ObtenerFecha(){
        DateTime f1;
        f1=DateTime.Today;
        return f1;
    }
static int MenúTipoEntrada (int maximo, int minimo){
    int opcion= 0;
    do {
        Console.WriteLine("¿Qué tipo de entrada desea?: ");
        Console.WriteLine("opciones: ");
        Console.WriteLine("1. Día 1 , valor a abonar $45000 ");
        Console.WriteLine("2. Día 2, valor a abonar $60000");
        Console.WriteLine("3. Día 3, valor a abonar $30000");
        Console.WriteLine("4. Full Pass, valor a abonar $100000");
        opcion = int.Parse(Console.ReadLine());
    }while(opcion<minimo &&opcion>maximo);
    return opcion;
    
}
static int ObtenerCantidad(){
         int num=0;
    do{
        Console.WriteLine("Ingrese la cantidad de personas: ");
        num = int.Parse(Console.ReadLine());
    }while(num<0);
    return num;
}
    
 
