using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sistema_de_descuentos
{
    class Program
    {
        static void Main(string[] args)
        {
            int monto;
            string linea;

            Console.Write("Ingrese el total a pagar: ");
            linea = Console.ReadLine();
            monto = int.Parse(linea);

            if (monto < 1500) ;
            {
                Console.WriteLine("El total a pagar es: +monto");
            }
            else if (monto > 2000) ;
            {
                if (monto > 3000) ;
            }
            else (monto < 2000);
            {
                x=0.10
            }
            else if (monto > 3000) ;
            {
                x=0.25
            }
            else (monto < 3000);
            {
                x=0.10
            }
           _descuento=monto * x 
                total=monto-descuento

                Control.WriteLine("El total a pagar es: +total");

            Control.ReadKey();
           
            
            

            
           
            
           
            
           
           




        }
    }
}
