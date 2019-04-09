using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GorillasClon
{
    public partial class Form1 : Form
    {
        public Personaje per1;
        public Personaje per2;
        public Bitmap imgDir = new Bitmap(@".\Assets\Escenario.png");
        private float xAct = 0;
        List<Edificio> ed = new List<Edificio>();
        private bool sentido = false;
        Proyectil pr;
        List<double> animacion = new List<double>();

        public Form1(Personaje p1, Personaje p2)
        {
            InitializeComponent();
            per1 = p1;
            per2 = p2;
            juego();
        }

        public void juego()
        {
            label3.Text = per1.ID;
            label4.Text = per2.ID;

            for (int i = 0; i < 8; i++)
            {
                ed.Add(new Edificio(xAct, 562));
                xAct += ed.Last<Edificio>().width;
            }
            per1.x = ed[0].coordx;
            per1.y = ed[0].coordy - ed[0].height - per1.height + 12;
            per2.x = ed[4].coordx;
            per2.y = ed[4].coordy - ed[4].height - per2.height + 12;
            per2.imgDir.RotateFlip(RotateFlipType.Rotate180FlipY);
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(imgDir, 0, 0, this.Width, this.Height);
            for (int i = 0; i < ed.Count; i++)
            {
                e.Graphics.DrawImage(ed[i].imgDir, ed[i].coordx, (ed[i].coordy - ed[i].height));
            }
            e.Graphics.DrawImage(per1.imgDir, per1.x, per1.y);
            e.Graphics.DrawImage(per2.imgDir, per2.x, per2.y);
            if (animacion.Count != 0)
            {
                e.Graphics.DrawImage(pr.imgDir, (float)animacion[0], (float)animacion[1]);
                checarColision((float)animacion[0], (float)animacion[1]);
                animacion.RemoveRange(0, 2);
                Thread.Sleep(50);
                pictureBox1.Invalidate();
            }
        }

        private void checarColision(float x, float y)
        {
            if (sentido)
            {
                if ((x > per1.x && x < per1.x + per1.width) && (y > per1.y && y<per1.y+per1.height))
                {
                    MessageBox.Show("Gana el 2");
                    this.Dispose();
                }
            }
            else
            {
                if ((x > per2.x && x < per2.x + per2.width) && (y > per2.y && y < per2.y + per2.height))
                {
                    MessageBox.Show("Gana el 1");
                    this.Dispose();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (sentido)
            {
                pr = new Proyectil(per1.x, per1.y);
                sentido = false;
            }
            else
            {
                pr = new Proyectil(per2.x, per2.y);
                sentido = true;
            }
            try
            {
                animacion = pr.calcularTrayectoria(Int32.Parse(textBox1.Text), Int32.Parse(textBox2.Text), !sentido);
            }
            catch (Exception ex)
            {

            }
            pictureBox1.Invalidate();
        }
    }
}
