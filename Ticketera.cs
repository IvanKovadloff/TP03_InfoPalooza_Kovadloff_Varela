using System.Collections.Generic;
static class Ticketera{
    static private Dictionary<int, Cliente> DicCliente=new Dictionary<int,Cliente>();
    
    static private int UltimoID =0;

    //cuando crean el metodo Estadisticas, ponen esto dentor del metodo
       //Metodos publicos
    static public int DevolverUltID()
    {
        return UltimoID;
    }
    //4. Agregar Cliente
    static public int AgregarCliente(Cliente objcliente)
    {

        DicCliente.Add(UltimoID,objcliente);
        UltimoID++;
        return UltimoID;
    }
    //5. Buscar cliente
    static public Cliente BuscarCliente(int id)
    {
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
    static public bool CambiarEntrada(int id, int nuevaEntrada, int cant)
    {
        bool puedo=false;
        int entradaVieja;
       
        Cliente cliente=BuscarCliente(id);

        //si el cliente no exites, devielve FALSE
        //si el cliente existe, se fija si púee canmbiar entrada si no tira false
        //si existe el cliente y puede cambiarlas, cambio tipo dentrada y la cantidad

        
        if (cliente != null)
        {
            entradaVieja=cliente.TipoEntrada;
            
            if(nuevaEntrada>entradaVieja) 
            {
                cliente.TipoEntrada=nuevaEntrada;
                cliente.Cantidad=cant;
                puedo=true;
            }
           
        }

        return puedo;

    } 

    static public List<string> EstadísticasTicketera()
    {
        List<string> EstadísticasTicketera = new List<string>();
        double porcentaje1,porcentaje2, porcentaje3, porcentaje4;
        int totalClientes, cantOp1=0 , cantOp2=0, cantOp3=0, cantOp4=0, dineroTotal=0, plataOp1=0, 
            plataOp2=0, plataOp3=0, plataOp4=0, clienteOp1=0, clienteOp2=0, clienteOp3=0, clienteOp4=0;
        //Cantidad de clientes inscriptos
        totalClientes= DicCliente.Count();
        int totalEntradas= 0;
        foreach (Cliente cl in DicCliente.Values)
        {
            totalEntradas += cl.Cantidad;
            switch(cl.TipoEntrada){
                case 1: 
                        cantOp1+=cl.Cantidad;
                        clienteOp1++;
                break;
                
                case 2: 
                    cantOp2+=cl.Cantidad;
                    clienteOp2++;
                break;

                case 3: 
                    cantOp3+=cl.Cantidad;
                    clienteOp3++;
                break;

                case 4: 
                    cantOp4+=cl.Cantidad;
                    clienteOp4++;
                break;

                default:
                break;
            }
        }
        //Recaudacion total y de cada tipo
        plataOp1= cantOp1*45000;
        plataOp2= cantOp2*60000;
        plataOp3= cantOp3*30000;
        plataOp4= cantOp4*100000;
        dineroTotal=plataOp1+plataOp2+plataOp3+plataOp4;
        //Porcentaje de cada tipo de entrada vendida con respecto al total
        porcentaje1=(100*cantOp1)/totalEntradas;
        porcentaje2=(100*cantOp2)/totalEntradas;
        porcentaje3=(100*cantOp3)/totalEntradas;
        porcentaje4=(100*cantOp4)/totalEntradas;
        //Agregar a la lista
        EstadísticasTicketera.Add("La cantidad de los clientes inscriptos es de "+ totalClientes.ToString() +" personas.");
        EstadísticasTicketera.Add("El total de entradas vendidas es de " + totalEntradas.ToString());
        EstadísticasTicketera.Add("El porcentaje de las entradas vendidas del día 1 es del: "+ porcentaje1.ToString() + "%");
        EstadísticasTicketera.Add("El porcentaje de las entradas vendidas del día 2 es del: "+ porcentaje2.ToString() + "%");
        EstadísticasTicketera.Add("El porcentaje de las entradas vendidas del día 3 es del: "+ porcentaje3.ToString() + "%");
        EstadísticasTicketera.Add("El porcentaje de las entradas vendidas del día 4 es del: "+ porcentaje4.ToString() + "%");
        EstadísticasTicketera.Add("La plata que se recaudó del día 1 es de: "+plataOp1.ToString()+ "$");
        EstadísticasTicketera.Add("La plata que se recaudó del día 2 es de: "+plataOp2.ToString()+ "$");
        EstadísticasTicketera.Add("La plata que se recaudó del día 3 es de: "+plataOp3.ToString()+ "$");
        EstadísticasTicketera.Add("La plata que se recaudó del día 4 es de: "+plataOp4.ToString()+ "$");
        EstadísticasTicketera.Add("La plata total que se recaudó es de: "+dineroTotal.ToString()+"$");
        
        return EstadísticasTicketera;
    }
    //7. Estadísticas ticketera


    }
