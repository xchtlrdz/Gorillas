using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GorillasClon
{
    public class Edificio
    {

        private float height; //altura del edificio
        private float weight; //ancho del edificio
        private float x;
        private Bitmap imgDir = new Bitmap(@".\Assets\Torre.png");

        //necesitamos esta posicion para saber donde empezara nuestro edificio para no abarcar mas espacio del que deberia. Ademas, se calculara la del proximo con ayuda del ancho de este.
        public Edificio(float x)
        {
            generarEdificio();
        }

        //En este metodo debemos de implementar un algoritmo para la generacion de dimensiones al azar para el edificio
        public void generarEdificio()
        {
            Random rand = new Random();
            weight = (float)rand.NextDouble();
            weight = 45 + (weight * (60 - 45));
            height = (float)rand.NextDouble();
            height = 25 + (height * (120 - 25));
        }
    }
}
