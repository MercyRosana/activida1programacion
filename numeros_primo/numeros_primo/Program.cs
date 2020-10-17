using System;

namespace numeros_primo
{
    class Program
        //Declaramos una variable tipo int para igresar el numero, y una variable de tipo bool para la validacion
        //hacemos un for que rrecorre los numeros menores del numero ingresado 
        //un if anidado para para la validacion del numero primo
        //Por ultimo un else para indicar que no es numero primo
    {
        static void Main(string[] args)
        {
            int numero;
            bool validacion = false;
            Console.WriteLine("ingrese el numero para evaluar si es primo o no");
            numero =Int32.Parse( Console.ReadLine());


            for (int i = 2; i < numero; i++)
            {
               if  ((numero % i)==0)
                {
                    validacion = true;
                }
            }

            if (validacion == false)
            {
                Console.WriteLine("si es primo");
            }
            else
            {
                Console.WriteLine("no es primo");
            }

        }
    }
}
