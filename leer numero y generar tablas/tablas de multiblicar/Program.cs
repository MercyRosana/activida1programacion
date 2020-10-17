using System;

namespace tablas_de_multiblicar
{
    class Program
       
        
       
       
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese numero del cual quiere multiplicar");
            //Pide al usuario que ingrese el numero de la tabla que desea multiplicar

            int tabla = Convert.ToInt32(Console.ReadLine());
            //crear una variable de tipó int le asigno el nombren de tabla

            for (int i = 1; i < 11; i++)
            //hacer un for que nos recorre las tablas de multiplicar del 1 al 11
            {
                Console.WriteLine ( tabla + "X" + i + "=" + tabla * i);
                //Modtrar en consola tabla X el contador = tabla * contador que es el resultado
            }






        }
    }
}
