using System.Collections.Generic;
static class Ticketera{
    static private Dictionary<int, Cliente> DicCliente=new Dictionary<int,Cliente>();
    
    static private int UltimoID =0;
    //Metodos publicos
    static public int DevolverUltID(){
        return UltimoID;
    }
    //4. Agregar Cliente
    static public int AgregarCliente(Cliente objcliente)
    {
        bool existe=false;   
        objcliente.SetearDni(); 
        objcliente.SetearNombre();
        objcliente.SetearApellido();
        objcliente.ObtenerFecha();
        objcliente.SetearEntrada();
        objcliente.SetearCantidad();
        DicCliente.Add(UltimoID,objcliente);
        UltimoID++;
        return UltimoID;
    }
    //5. Buscar cliente
    static public Cliente BuscarCliente(int id){
        if(DicCliente.ContainsKey(id))
        {
        return DicCliente[id];
        }
        else
        {
        return null;
        }
        
    }
    //6. Cambiar entrada
    static public bool CambiarEntrada(int id, int entrada, int cant){
        bool puedo=false;
        bool existe=DicCliente.ContainsKey(id);
        
        
        if (existe)
        {
            
        }

        return puedo;
        
    } 
    //7. Estadísticas ticketera

}