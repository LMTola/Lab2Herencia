using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2Herencia
{
    class Television : Electrodomesticos
    {
       
        private int Resolucion=20;
        private bool SintonizadorTDT;

        //Constructor x Defecto
        public Television() : base()
        {
            
        }
        //Contructor con 2 Parametros
        public Television(double preciobase, double peso) : base(preciobase, peso)
        {

        }

        //Contructor con todos los parametros
        public Television(double preciobase, double peso, char consumoenergetico, string color, int resolucion, bool sintonizadorTDT) : base(preciobase, peso, consumoenergetico, color)
        {
            Resolucion=resolucion;
            SintonizadorTDT = sintonizadorTDT;
        }
        public double getResolucion()
        {
            return Resolucion;
        }
        public bool getSintonizador()
        {
            return SintonizadorTDT;
        }
        new public double precioFinal()
        {
            
            double extra = base.precioFinal();

           
            if (Resolucion > 40)
            {
                extra += PrecioBase * 0.3;
            }
            if (SintonizadorTDT)
            {
                extra += 50;
            }

            return extra;
        }


    }
}
