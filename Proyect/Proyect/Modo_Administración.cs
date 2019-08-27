using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyect
{
    class Modo_Administración
    {
        public int opcion,cantidad1=100,cantidad2=100,cantidad3=100;
        public double precio_bebida1=0.60,precio_bebida2=0.60,precio_bebida3=0.60;
        public void Administracion()
        {
            Console.Clear();
            Console.SetWindowSize(80, 40);
            Console.Write("--------------------------------------------------------------------------------");
            Console.SetCursorPosition(2, 2);
            Console.WriteLine("1. Administrar bebidas   2. Administrar monedas   3. Administrar billetes");
            Console.Write("--------------------------------------------------------------------------------");
            Console.SetCursorPosition(40, 4);
            opcion = Convert.ToInt32(Console.ReadLine());
            Console.Write("════════════════════════════════════════════════════════════════════════════════");
            if (opcion == 1)
            {
                Console.SetCursorPosition(34, 7);
                Console.WriteLine("B E B I D A S");
                Console.SetCursorPosition(2, 9);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Coca Cola, Sprite, Fanta, Pepsi, H20");
                Console.SetCursorPosition(2, 11);
                Console.WriteLine("Cantidad:");
                Console.SetCursorPosition(11, 11);
                cantidad1 = Convert.ToInt32(Console.ReadLine());
                Console.SetCursorPosition(2, 12);
                Console.WriteLine("Precio:");
                Console.SetCursorPosition(11, 12);
                precio_bebida1 = Convert.ToDouble(Console.ReadLine());
                Console.SetCursorPosition(2, 14);
                Console.WriteLine("RedBull");
                Console.SetCursorPosition(2, 16);
                Console.WriteLine("Cantidad:");
                Console.SetCursorPosition(11, 16);
                cantidad2 = Convert.ToInt32(Console.ReadLine());
                Console.SetCursorPosition(2, 17);
                Console.WriteLine("Precio:");
                Console.SetCursorPosition(11, 17);
                precio_bebida2 = Convert.ToDouble(Console.ReadLine());
                Console.SetCursorPosition(2, 19);
                Console.WriteLine("Fanta");
                Console.SetCursorPosition(2, 21);
                Console.WriteLine("Cantidad:");
                Console.SetCursorPosition(11, 21);
                cantidad3=Convert.ToInt32(Console.ReadLine());
                Console.SetCursorPosition(2, 23);
                Console.WriteLine("Precio:");
                Console.SetCursorPosition(11, 24);
                precio_bebida3 = Convert.ToDouble(Console.ReadLine());
                Console.ResetColor();
            }
            Console.ReadKey();

        }
        
    }
}
