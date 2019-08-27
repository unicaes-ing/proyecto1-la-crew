using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Proyect
{
   
    class Modo_Venta
    {
        public int codigo;
        public int cinco = 0,diez=0,veinticinco=0,dolar_moneda=0,dolar_billete=0,cinco_billete=0;
        public int contador=1;
        public double total = 0.0,vuelto,valor1=0.60,valor2=2.00,valor3=1.00,valor4=0.50;
        public void Ingreso()
        {
            Console.SetCursorPosition(45, 12);
            Console.WriteLine("Ingrese el código:");
            Console.SetCursorPosition(45, 14);
            codigo = Convert.ToInt32(Console.ReadLine());
            switch (codigo)
            {
                case 661:
                    Modo_Administración clave = new Modo_Administración();
                    clave.Administracion();
                    break;
                case 65:
                    if (total < 0.60)
                    {
                        Console.SetCursorPosition(43, 15);
                        Console.WriteLine("────────────────────────────────────");
                        Console.SetCursorPosition(45, 16);
                        Console.WriteLine("Ingrese cantidad de monedas:");
                        Console.SetCursorPosition(43, 17);
                        Console.WriteLine("────────────────────────────────────");
                        Console.SetCursorPosition(45, 18);
                        Console.WriteLine("$0.05: ");
                        Console.SetCursorPosition(52, 18);
                        cinco = Convert.ToInt32(Console.ReadLine());
                        total = total + (cinco * 0.05);
                    }
                    //monedas de $0.05 suficientes
                    if ((cinco * 0.05) >= 0.60 && contador == 1)
                    {
                        Console.SetCursorPosition(43, 19);
                        Console.WriteLine("────────────────────────────────────");
                        Console.SetCursorPosition(45, 20);
                        Venta();
                    }
                    if (total < 0.60 && (cinco * 0.05) < 0.60)
                    {
                        Console.SetCursorPosition(43, 19);
                        Console.WriteLine("────────────────────────────────────");
                        Console.SetCursorPosition(45, 20);
                        Console.WriteLine("$0.10: ");
                        Console.SetCursorPosition(52, 20);
                        diez = Convert.ToInt32(Console.ReadLine());
                        total = total + (diez * 0.1);
                        contador++;
                    }
                    //monedas de $0.05 y $0.10 suficientes
                    if (((diez * 0.1) + (cinco * 0.05)) >= 0.60 && contador == 2)
                    {
                        Console.SetCursorPosition(43, 21);
                        Console.WriteLine("────────────────────────────────────");
                        Console.SetCursorPosition(45, 22);
                        Venta();
                    }
                    if (total < 0.60 && (diez * 0.1) < 0.60)
                    {
                        Console.SetCursorPosition(43, 21);
                        Console.WriteLine("────────────────────────────────────");
                        Console.SetCursorPosition(45, 22);
                        Console.WriteLine("$0.25: ");
                        Console.SetCursorPosition(52, 22);
                        veinticinco = Convert.ToInt32(Console.ReadLine());
                        total = total + (veinticinco * 0.25);
                        contador++;
                    }
                    //monedas de $0.05, $0.10 y $0.25 suficientes
                    if ((veinticinco * 0.25) + (diez * 0.1) + (cinco * 0.05) >= 0.60 && contador == 3)
                    {
                        Console.SetCursorPosition(43, 23);
                        Console.WriteLine("────────────────────────────────────");
                        Console.SetCursorPosition(45, 24);
                        Venta();
                    }
                    if (total < 0.60 && (veinticinco * 0.25) < 0.60)
                    {
                        Console.SetCursorPosition(43, 23);
                        Console.WriteLine("────────────────────────────────────");
                        Console.SetCursorPosition(45, 24);
                        Console.WriteLine("Moneda de $1.00: ");
                        Console.SetCursorPosition(62, 24);
                        dolar_moneda = Convert.ToInt32(Console.ReadLine());
                        total = total + (dolar_moneda * 1);
                        contador++;
                    }
                    //Todas las monedas y moneda de a dolar suficiente
                    if ((dolar_moneda * 1) + (veinticinco * 0.25) + (diez * 0.1) + (cinco * 0.05) >= 0.60 && contador == 4)
                    {
                        Console.SetCursorPosition(43, 25);
                        Console.WriteLine("────────────────────────────────────");
                        Console.SetCursorPosition(45, 26);
                        Venta();
                    }
                    if (total < 0.60 && (dolar_moneda * 1) < 0.60)
                    {
                        Console.SetCursorPosition(43, 25);
                        Console.WriteLine("────────────────────────────────────");
                        Console.SetCursorPosition(45, 26);
                        Console.WriteLine("Billete de $1.00: ");
                        Console.SetCursorPosition(63, 26);
                        dolar_billete = Convert.ToInt32(Console.ReadLine());
                        total = total + (dolar_billete * 1);
                        contador++;
                    }
                //Todas las monedas y billete de $1 suficientes
                    if ((dolar_billete*1)+(dolar_moneda * 1) + (veinticinco * 0.25) + (diez * 0.1) + (cinco * 0.05) >= 0.60 && contador == 5)
                    {
                        Console.SetCursorPosition(43, 27);
                        Console.WriteLine("────────────────────────────────────");
                        Console.SetCursorPosition(45, 28);
                        Venta();
                    }
                    if (total < 0.60 && (dolar_billete * 1) < 0.60)
                    {
                        Console.SetCursorPosition(43, 27);
                        Console.WriteLine("────────────────────────────────────");
                        Console.SetCursorPosition(45, 28);
                        Console.WriteLine("Billete de $5.00: ");
                        Console.SetCursorPosition(63, 28);
                        cinco_billete = Convert.ToInt32(Console.ReadLine());
                        total = total + (cinco_billete * 5);
                        contador++;
                    }
                    if ((cinco_billete*5)+(dolar_billete * 1) + (dolar_moneda * 1) + (veinticinco * 0.25) + (diez * 0.1) + (cinco * 0.05) >= 0.60 && contador == 6)
                    {
                        Console.SetCursorPosition(43, 29);
                        Console.WriteLine("────────────────────────────────────");
                        Console.SetCursorPosition(45, 30);
                        Venta();
                    }
                    break;
                case 66:
                    if (total < 0.60)
                    {
                        Console.SetCursorPosition(43, 15);
                        Console.WriteLine("────────────────────────────────────");
                        Console.SetCursorPosition(45, 16);
                        Console.WriteLine("Ingrese cantidad de monedas:");
                        Console.SetCursorPosition(43, 17);
                        Console.WriteLine("────────────────────────────────────");
                        Console.SetCursorPosition(45, 18);
                        Console.WriteLine("$0.05: ");
                        Console.SetCursorPosition(52, 18);
                        cinco = Convert.ToInt32(Console.ReadLine());
                        total = total + (cinco * 0.05);
                    }
                    //monedas de $0.05 suficientes
                    if ((cinco * 0.05) >= 0.60 && contador == 1)
                    {
                        Console.SetCursorPosition(43, 19);
                        Console.WriteLine("────────────────────────────────────");
                        Console.SetCursorPosition(45, 20);
                        Venta();
                    }
                    if (total < 0.60 && (cinco * 0.05) < 0.60)
                    {
                        Console.SetCursorPosition(43, 19);
                        Console.WriteLine("────────────────────────────────────");
                        Console.SetCursorPosition(45, 20);
                        Console.WriteLine("$0.10: ");
                        Console.SetCursorPosition(52, 20);
                        diez = Convert.ToInt32(Console.ReadLine());
                        total = total + (diez * 0.1);
                        contador++;
                    }
                    //monedas de $0.05 y $0.10 suficientes
                    if (((diez * 0.1) + (cinco * 0.05)) >= 0.60 && contador == 2)
                    {
                        Console.SetCursorPosition(43, 21);
                        Console.WriteLine("────────────────────────────────────");
                        Console.SetCursorPosition(45, 22);
                        Venta();
                    }
                    if (total < 0.60 && (diez * 0.1) < 0.60)
                    {
                        Console.SetCursorPosition(43, 21);
                        Console.WriteLine("────────────────────────────────────");
                        Console.SetCursorPosition(45, 22);
                        Console.WriteLine("$0.25: ");
                        Console.SetCursorPosition(52, 22);
                        veinticinco = Convert.ToInt32(Console.ReadLine());
                        total = total + (veinticinco * 0.25);
                        contador++;
                    }
                    //monedas de $0.05, $0.10 y $0.25 suficientes
                    if ((veinticinco * 0.25) + (diez * 0.1) + (cinco * 0.05) >= 0.60 && contador == 3)
                    {
                        Console.SetCursorPosition(43, 23);
                        Console.WriteLine("────────────────────────────────────");
                        Console.SetCursorPosition(45, 24);
                        Venta();
                    }
                    if (total < 0.60 && (veinticinco * 0.25) < 0.60)
                    {
                        Console.SetCursorPosition(43, 23);
                        Console.WriteLine("────────────────────────────────────");
                        Console.SetCursorPosition(45, 24);
                        Console.WriteLine("Moneda de $1.00: ");
                        Console.SetCursorPosition(62, 24);
                        dolar_moneda = Convert.ToInt32(Console.ReadLine());
                        total = total + (dolar_moneda * 1);
                        contador++;
                    }
                    //Todas las monedas y moneda de a dolar suficiente
                    if ((dolar_moneda * 1) + (veinticinco * 0.25) + (diez * 0.1) + (cinco * 0.05) >= 0.60 && contador == 4)
                    {
                        Console.SetCursorPosition(43, 25);
                        Console.WriteLine("────────────────────────────────────");
                        Console.SetCursorPosition(45, 26);
                        Venta();
                    }
                    if (total < 0.60 && (dolar_moneda * 1) < 0.60)
                    {
                        Console.SetCursorPosition(43, 25);
                        Console.WriteLine("────────────────────────────────────");
                        Console.SetCursorPosition(45, 26);
                        Console.WriteLine("Billete de $1.00: ");
                        Console.SetCursorPosition(63, 26);
                        dolar_billete = Convert.ToInt32(Console.ReadLine());
                        total = total + (dolar_billete * 1);
                        contador++;
                    }
                //Todas las monedas y billete de $1 suficientes
                    if ((dolar_billete*1)+(dolar_moneda * 1) + (veinticinco * 0.25) + (diez * 0.1) + (cinco * 0.05) >= 0.60 && contador == 5)
                    {
                        Console.SetCursorPosition(43, 27);
                        Console.WriteLine("────────────────────────────────────");
                        Console.SetCursorPosition(45, 28);
                        Venta();
                    }
                    if (total < 0.60 && (dolar_billete * 1) < 0.60)
                    {
                        Console.SetCursorPosition(43, 27);
                        Console.WriteLine("────────────────────────────────────");
                        Console.SetCursorPosition(45, 28);
                        Console.WriteLine("Billete de $5.00: ");
                        Console.SetCursorPosition(63, 28);
                        cinco_billete = Convert.ToInt32(Console.ReadLine());
                        total = total + (cinco_billete * 5);
                        contador++;
                    }
                    if ((cinco_billete*5)+(dolar_billete * 1) + (dolar_moneda * 1) + (veinticinco * 0.25) + (diez * 0.1) + (cinco * 0.05) >= 0.60 && contador == 6)
                    {
                        Console.SetCursorPosition(43, 29);
                        Console.WriteLine("────────────────────────────────────");
                        Console.SetCursorPosition(45, 30);
                        Venta();
                    }
                    break;
                case 67:
                    if (total < 2.00)
                    {
                        Console.SetCursorPosition(43, 15);
                        Console.WriteLine("────────────────────────────────────");
                        Console.SetCursorPosition(45, 16);
                        Console.WriteLine("Ingrese cantidad de monedas:");
                        Console.SetCursorPosition(43, 17);
                        Console.WriteLine("────────────────────────────────────");
                        Console.SetCursorPosition(45, 18);
                        Console.WriteLine("$0.05: ");
                        Console.SetCursorPosition(52, 18);
                        cinco = Convert.ToInt32(Console.ReadLine());
                        total = total + (cinco * 0.05);
                    }
                    //monedas de $0.05 suficientes
                    if ((cinco * 0.05) >= 2.00 && contador == 1)
                    {
                        Console.SetCursorPosition(43, 19);
                        Console.WriteLine("────────────────────────────────────");
                        Console.SetCursorPosition(45, 20);
                        Venta();
                    }
                    if (total < 2.00 && (cinco * 0.05) < 2.00)
                    {
                        Console.SetCursorPosition(43, 19);
                        Console.WriteLine("────────────────────────────────────");
                        Console.SetCursorPosition(45, 20);
                        Console.WriteLine("$0.10: ");
                        Console.SetCursorPosition(52, 20);
                        diez = Convert.ToInt32(Console.ReadLine());
                        total = total + (diez * 0.1);
                        contador++;
                    }
                    //monedas de $0.05 y $0.10 suficientes
                    if (((diez * 0.1) + (cinco * 0.05)) >= 2.00 && contador == 2)
                    {
                        Console.SetCursorPosition(43, 21);
                        Console.WriteLine("────────────────────────────────────");
                        Console.SetCursorPosition(45, 22);
                        Venta();
                    }
                    if (total < 2.00 && (diez * 0.1) < 2.00)
                    {
                        Console.SetCursorPosition(43, 21);
                        Console.WriteLine("────────────────────────────────────");
                        Console.SetCursorPosition(45, 22);
                        Console.WriteLine("$0.25: ");
                        Console.SetCursorPosition(52, 22);
                        veinticinco = Convert.ToInt32(Console.ReadLine());
                        total = total + (veinticinco * 0.25);
                        contador++;
                    }
                    //monedas de $0.05, $0.10 y $0.25 suficientes
                    if ((veinticinco * 0.25) + (diez * 0.1) + (cinco * 0.05) >= 2.00 && contador == 3)
                    {
                        Console.SetCursorPosition(43, 23);
                        Console.WriteLine("────────────────────────────────────");
                        Console.SetCursorPosition(45, 24);
                        Venta();
                    }
                    if (total < 2.00 && (veinticinco * 0.25) < 2.00)
                    {
                        Console.SetCursorPosition(43, 23);
                        Console.WriteLine("────────────────────────────────────");
                        Console.SetCursorPosition(45, 24);
                        Console.WriteLine("Moneda de $1.00: ");
                        Console.SetCursorPosition(62, 24);
                        dolar_moneda = Convert.ToInt32(Console.ReadLine());
                        total = total + (dolar_moneda * 1);
                        contador++;
                    }
                    //Todas las monedas y moneda de a dolar suficiente
                    if ((dolar_moneda * 1) + (veinticinco * 0.25) + (diez * 0.1) + (cinco * 0.05) >= 2.00 && contador == 4)
                    {
                        Console.SetCursorPosition(43, 25);
                        Console.WriteLine("────────────────────────────────────");
                        Console.SetCursorPosition(45, 26);
                        Venta();
                    }
                    if (total < 2.00 && (dolar_moneda * 1) < 2.00)
                    {
                        Console.SetCursorPosition(43, 25);
                        Console.WriteLine("────────────────────────────────────");
                        Console.SetCursorPosition(45, 26);
                        Console.WriteLine("Billete de $1.00: ");
                        Console.SetCursorPosition(63, 26);
                        dolar_billete = Convert.ToInt32(Console.ReadLine());
                        total = total + (dolar_billete * 1);
                        contador++;
                    }
                //Todas las monedas y billete de $1 suficientes
                    if ((dolar_billete*1)+(dolar_moneda * 1) + (veinticinco * 0.25) + (diez * 0.1) + (cinco * 0.05) >= 2.00 && contador == 5)
                    {
                        Console.SetCursorPosition(43, 27);
                        Console.WriteLine("────────────────────────────────────");
                        Console.SetCursorPosition(45, 28);
                        Venta();
                    }
                    if (total < 2.00 && (dolar_billete * 1) < 2.00)
                    {
                        Console.SetCursorPosition(43, 27);
                        Console.WriteLine("────────────────────────────────────");
                        Console.SetCursorPosition(45, 28);
                        Console.WriteLine("Billete de $5.00: ");
                        Console.SetCursorPosition(63, 28);
                        cinco_billete = Convert.ToInt32(Console.ReadLine());
                        total = total + (cinco_billete * 5);
                        contador++;
                    }
                    if ((cinco_billete*5)+(dolar_billete * 1) + (dolar_moneda * 1) + (veinticinco * 0.25) + (diez * 0.1) + (cinco * 0.05) >= 2.00 && contador == 6)
                    {
                        Console.SetCursorPosition(43, 29);
                        Console.WriteLine("────────────────────────────────────");
                        Console.SetCursorPosition(45, 30);
                        Venta();
                    }
                    break;
                case 68:
                    if (total < 0.60)
                    {
                        Console.SetCursorPosition(43, 15);
                        Console.WriteLine("────────────────────────────────────");
                        Console.SetCursorPosition(45, 16);
                        Console.WriteLine("Ingrese cantidad de monedas:");
                        Console.SetCursorPosition(43, 17);
                        Console.WriteLine("────────────────────────────────────");
                        Console.SetCursorPosition(45, 18);
                        Console.WriteLine("$0.05: ");
                        Console.SetCursorPosition(52, 18);
                        cinco = Convert.ToInt32(Console.ReadLine());
                        total = total + (cinco * 0.05);
                    }
                    //monedas de $0.05 suficientes
                    if ((cinco * 0.05) >= 0.60 && contador == 1)
                    {
                        Console.SetCursorPosition(43, 19);
                        Console.WriteLine("────────────────────────────────────");
                        Console.SetCursorPosition(45, 20);
                        Venta();
                    }
                    if (total < 0.60 && (cinco * 0.05) < 0.60)
                    {
                        Console.SetCursorPosition(43, 19);
                        Console.WriteLine("────────────────────────────────────");
                        Console.SetCursorPosition(45, 20);
                        Console.WriteLine("$0.10: ");
                        Console.SetCursorPosition(52, 20);
                        diez = Convert.ToInt32(Console.ReadLine());
                        total = total + (diez * 0.1);
                        contador++;
                    }
                    //monedas de $0.05 y $0.10 suficientes
                    if (((diez * 0.1) + (cinco * 0.05)) >= 0.60 && contador == 2)
                    {
                        Console.SetCursorPosition(43, 21);
                        Console.WriteLine("────────────────────────────────────");
                        Console.SetCursorPosition(45, 22);
                        Venta();
                    }
                    if (total < 0.60 && (diez * 0.1) < 0.60)
                    {
                        Console.SetCursorPosition(43, 21);
                        Console.WriteLine("────────────────────────────────────");
                        Console.SetCursorPosition(45, 22);
                        Console.WriteLine("$0.25: ");
                        Console.SetCursorPosition(52, 22);
                        veinticinco = Convert.ToInt32(Console.ReadLine());
                        total = total + (veinticinco * 0.25);
                        contador++;
                    }
                    //monedas de $0.05, $0.10 y $0.25 suficientes
                    if ((veinticinco * 0.25) + (diez * 0.1) + (cinco * 0.05) >= 0.60 && contador == 3)
                    {
                        Console.SetCursorPosition(43, 23);
                        Console.WriteLine("────────────────────────────────────");
                        Console.SetCursorPosition(45, 24);
                        Venta();
                    }
                    if (total < 0.60 && (veinticinco * 0.25) < 0.60)
                    {
                        Console.SetCursorPosition(43, 23);
                        Console.WriteLine("────────────────────────────────────");
                        Console.SetCursorPosition(45, 24);
                        Console.WriteLine("Moneda de $1.00: ");
                        Console.SetCursorPosition(62, 24);
                        dolar_moneda = Convert.ToInt32(Console.ReadLine());
                        total = total + (dolar_moneda * 1);
                        contador++;
                    }
                    //Todas las monedas y moneda de a dolar suficiente
                    if ((dolar_moneda * 1) + (veinticinco * 0.25) + (diez * 0.1) + (cinco * 0.05) >= 0.60 && contador == 4)
                    {
                        Console.SetCursorPosition(43, 25);
                        Console.WriteLine("────────────────────────────────────");
                        Console.SetCursorPosition(45, 26);
                        Venta();
                    }
                    if (total < 0.60 && (dolar_moneda * 1) < 0.60)
                    {
                        Console.SetCursorPosition(43, 25);
                        Console.WriteLine("────────────────────────────────────");
                        Console.SetCursorPosition(45, 26);
                        Console.WriteLine("Billete de $1.00: ");
                        Console.SetCursorPosition(63, 26);
                        dolar_billete = Convert.ToInt32(Console.ReadLine());
                        total = total + (dolar_billete * 1);
                        contador++;
                    }
                //Todas las monedas y billete de $1 suficientes
                    if ((dolar_billete*1)+(dolar_moneda * 1) + (veinticinco * 0.25) + (diez * 0.1) + (cinco * 0.05) >= 0.60 && contador == 5)
                    {
                        Console.SetCursorPosition(43, 27);
                        Console.WriteLine("────────────────────────────────────");
                        Console.SetCursorPosition(45, 28);
                        Venta();
                    }
                    if (total < 0.60 && (dolar_billete * 1) < 0.60)
                    {
                        Console.SetCursorPosition(43, 27);
                        Console.WriteLine("────────────────────────────────────");
                        Console.SetCursorPosition(45, 28);
                        Console.WriteLine("Billete de $5.00: ");
                        Console.SetCursorPosition(63, 28);
                        cinco_billete = Convert.ToInt32(Console.ReadLine());
                        total = total + (cinco_billete * 5);
                        contador++;
                    }
                    if ((cinco_billete*5)+(dolar_billete * 1) + (dolar_moneda * 1) + (veinticinco * 0.25) + (diez * 0.1) + (cinco * 0.05) >= 0.60 && contador == 6)
                    {
                        Console.SetCursorPosition(43, 29);
                        Console.WriteLine("────────────────────────────────────");
                        Console.SetCursorPosition(45, 30);
                        Venta();
                    }
                    break;
                case 69:
                    if (total < 1.00)
                    {
                        Console.SetCursorPosition(43, 15);
                        Console.WriteLine("────────────────────────────────────");
                        Console.SetCursorPosition(45, 16);
                        Console.WriteLine("Ingrese cantidad de monedas:");
                        Console.SetCursorPosition(43, 17);
                        Console.WriteLine("────────────────────────────────────");
                        Console.SetCursorPosition(45, 18);
                        Console.WriteLine("$0.05: ");
                        Console.SetCursorPosition(52, 18);
                        cinco = Convert.ToInt32(Console.ReadLine());
                        total = total + (cinco * 0.05);
                    }
                    //monedas de $0.05 suficientes
                    if ((cinco * 1.00) >= 0.60 && contador == 1)
                    {
                        Console.SetCursorPosition(43, 19);
                        Console.WriteLine("────────────────────────────────────");
                        Console.SetCursorPosition(45, 20);
                        Venta();
                    }
                    if (total < 1.00 && (cinco * 0.05) < 1.00)
                    {
                        Console.SetCursorPosition(43, 19);
                        Console.WriteLine("────────────────────────────────────");
                        Console.SetCursorPosition(45, 20);
                        Console.WriteLine("$0.10: ");
                        Console.SetCursorPosition(52, 20);
                        diez = Convert.ToInt32(Console.ReadLine());
                        total = total + (diez * 0.1);
                        contador++;
                    }
                    //monedas de $0.05 y $0.10 suficientes
                    if (((diez * 0.1) + (cinco * 0.05)) >= 1.00 && contador == 2)
                    {
                        Console.SetCursorPosition(43, 21);
                        Console.WriteLine("────────────────────────────────────");
                        Console.SetCursorPosition(45, 22);
                        Venta();
                    }
                    if (total < 1.00 && (diez * 0.1) < 1.00)
                    {
                        Console.SetCursorPosition(43, 21);
                        Console.WriteLine("────────────────────────────────────");
                        Console.SetCursorPosition(45, 22);
                        Console.WriteLine("$0.25: ");
                        Console.SetCursorPosition(52, 22);
                        veinticinco = Convert.ToInt32(Console.ReadLine());
                        total = total + (veinticinco * 0.25);
                        contador++;
                    }
                    //monedas de $0.05, $0.10 y $0.25 suficientes
                    if ((veinticinco * 0.25) + (diez * 0.1) + (cinco * 0.05) >= 1.00 && contador == 3)
                    {
                        Console.SetCursorPosition(43, 23);
                        Console.WriteLine("────────────────────────────────────");
                        Console.SetCursorPosition(45, 24);
                        Venta();
                    }
                    if (total < 1.00 && (veinticinco * 0.25) < 1.00)
                    {
                        Console.SetCursorPosition(43, 23);
                        Console.WriteLine("────────────────────────────────────");
                        Console.SetCursorPosition(45, 24);
                        Console.WriteLine("Moneda de $1.00: ");
                        Console.SetCursorPosition(63, 24);
                        dolar_moneda = Convert.ToInt32(Console.ReadLine());
                        total = total + (dolar_moneda * 1);
                        contador++;
                    }
                    //Todas las monedas y moneda de a dolar suficiente
                    if ((dolar_moneda * 1) + (veinticinco * 0.25) + (diez * 0.1) + (cinco * 0.05) >= 1.00 && contador == 4)
                    {
                        Console.SetCursorPosition(43, 25);
                        Console.WriteLine("────────────────────────────────────");
                        Console.SetCursorPosition(45, 26);
                        Venta();
                    }
                    if (total < 1.00 && (dolar_moneda * 1) < 1.00)
                    {
                        Console.SetCursorPosition(43, 25);
                        Console.WriteLine("────────────────────────────────────");
                        Console.SetCursorPosition(45, 26);
                        Console.WriteLine("Billete de $1.00: ");
                        Console.SetCursorPosition(63, 26);
                        dolar_billete = Convert.ToInt32(Console.ReadLine());
                        total = total + (dolar_billete * 1);
                        contador++;
                    }
                //Todas las monedas y billete de $1 suficientes
                    if ((dolar_billete*1)+(dolar_moneda * 1) + (veinticinco * 0.25) + (diez * 0.1) + (cinco * 0.05) >= 1.00 && contador == 5)
                    {
                        Console.SetCursorPosition(43, 27);
                        Console.WriteLine("────────────────────────────────────");
                        Console.SetCursorPosition(45, 28);
                        Venta();
                    }
                    if (total < 1.00 && (dolar_billete * 1) < 1.00)
                    {
                        Console.SetCursorPosition(43, 27);
                        Console.WriteLine("────────────────────────────────────");
                        Console.SetCursorPosition(45, 28);
                        Console.WriteLine("Billete de $5.00: ");
                        Console.SetCursorPosition(63, 28);
                        cinco_billete = Convert.ToInt32(Console.ReadLine());
                        total = total + (cinco_billete * 5);
                        contador++;
                    }
                    if ((cinco_billete*5)+(dolar_billete * 1) + (dolar_moneda * 1) + (veinticinco * 0.25) + (diez * 0.1) + (cinco * 0.05) >= 1.00 && contador == 6)
                    {
                        Console.SetCursorPosition(43, 29);
                        Console.WriteLine("────────────────────────────────────");
                        Console.SetCursorPosition(45, 30);
                        Venta();
                    }
                    break;
                case 70:
                    if (total < 0.50)
                    {
                        Console.SetCursorPosition(43, 15);
                        Console.WriteLine("────────────────────────────────────");
                        Console.SetCursorPosition(45, 16);
                        Console.WriteLine("Ingrese cantidad de monedas:");
                        Console.SetCursorPosition(43, 17);
                        Console.WriteLine("────────────────────────────────────");
                        Console.SetCursorPosition(45, 18);
                        Console.WriteLine("$0.05: ");
                        Console.SetCursorPosition(52, 18);
                        cinco = Convert.ToInt32(Console.ReadLine());
                        total = total + (cinco * 0.05);
                    }
                    //monedas de $0.05 suficientes
                    if ((cinco * 0.05) >= 0.50 && contador == 1)
                    {
                        Console.SetCursorPosition(43, 19);
                        Console.WriteLine("────────────────────────────────────");
                        Console.SetCursorPosition(45, 20);
                        Venta();
                    }
                    if (total < 0.50 && (cinco * 0.05) < 0.50)
                    {
                        Console.SetCursorPosition(43, 19);
                        Console.WriteLine("────────────────────────────────────");
                        Console.SetCursorPosition(45, 20);
                        Console.WriteLine("$0.10: ");
                        Console.SetCursorPosition(52, 20);
                        diez = Convert.ToInt32(Console.ReadLine());
                        total = total + (diez * 0.1);
                        contador++;
                    }
                    //monedas de $0.05 y $0.10 suficientes
                    if (((diez * 0.1) + (cinco * 0.05)) >= 0.50 && contador == 2)
                    {
                        Console.SetCursorPosition(43, 21);
                        Console.WriteLine("────────────────────────────────────");
                        Console.SetCursorPosition(45, 22);
                        Venta();
                    }
                    if (total < 0.50 && (diez * 0.1) < 0.50)
                    {
                        Console.SetCursorPosition(43, 21);
                        Console.WriteLine("────────────────────────────────────");
                        Console.SetCursorPosition(45, 22);
                        Console.WriteLine("$0.25: ");
                        Console.SetCursorPosition(52, 22);
                        veinticinco = Convert.ToInt32(Console.ReadLine());
                        total = total + (veinticinco * 0.25);
                        contador++;
                    }
                    //monedas de $0.05, $0.10 y $0.25 suficientes
                    if ((veinticinco * 0.25) + (diez * 0.1) + (cinco * 0.05) >= 0.50 && contador == 3)
                    {
                        Console.SetCursorPosition(43, 23);
                        Console.WriteLine("────────────────────────────────────");
                        Console.SetCursorPosition(45, 24);
                        Venta();
                    }
                    if (total < 0.50 && (veinticinco * 0.25) < 0.50)
                    {
                        Console.SetCursorPosition(43, 23);
                        Console.WriteLine("────────────────────────────────────");
                        Console.SetCursorPosition(45, 24);
                        Console.WriteLine("Moneda de $1.00: ");
                        Console.SetCursorPosition(62, 24);
                        dolar_moneda = Convert.ToInt32(Console.ReadLine());
                        total = total + (dolar_moneda * 1);
                        contador++;
                    }
                    //Todas las monedas y moneda de a dolar suficiente
                    if ((dolar_moneda * 1) + (veinticinco * 0.25) + (diez * 0.1) + (cinco * 0.05) >= 0.50 && contador == 4)
                    {
                        Console.SetCursorPosition(43, 25);
                        Console.WriteLine("────────────────────────────────────");
                        Console.SetCursorPosition(45, 26);
                        Venta();
                    }
                    if (total < 0.50 && (dolar_moneda * 1) < 0.50)
                    {
                        Console.SetCursorPosition(43, 25);
                        Console.WriteLine("────────────────────────────────────");
                        Console.SetCursorPosition(45, 26);
                        Console.WriteLine("Billete de $1.00: ");
                        Console.SetCursorPosition(63, 26);
                        dolar_billete = Convert.ToInt32(Console.ReadLine());
                        total = total + (dolar_billete * 1);
                        contador++;
                    }
                //Todas las monedas y billete de $1 suficientes
                    if ((dolar_billete*1)+(dolar_moneda * 1) + (veinticinco * 0.25) + (diez * 0.1) + (cinco * 0.05) >= 0.50 && contador == 5)
                    {
                        Console.SetCursorPosition(43, 27);
                        Console.WriteLine("────────────────────────────────────");
                        Console.SetCursorPosition(45, 28);
                        Venta();
                    }
                    if (total < 0.50 && (dolar_billete * 1) < 0.50)
                    {
                        Console.SetCursorPosition(43, 27);
                        Console.WriteLine("────────────────────────────────────");
                        Console.SetCursorPosition(45, 28);
                        Console.WriteLine("Billete de $5.00: ");
                        Console.SetCursorPosition(63, 28);
                        cinco_billete = Convert.ToInt32(Console.ReadLine());
                        total = total + (cinco_billete * 5);
                        contador++;
                    }
                    if ((cinco_billete*5)+(dolar_billete * 1) + (dolar_moneda * 1) + (veinticinco * 0.25) + (diez * 0.1) + (cinco * 0.05) >= 0.50 && contador == 6)
                    {
                        Console.SetCursorPosition(43, 29);
                        Console.WriteLine("────────────────────────────────────");
                        Console.SetCursorPosition(45, 30);
                        Venta();
                    }
                    break;
                case 71:
                    if (total < 0.60)
                    {
                        Console.SetCursorPosition(43, 15);
                        Console.WriteLine("────────────────────────────────────");
                        Console.SetCursorPosition(45, 16);
                        Console.WriteLine("Ingrese cantidad de monedas:");
                        Console.SetCursorPosition(43, 17);
                        Console.WriteLine("────────────────────────────────────");
                        Console.SetCursorPosition(45, 18);
                        Console.WriteLine("$0.05: ");
                        Console.SetCursorPosition(52, 18);
                        cinco = Convert.ToInt32(Console.ReadLine());
                        total = total + (cinco * 0.05);
                    }
                    //monedas de $0.05 suficientes
                    if ((cinco * 0.05) >= 0.60 && contador == 1)
                    {
                        Console.SetCursorPosition(43, 19);
                        Console.WriteLine("────────────────────────────────────");
                        Console.SetCursorPosition(45, 20);
                        Venta();
                    }
                    if (total < 0.60 && (cinco * 0.05) < 0.60)
                    {
                        Console.SetCursorPosition(43, 19);
                        Console.WriteLine("────────────────────────────────────");
                        Console.SetCursorPosition(45, 20);
                        Console.WriteLine("$0.10: ");
                        Console.SetCursorPosition(52, 20);
                        diez = Convert.ToInt32(Console.ReadLine());
                        total = total + (diez * 0.1);
                        contador++;
                    }
                    //monedas de $0.05 y $0.10 suficientes
                    if (((diez * 0.1) + (cinco * 0.05)) >= 0.60 && contador == 2)
                    {
                        Console.SetCursorPosition(43, 21);
                        Console.WriteLine("────────────────────────────────────");
                        Console.SetCursorPosition(45, 22);
                        Venta();
                    }
                    if (total < 0.60 && (diez * 0.1) < 0.60)
                    {
                        Console.SetCursorPosition(43, 21);
                        Console.WriteLine("────────────────────────────────────");
                        Console.SetCursorPosition(45, 22);
                        Console.WriteLine("$0.25: ");
                        Console.SetCursorPosition(52, 22);
                        veinticinco = Convert.ToInt32(Console.ReadLine());
                        total = total + (veinticinco * 0.25);
                        contador++;
                    }
                    //monedas de $0.05, $0.10 y $0.25 suficientes
                    if ((veinticinco * 0.25) + (diez * 0.1) + (cinco * 0.05) >= 0.60 && contador == 3)
                    {
                        Console.SetCursorPosition(43, 23);
                        Console.WriteLine("────────────────────────────────────");
                        Console.SetCursorPosition(45, 24);
                        Venta();
                    }
                    if (total < 0.60 && (veinticinco * 0.25) < 0.60)
                    {
                        Console.SetCursorPosition(43, 23);
                        Console.WriteLine("────────────────────────────────────");
                        Console.SetCursorPosition(45, 24);
                        Console.WriteLine("Moneda de $1.00: ");
                        Console.SetCursorPosition(62, 24);
                        dolar_moneda = Convert.ToInt32(Console.ReadLine());
                        total = total + (dolar_moneda * 1);
                        contador++;
                    }
                    //Todas las monedas y moneda de a dolar suficiente
                    if ((dolar_moneda * 1) + (veinticinco * 0.25) + (diez * 0.1) + (cinco * 0.05) >= 0.60 && contador == 4)
                    {
                        Console.SetCursorPosition(43, 25);
                        Console.WriteLine("────────────────────────────────────");
                        Console.SetCursorPosition(45, 26);
                        Venta();
                    }
                    if (total < 0.60 && (dolar_moneda * 1) < 0.60)
                    {
                        Console.SetCursorPosition(43, 25);
                        Console.WriteLine("────────────────────────────────────");
                        Console.SetCursorPosition(45, 26);
                        Console.WriteLine("Billete de $1.00: ");
                        Console.SetCursorPosition(63, 26);
                        dolar_billete = Convert.ToInt32(Console.ReadLine());
                        total = total + (dolar_billete * 1);
                        contador++;
                    }
                //Todas las monedas y billete de $1 suficientes
                    if ((dolar_billete*1)+(dolar_moneda * 1) + (veinticinco * 0.25) + (diez * 0.1) + (cinco * 0.05) >= 0.60 && contador == 5)
                    {
                        Console.SetCursorPosition(43, 27);
                        Console.WriteLine("────────────────────────────────────");
                        Console.SetCursorPosition(45, 28);
                        Venta();
                    }
                    if (total < 0.60 && (dolar_billete * 1) < 0.60)
                    {
                        Console.SetCursorPosition(43, 27);
                        Console.WriteLine("────────────────────────────────────");
                        Console.SetCursorPosition(45, 28);
                        Console.WriteLine("Billete de $5.00: ");
                        Console.SetCursorPosition(63, 28);
                        cinco_billete = Convert.ToInt32(Console.ReadLine());
                        total = total + (cinco_billete * 5);
                        contador++;
                    }
                    if ((cinco_billete*5)+(dolar_billete * 1) + (dolar_moneda * 1) + (veinticinco * 0.25) + (diez * 0.1) + (cinco * 0.05) >= 0.60 && contador == 6)
                    {
                        Console.SetCursorPosition(43, 29);
                        Console.WriteLine("────────────────────────────────────");
                        Console.SetCursorPosition(45, 30);
                        Venta();
                    }
                    break;
                case 72:
                    if (total < 0.60)
                    {
                        Console.SetCursorPosition(43, 15);
                        Console.WriteLine("────────────────────────────────────");
                        Console.SetCursorPosition(45, 16);
                        Console.WriteLine("Ingrese cantidad de monedas:");
                        Console.SetCursorPosition(43, 17);
                        Console.WriteLine("────────────────────────────────────");
                        Console.SetCursorPosition(45, 18);
                        Console.WriteLine("$0.05: ");
                        Console.SetCursorPosition(52, 18);
                        cinco = Convert.ToInt32(Console.ReadLine());
                        total = total + (cinco * 0.05);
                    }
                    //monedas de $0.05 suficientes
                    if ((cinco * 0.05) >= 0.60 && contador == 1)
                    {
                        Console.SetCursorPosition(43, 19);
                        Console.WriteLine("────────────────────────────────────");
                        Console.SetCursorPosition(45, 20);
                        Venta();
                    }
                    if (total < 0.60 && (cinco * 0.05) < 0.60)
                    {
                        Console.SetCursorPosition(43, 19);
                        Console.WriteLine("────────────────────────────────────");
                        Console.SetCursorPosition(45, 20);
                        Console.WriteLine("$0.10: ");
                        Console.SetCursorPosition(52, 20);
                        diez = Convert.ToInt32(Console.ReadLine());
                        total = total + (diez * 0.1);
                        contador++;
                    }
                    //monedas de $0.05 y $0.10 suficientes
                    if (((diez * 0.1) + (cinco * 0.05)) >= 0.60 && contador == 2)
                    {
                        Console.SetCursorPosition(43, 21);
                        Console.WriteLine("────────────────────────────────────");
                        Console.SetCursorPosition(45, 22);
                        Venta();
                    }
                    if (total < 0.60 && (diez * 0.1) < 0.60)
                    {
                        Console.SetCursorPosition(43, 21);
                        Console.WriteLine("────────────────────────────────────");
                        Console.SetCursorPosition(45, 22);
                        Console.WriteLine("$0.25: ");
                        Console.SetCursorPosition(52, 22);
                        veinticinco = Convert.ToInt32(Console.ReadLine());
                        total = total + (veinticinco * 0.25);
                        contador++;
                    }
                    //monedas de $0.05, $0.10 y $0.25 suficientes
                    if ((veinticinco * 0.25) + (diez * 0.1) + (cinco * 0.05) >= 0.60 && contador == 3)
                    {
                        Console.SetCursorPosition(43, 23);
                        Console.WriteLine("────────────────────────────────────");
                        Console.SetCursorPosition(45, 24);
                        Venta();
                    }
                    if (total < 0.60 && (veinticinco * 0.25) < 0.60)
                    {
                        Console.SetCursorPosition(43, 23);
                        Console.WriteLine("────────────────────────────────────");
                        Console.SetCursorPosition(45, 24);
                        Console.WriteLine("Moneda de $1.00: ");
                        Console.SetCursorPosition(62, 24);
                        dolar_moneda = Convert.ToInt32(Console.ReadLine());
                        total = total + (dolar_moneda * 1);
                        contador++;
                    }
                    //Todas las monedas y moneda de a dolar suficiente
                    if ((dolar_moneda * 1) + (veinticinco * 0.25) + (diez * 0.1) + (cinco * 0.05) >= 0.60 && contador == 4)
                    {
                        Console.SetCursorPosition(43, 25);
                        Console.WriteLine("────────────────────────────────────");
                        Console.SetCursorPosition(45, 26);
                        Venta();
                    }
                    if (total < 0.60 && (dolar_moneda * 1) < 0.60)
                    {
                        Console.SetCursorPosition(43, 25);
                        Console.WriteLine("────────────────────────────────────");
                        Console.SetCursorPosition(45, 26);
                        Console.WriteLine("Billete de $1.00: ");
                        Console.SetCursorPosition(63, 26);
                        dolar_billete = Convert.ToInt32(Console.ReadLine());
                        total = total + (dolar_billete * 1);
                        contador++;
                    }
                //Todas las monedas y billete de $1 suficientes
                    if ((dolar_billete*1)+(dolar_moneda * 1) + (veinticinco * 0.25) + (diez * 0.1) + (cinco * 0.05) >= 0.60 && contador == 5)
                    {
                        Console.SetCursorPosition(43, 27);
                        Console.WriteLine("────────────────────────────────────");
                        Console.SetCursorPosition(45, 28);
                        Venta();
                    }
                    if (total < 0.60 && (dolar_billete * 1) < 0.60)
                    {
                        Console.SetCursorPosition(43, 27);
                        Console.WriteLine("────────────────────────────────────");
                        Console.SetCursorPosition(45, 28);
                        Console.WriteLine("Billete de $5.00: ");
                        Console.SetCursorPosition(63, 28);
                        cinco_billete = Convert.ToInt32(Console.ReadLine());
                        total = total + (cinco_billete * 5);
                        contador++;
                    }
                    if ((cinco_billete*5)+(dolar_billete * 1) + (dolar_moneda * 1) + (veinticinco * 0.25) + (diez * 0.1) + (cinco * 0.05) >= 0.60 && contador == 6)
                    {
                        Console.SetCursorPosition(43, 29);
                        Console.WriteLine("────────────────────────────────────");
                        Console.SetCursorPosition(45, 30);
                        Venta();
                    }
                    break;
            }

            
        }
        public void Venta()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Procesando");
            Thread.Sleep(222);
            for (int i = 0; i <= 4; i++)
            {
                Console.Write(".");
                Thread.Sleep(222);
            }
            Console.ResetColor();
            Console.Clear();
            Console.SetWindowSize(45, 20);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(8, 4);
            Console.WriteLine("█████████████████████████");
            Console.SetCursorPosition(8, 5);
            Console.WriteLine("█████████████████████████");
            Console.SetCursorPosition(8, 6);
            Console.WriteLine("█████               █████");
            Console.SetCursorPosition(8, 7);
            Console.WriteLine("█████               █████───┐");
            Console.SetCursorPosition(8, 8);
            Console.WriteLine("█████               █████");
            Console.SetCursorPosition(8, 9);
            Console.WriteLine("█████████████████████████");
            Console.SetCursorPosition(8, 10);
            Console.WriteLine("█████████████████████████");
            Thread.Sleep(220);
            Console.Clear();
            Console.ResetColor();
            Devolución();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(6, 2);
            Console.WriteLine("     ┌       ");
            Console.SetCursorPosition(6, 3);
            Console.WriteLine("     │      ");
            Console.SetCursorPosition(6, 4);
            Console.WriteLine("███████████");
            Console.SetCursorPosition(6, 5);
            Console.WriteLine("███████████");
            Console.SetCursorPosition(6, 6);
            Console.WriteLine("███████████");
            Console.SetCursorPosition(6, 7);
            Console.WriteLine("████   ████");
            Console.SetCursorPosition(6, 8);
            Console.WriteLine("████   ████");
            Console.SetCursorPosition(6, 9);
            Console.WriteLine("████   ████");
            Console.SetCursorPosition(6, 10);
            Console.WriteLine("████   ████");
            Console.SetCursorPosition(6, 12);
            Console.WriteLine("████   ████");
            Console.SetCursorPosition(6, 13);
            Console.WriteLine("████   ████");
            Console.SetCursorPosition(6, 14);
            Console.WriteLine("███████████");
            Console.SetCursorPosition(6, 15);
            Console.WriteLine("███████████");
            Console.SetCursorPosition(6, 16);
            Console.WriteLine("███████████");
            


        }
        public void Devolución()
        {
            if (codigo == 65 || codigo == 66 || codigo == 68 || codigo == 71 || codigo == 72)
            {
                vuelto = total - 0.60;
            }
            if (codigo == 67)
            {
                vuelto = total - 2.00;
            }
            if (codigo == 69)
            {
                vuelto = total - 1.00;
            }
            if (codigo == 70)
            {
                vuelto = total - 0.50;
            }
            
            Console.SetCursorPosition(21, 3);
            Console.WriteLine("SU CAMBIO: {0:C2}", vuelto); ;
            Console.SetCursorPosition(21, 5);
            Console.WriteLine("GRACIAS POR PREFERIRNOS");
        }
    }
}
