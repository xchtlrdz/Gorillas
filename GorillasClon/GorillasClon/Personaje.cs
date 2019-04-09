using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GorillasClon
{
    public class Personaje
    {
        public float height; //alto del hitbox del personaje
        public float width; //ancho del hitbox del personaje
        public Bitmap imgDir = new Bitmap(@".\Assets\Dragon1.png"); //Este seria la ruta del archivo que se utilizaria para dibujar al sprite del personaje
        public string ID; //ID del usuario controlando al personaje, eso con el objetivo de mostrar la pantalla final y el nombre del jugador que gano
        public float x, y;

        public Personaje(string id, float x, float y)
        {
            this.ID = id;
            this.height = 80;
            this.width = 80;
            this.x = x;
            this.y = y;
        }
    }
}
