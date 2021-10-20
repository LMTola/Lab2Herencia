using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2Herencia
{
    class Lavadora : Electrodomesticos
    {
       
        private int Carga=5;
        public int getCarga()
        {
            return Carga;
        }

        //Contructor por defecto
        public Lavadora() : base()
        {
           
        }

    //Contructor con 2 Parametros
    public Lavadora(double preciobase, double peso) : base(preciobase, peso)
        {
           
        }
        //Contructor con todos los parametros
        public Lavadora(double preciobase, double peso, char consumoenergetico, string color, int carga): base(preciobase,peso,consumoenergetico,color)
        {
            Carga = carga;
        }

        new public double precioFinal()
        {
            double extra = base.precioFinal();
            if (Carga > 30)
                extra += 50;
            return extra;
        }

    }
}
