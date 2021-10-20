using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2Herencia
{
    class Electrodomesticos
    {
        protected double PrecioBase = 100;
        protected string Color;
        protected char ConsumoEnergetico;
        protected double Peso = 5;

        private List<char> lconsumo = new List<char>() {'F','E','D','C','B','A' };
        private List<string> lcolor = new List<string>() {"blanco","negro","rojo","azul","gris" };

        public Electrodomesticos()
        {
            Color = lcolor.First();
            ConsumoEnergetico = lconsumo.First();

        }

        public Electrodomesticos(double precio, double peso)
        {
            PrecioBase = precio;
            Peso = peso;

        }

        public Electrodomesticos(double precio, double peso, char consumo, string color)
        {
            PrecioBase = precio;
            Peso = peso;
          
            comprobarConsumoEnergetico(consumo);
           
            ComprobarColor(color);
        }

        public double getPrecioBase()
        {
            return PrecioBase;
        }
        public double getPeso()
        {
            return Peso;
        }

        private void comprobarConsumoEnergetico(char consumoEnergetico)
        {
          
            if (lconsumo.Contains(consumoEnergetico))
                ConsumoEnergetico = consumoEnergetico;
            else 
                ConsumoEnergetico = lconsumo.First();


        }

        public char getConsumoEnergetico()
        {
            return ConsumoEnergetico;
        }

        private void ComprobarColor(String color)
        {
            if (lcolor.Contains(color))
                Color = color;
            else
                Color = lcolor.First();


        }
        public String getColor()
        {
            return Color;
        }
        public double precioFinal()
        {
            double extra = 0;
            switch (ConsumoEnergetico)
            {
                case 'A':
                    extra += 100;
                    break;
                case 'B':
                    extra += 80;
                    break;
                case 'C':
                    extra += 60;
                    break;
                case 'D':
                    extra += 50;
                    break;
                case 'E':
                    extra += 30;
                    break;
                case 'F':
                    extra += 10;
                    break;
            }

            if (Peso >= 0 && Peso < 19)
            {
                extra += 10;
            }
            else if (Peso >= 20 && Peso < 49)
            {
                extra += 50;
            }
            else if (Peso >= 50 && Peso <= 79)
            {
                extra += 80;
            }
            else if (Peso >= 80)
            {
                extra += 100;
            }

            return PrecioBase + extra;
        }
    }
}
