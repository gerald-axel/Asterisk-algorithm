using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aestrella
{
    public partial class mapa : Form
    {
        public mapa()
        {
            InitializeComponent();
        }

        private void mapa_FormClosed(object sender, FormClosedEventArgs e)
        {
            Configuracion.menuU.Show();
        }

        private void mapa_Load(object sender, EventArgs e)
        {
            Configuracion.matriz = new Casilla[Configuracion.Dimensionx,Configuracion.Dimensiony];
            panelbotones.Controls.Clear();
            for(int x = 0; x < Configuracion.Dimensionx; x++)
            {
                for (int y = 0; y < Configuracion.Dimensiony; y++)
                {
                    Casilla c = new Casilla();
                    c.button.Location = new Point(x*20, y*20);
                    panelbotones.Controls.Add(c.button);
                    c.button.BackColor = default(Color);
                    c.X = x;
                    c.Y = y;
                    Configuracion.matriz[x,y] = c;
                }
            }
            panelbotones.AutoSize = true;
            this.AutoSize = true;
        }

        private void nodoinicialr_CheckedChanged(object sender, EventArgs e)
        {
            Configuracion.Marcado = 1;
        }

        private void nodofinalr_CheckedChanged(object sender, EventArgs e)
        {
            Configuracion.Marcado = 2;
        }

        private void bloqueor_CheckedChanged(object sender, EventArgs e)
        {
            Configuracion.Marcado = 3;
        }

        private void eliminarr_CheckedChanged(object sender, EventArgs e)
        {
            Configuracion.Marcado = 4;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Arbol.Nodoinicial != null && Arbol.Nodofinal != null)
            {
                Arbol.algoritmo_estrella();
            }
            else
            {
                MessageBox.Show("No se ha seleccionado inicio o fin.");
            }
        }

        private void nodofinalr_CheckedChanged_1(object sender, EventArgs e)
        {
            Configuracion.Marcado = 2;
        }
    }
}
