using System.Collections.Generic;
static class Ticketera{
    static private Dictionary<int, Cliente> DicCliente=new Dictionary<int,Cliente>();
    
    static private int UltimoID =0;
    //Metodos publicos
    static public int DevolverUltID(){
        return UltimoID;
    }

    static public int AgregarCliente(Cliente objcliente)
    {
        bool existe=false;    
        objcliente.SetearNombre();
        objcliente.SetearDni();
        objcliente.SetearApellido();
        objcliente.Apellido=PedirVelocidadYFuerza("Ingresa la fuerza del superheroe:");
        objcliente.FechaIns=PedirVelocidadYFuerza("Ingresa la velocidad del superheroe (0-100):");
        objcliente.TipoEntrada=PedirPesoyInteligencia("Ingresa la inteligencia del superheroe");
        objcliente.Cantidad=0;
        DicCliente.Add(UltimoID,objcliente);
        UltimoID++;
        return UltimoID;
    }

}