using System;

class Menu
{
    static void Main(string[] args)
    {
        bool continuar = true;
        while (continuar)
        {
            Console.Clear();
            Console.WriteLine("Ventas Varias ===");
            Console.WriteLine("1. Transitores");
            Console.WriteLine("2. Capacitadores");
            Console.WriteLine("3. Leds");
            Console.WriteLine("4. Salir");
            Console.WriteLine("=====================");
            Console.WriteLine("Seleccione una opcion ");

            string opcion = Console.ReadLine();
            switch (opcion)
            {
                case "1":
                    Console.WriteLine("has seleccionado la Opcion 1.");
                    //Logica para la opcion 1
                    break;

                case "2":
                    Console.WriteLine("Has seleccionado la opcion 2.");
                    //Logica para la opcion 2
                    break;

                case "3":
                    Console.WriteLine("Has seleccionado la opcion 3.");
                    //Logica para la opcion 3
                    break;
                case "4":
                    Console.WriteLine("Saliendo del Programa......");
                    continuar = false;
                    break;

                default:
                    Console.WriteLine("Opcion no valida. Intente de nuevo");
                    break;

            }

            if (continuar)
            {
                Console.WriteLine("Presione cualquier para continuar... ");
                Console.ReadKey();
            }

        }
    }
}