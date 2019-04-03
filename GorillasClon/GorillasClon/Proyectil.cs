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

        private Bitmap imgDir = new Bitmap(@".\Assets\Fuego.png"); //Imagen que se utilizara para representar el sprite del boomerang en el juego
        private float angulo; //Angulo que se utilizara para calcular la trayectoria que seguira.
        private float vel; //Velocidad que se utilizara para calcular la trayectoria que seguira.
        private float x, y; //Estos son los puntos donde se situara el dibujado actual del proyectil

        //Al proyectil le llega la posicion inicial donde esta el jugador que lanza el ataque, esto tambien servira para calcular la trayectoria.
        public Proyectil(float xIni, float yIni)
        {
            x = xIni;
            y = yIni;
        }

        private void calcularTrayectoria()
        {

        }
    }
}
