using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GorillasClon
{
    public partial class Form1 : Form
    {
        public Personaje per1;
        public Personaje per2;

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

            Edificio ed = new Edificio(0,0);
            ed.coordx += ed.weight;
        }
    }
}
