using System;
using WSDL.mensajes;

namespace WSDL.operaciones {
 public class Operaciones : Mensajes{
        ArrayList arreglo = new ArrayList();

      

public class OperacionesMatematicas {
    
    public int Sumar(int a, int b)
    {
        return a + b;
    }

    public int Restar(int a, int b)
    {
        return a - b;
    }

    
    public static void Main(string[] args)
    {
        OperacionesMatematicas operaciones = new OperacionesMatematicas();

        
        int resultadoSuma = operaciones.Sumar(5, 3);
        Console.WriteLine("5 + 3 = " + resultadoSuma);

      
        int resultadoResta = operaciones.Restar(10, 4);
        Console.WriteLine("10 - 4 = " + resultadoResta);

        Console.ReadLine();
    }
}

	}
}
