// See https://aka.ms/new-console-template for more information
int opcion= 0, id=0;
Cliente objcliente= new Cliente();
do{
    opcion = Menú(5, 1);
    switch(opcion){
    case 1: //Agregar cliente
        Ticketera.AgregarCliente(objcliente);
        
    break;
    
    case 2: //Obtener estadisticas

    break;
    
    case 3: //Buscar personas
    id=PedirNum("Ingrese el id del cliente que busca");
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
