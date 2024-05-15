// See https://aka.ms/new-console-template for more information

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
static int MenúIns (int maximo, int minimo){
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
 Cliente objcliente= new Cliente();
