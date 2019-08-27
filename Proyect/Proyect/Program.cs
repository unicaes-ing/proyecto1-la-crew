using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyect
{
    class Program
    {
        static void Main(string[] args)
        {
            Impresión ventana = new Impresión();
            Impresión lata = new Impresión();
            Impresión división = new Impresión();
            Modo_Venta ingresos = new Modo_Venta();
            ventana.Imprimir();
            lata.Impresion_Latas();
            división.Lineas();
            ingresos.Ingreso();
            
            

            Console.ReadKey();
        }
    }
}
