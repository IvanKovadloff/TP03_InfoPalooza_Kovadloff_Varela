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
    //CambiarEntrada: Recibe el Id de la entrada, el tipo de entrada por el cual quiere realizar el cambio y la cantidad. 
    // Debe permitir el cambio solo cuando el importe nuevo sea superior al importe anterior de la compra. 
    //Devuelve true o false si pudo o no realizar el cambio.
    static public bool CambiarEntrada(int id, int entrada, int cant){
        bool puedo=false;
        Cliente cl=BuscarCliente(id);
        //si el cliente no exites, devielve FALSE
        //si el cliente existe, se fija si púee canmbiar entrada si no tira false
        //si existe el cliente y puede cambiarlas, cambio tipo dentrada y la cantidad

        
        if (existe)
        {
            
        }

        return puedo;
        
    } 
    //7. Estadísticas ticketera

}