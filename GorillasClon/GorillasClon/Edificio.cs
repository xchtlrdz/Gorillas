using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GorillasClon
{
    public class Edificio
    {

        public float height; //altura del edificio
        public float width; //ancho del edificio
        public float coordx;
        public float coordy;
        public Bitmap imgDir = new Bitmap(@".\Assets\Torre.png");
        

        //necesitamos esta posicion para saber donde empezara nuestro edificio para no abarcar mas espacio del que deberia. Ademas, se calculara la del proximo con ayuda del ancho de este.
        public Edificio(float x,float y)
        {
            coordx = x;
            coordy = y;
            generarEdificio();
        }

        //En este metodo debemos de implementar un algoritmo para la generacion de dimensiones al azar para el edificio
        public void generarEdificio()
        {
            Thread.Sleep(50);
            Random rand = new Random();
            width = (float)rand.NextDouble();
            width = 95 + (width * (180 - 95));
            height = (float)rand.NextDouble();
            height = 95 + (height * (200 - 95));
            imgDir = new Bitmap(imgDir, (int)width, (int)height);
        }
    }
}
