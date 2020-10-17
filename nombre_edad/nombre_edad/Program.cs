using System;

namespace nombre_edad
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa el nombre");
            String nombre = (Console.ReadLine());
            string [] nombres = { "Juan", "Maria", "Tereza","Pedro", "Javier", "Ana", "Diana","Jorge", "Dayana", "Leidy" };
            int[] edad = { 12, 50, 23, 10, 18, 35, 41, 85, 16, 45};

            Boolean siExisteNombre = false;

            for(int i = 0; i < 10; i++)
            {
                if (nombre == nombres[i])
                {
                    Console.WriteLine("si existe: "+ nombre+" su edad es: "+edad[i]);
                    siExisteNombre = true;
                }
            }

            if (siExisteNombre == false)
            {
                Console.WriteLine("No existe: " + nombre );
            }

            Console.ReadKey();
        }
    }
}
