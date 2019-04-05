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
    public partial class NombrePersonaje : Form
    {
        
        public NombrePersonaje()
        {
            InitializeComponent();
        }

        private void NombrePersonaje_Load(object sender, EventArgs e)
        {

        }
            
        private void button1_Click(object sender, EventArgs e)
        {
            String nomPersona1 = textBox1.Text;
            String nomPersona2 = textBox2.Text;

            Personaje p = new Personaje(nomPersona1);
            Personaje p2 = new Personaje(nomPersona2);
            this.Hide();

            Form1 juego = new Form1(p,p2);
            juego.ShowDialog();
        }
    }
}
