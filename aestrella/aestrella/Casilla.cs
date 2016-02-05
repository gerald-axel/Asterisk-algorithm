using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aestrella
{
    class Casilla
    {
        protected void button_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            // identify which button was clicked and perform necessary actions
            MessageBox.Show("Hola");
        }

        private float H;
        private float G;
        private float F;
        private int contador;
        private int x, y;
        public Button button = new Button();

        public float H1
        {
            get
            {
                return H;
            }

            set
            {
                H = value;
            }
        }

        public float G1
        {
            get
            {
                return G;
            }

            set
            {
                G = value;
            }
        }

        public float F1
        {
            get
            {
                return F;
            }

            set
            {
                F = value;
            }
        }

        public int Contador
        {
            get
            {
                return contador;
            }

            set
            {
                contador = value;
            }
        }

        public int X
        {
            get
            {
                return x;
            }

            set
            {
                x = value;
            }
        }

        public int Y
        {
            get
            {
                return y;
            }

            set
            {
                y = value;
            }
        }

        public Casilla ()
            {
            Contador = 0;
            button.Size = new Size(20, 20);
            button.Text = "";
            button.Click += button_Click;
            }

        

    }
}
