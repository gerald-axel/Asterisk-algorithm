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
    }
}
