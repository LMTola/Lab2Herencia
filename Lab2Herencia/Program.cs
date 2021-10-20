using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab2Herencia
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Electrodomesticos> lelectro = new List<Electrodomesticos>();
            lelectro.Add(new Lavadora(200, 100, 'A', "verde", 15));
            lelectro.Add(new Television(400, 60, 'C', "blanco", 30, true));
            lelectro.Add(new Lavadora(250, 60, 'C', "Verde",20));



            double TotalPrecioElectrod = 0;
 
            string PrecioxLavadora="";
            string PrecioxTv = "";
            int l=0;
            int t = 0;

           
            var count = lelectro.Count;

   
            foreach(Electrodomesticos c in lelectro)
            {
                TotalPrecioElectrod += c.precioFinal();

                if (c.GetType() == typeof(Lavadora))
                {
                    l++;
                    PrecioxLavadora += "El Precio de la Lavadora "+ l +" es " + c.precioFinal() +"\n";
                    
                }
                if (c.GetType() == typeof(Television))
                {
                    t++;
                    PrecioxTv += "El Precio del Televisor " + t + " es " + c.precioFinal() + "\n";

                }

            }


            Console.WriteLine("La suma del precio de los electrodomesticos es de " + TotalPrecioElectrod);
            Console.WriteLine(PrecioxLavadora);
            Console.WriteLine(PrecioxTv);
        }
    }
}
