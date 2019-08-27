using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyect
{
   
    class Impresión
    {
        public void Imprimir(){
            Console.SetWindowSize(81, 57);
            Console.WriteLine("┌──────────────────────────────────────────────────────────────────────────────┐");
            for (int i = 0; i < 5; i++)
            {
            Console.WriteLine("│                                                                              │");   
            }
            Console.WriteLine("└──────────────────────────────────────────────────────────────────────────────┘");
            Console.WriteLine("\n\n");

            Console.WriteLine("╔═════════════════════════════════════════║════════════════════════════════════╗");
            for (int i = 0; i < 49; i++)
            {
            Console.WriteLine("║                                         ║                                    ║");
            }
            Console.WriteLine("╚═════════════════════════════════════════║════════════════════════════════════╝");
        }

        public void Impresion_Latas()
        {
            //Coca cola
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(10, 12);
            Console.WriteLine("┌    ┌   ┌   ┌   ┌");
            Console.SetCursorPosition(10, 13);
            Console.WriteLine("█    █   █   █   █");
            Console.ResetColor();
            //Sprite
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(10, 18);
            Console.WriteLine("┌    ┌   ┌   ┌   ┌");
            Console.SetCursorPosition(10, 19);
            Console.WriteLine("█    █   █   █   █");
            Console.ResetColor();
            //RedBull
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.SetCursorPosition(10, 24);
            Console.WriteLine("┌    ┌   ┌   ┌   ┌");
            Console.SetCursorPosition(10, 25);
            Console.WriteLine("█    █   █   █   █");
            Console.ResetColor();
            //Fanta
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(10, 30);
            Console.WriteLine("┌    ┌   ┌   ┌   ┌");
            Console.SetCursorPosition(10, 31);
            Console.WriteLine("█    █   █   █   █");
            Console.ResetColor();
            //Té
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.SetCursorPosition(10, 36);
            Console.WriteLine("┌    ┌   ┌   ┌   ┌");
            Console.SetCursorPosition(10, 37);
            Console.WriteLine("█    █   █   █   █");
            Console.ResetColor();
            //Agua
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(10, 42);
            Console.WriteLine("┌    ┌   ┌   ┌   ┌");
            Console.SetCursorPosition(10, 43);
            Console.WriteLine("█    █   █   █   █");
            Console.ResetColor();
            //Pepsi
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.SetCursorPosition(10, 48);
            Console.WriteLine("┌    ┌   ┌   ┌   ┌");
            Console.SetCursorPosition(10, 49);
            Console.WriteLine("█    █   █   █   █");
            Console.ResetColor();
            //
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.SetCursorPosition(10, 54);
            Console.WriteLine("┌    ┌   ┌   ┌   ┌");
            Console.SetCursorPosition(10, 55);
            Console.WriteLine("█    █   █   █   █");
            Console.ResetColor();
        }

        public void Lineas()
        {
            Modo_Administración valor = new Modo_Administración();
            int x = 1,y=15;
            for (int i = 1; i <=8; i++)
            {
                Console.SetCursorPosition(x, y);
                Console.WriteLine("─────────────────────────────────────────");
                if (i == 1)
                {
                    Console.SetCursorPosition((x+1), (y+1));
                    Console.WriteLine("Coca-Cola    Código: 65    Precio: {0:C2}",valor.precio_bebida1);
                }
                if (i == 2)
                {
                    Console.SetCursorPosition((x + 1), (y + 1));
                    Console.WriteLine("Sprite   Código: 66    Precio: $0.60");
                }
                if (i == 3)
                {
                    Console.SetCursorPosition((x + 1), (y + 1));
                    Console.WriteLine("RedBull   Código: 67  Precio: $2.00");
                }
                if (i == 4)
                {
                    Console.SetCursorPosition((x + 1), (y + 1));
                    Console.WriteLine("Fanta   Código: 68   Precio: $0.60");
                }
                if (i == 5)
                {
                    Console.SetCursorPosition((x + 1), (y + 1));
                    Console.WriteLine("Té   Código: 69   Precio: $1.00");
                }
                if (i == 6)
                {
                    Console.SetCursorPosition((x + 1), (y + 1));
                    Console.WriteLine("Agua   Código: 70   Precio: $0.50");
                }
                if(i == 7)
                {
                    Console.SetCursorPosition((x + 1), (y + 1));
                    Console.WriteLine("Pepsi   Código: 71  Precio: $0.60");
                }
                if (i == 8)
                {
                    Console.SetCursorPosition((x + 1), (y + 1));
                    Console.WriteLine("H20   Código:72    Precio: $0.60");
                }
                
                Console.SetCursorPosition(x, (y+2));
                Console.WriteLine("─────────────────────────────────────────");
                y += 6;
                
            }

        }
         

    }
    

}
