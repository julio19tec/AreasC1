using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreasC1
{
    public class AreasC
    {
     
        public static decimal Cuadrado(decimal lado)
        {
            return lado * lado;
           
        }
        public static decimal Triangulo(decimal b, decimal h)
        {
            return (b * h) / 2;
          
        }
        public static decimal Circulo(decimal r)
        {
            return (decimal)Math.PI * r * r;
            
        }
        public static decimal Rectangulo(decimal b, decimal h)
        {
            return b * h;
            
        }
        public static decimal Poligono(decimal perimetro, decimal apotema)
        {
            return (perimetro* apotema)/2;
           
        }
        public static decimal Rombo(decimal diagonalMayor, decimal diagonalMenor)
        {
            return diagonalMayor * diagonalMenor;
           
        }

    }
}
