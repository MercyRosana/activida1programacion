using System;

namespace par_o_impar
{
    class Program
        //EXPLICACION:
        //Lo primero es declarar una variable para almacenar el numero ingresado por el usuario
        //variable de tipo int llamada numero
        //Luego solicitamos que ingrese un numero
        // hacemos la conversion de tipo int
        //hacemos un if  si es divisor es 2 o  igual a cero es par
        //Si no se cumple esta condicion con else que nos diga que es impar
    {
        static void Main(string[] args)
        {
            int numero;
           
            Console.WriteLine("ingrese numero");
            numero = Convert.ToInt32(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine("es un numero par");
            }
            else
            {
                Console.WriteLine("es un numero impar");
            }

        }
    }
}
