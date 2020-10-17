using System;

namespace tabla_multiplicar_2_9
{
    class Program
        //Este programa lo hacemos un for anidado esto quiere decir que tenemos unfor dentro de otro for
         //El primer for instanciamos una variable del numero de tabla que es el que recorre tabla por tabla del 2 al 9
         //El segundo for recorre cada tabla
         //Por ultimo se lee en consola la tabla 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("tablas del 2 al 9");

            for (int nTabla = 2; nTabla < 10; nTabla++)
            {
                for (int i = 1; i < 11; i++)
                {
                    Console.WriteLine( nTabla + "X" + i + "=" + nTabla * i );
                }

                Console.WriteLine("");
            }
        }
    }
}
