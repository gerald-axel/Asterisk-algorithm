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
                    c.X = x;
                    c.Y = y;
                    Configuracion.matriz[x,y] = c;
                }
            }
            panelbotones.AutoSize = true;
            this.AutoSize = true;
        }
    }
}
