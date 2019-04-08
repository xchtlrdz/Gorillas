using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GorillasClon
{
    public class Proyectil
    {
        //Esta clase servira como apoyo para el proyectil, aqui podremos determinar la ruta que seguira y asignarle el angulo y velocidad que decidira el usuario

        public Bitmap imgDir = new Bitmap(@".\Assets\bolaFuego.png"); //Imagen que se utilizara para representar el sprite del boomerang en el juego
        private float x, y; //Estos son los puntos donde se situara el dibujado actual del proyectil

        //Al proyectil le llega la posicion inicial donde esta el jugador que lanza el ataque, esto tambien servira para calcular la trayectoria.
        public Proyectil(float xIni, float yIni)
        {
            x = xIni;
            y = yIni;
            imgDir = new Bitmap(imgDir, 40, 40);
        }

        public List<double> calcularTrayectoria(double angulo, double velocidad, bool sentido)
        {
            angulo = angulo / 180 * Math.PI;
            List<double> posiciones = new List<double>();

            double VelX = Math.Cos(angulo) * velocidad;
            double VelY = Math.Sin(angulo) * velocidad;
            double tFin = (2 * velocidad * Math.Sin(angulo)) / 9.8;

            double actualX = x, actualY = y;
            for (double tAct = 0; tAct < tFin; tAct += .1)
            {
                VelY = velocidad * Math.Sin(angulo) - 9.8 * tAct;
                //velocidad = Math.Sqrt(Math.Pow(VelX, 2) + Math.Pow(VelY, 2));
                actualX = velocidad * tAct * Math.Cos(angulo);
                actualY = velocidad * tAct * Math.Sin(angulo) - (0.5 * (9.8 * Math.Pow(tAct, 2)));
                if (sentido)
                {
                    posiciones.Add(actualX * 10);
                }
                else
                {
                    posiciones.Add(x-actualX*10);
                }
                posiciones.Add(y - (actualY * 10));
            }
            return posiciones;
        }
    }
}
