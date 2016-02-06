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
            //Button button = sender as Button;
            // identify which button was clicked and perform necessary actions
            if (Configuracion.Marcado == 1)
            {
                this.Bloqueo = false;
                button.BackColor = Color.Yellow;
                if (Arbol.Nodoinicial != null)
                {
                    Arbol.Nodoinicial.button.BackColor = default(Color);
                }
                Arbol.Nodoinicial = this;
            }
            if (Configuracion.Marcado == 2)
            {
                this.Bloqueo = false;
                button.BackColor = Color.Blue;
                if (Arbol.Nodofinal != null)
                {
                    Arbol.Nodofinal.button.BackColor = default(Color);
                }
                Arbol.Nodofinal = this;
            }
            if (Configuracion.Marcado == 3)
            {
                if (this != Arbol.Nodofinal && this != Arbol.Nodoinicial)
                {
                    if (this.Bloqueo)
                    {
                        this.Bloqueo = false;
                        button.BackColor = default(Color);
                    }
                    else
                    {
                        this.Bloqueo = true;
                        button.BackColor = Color.DarkGray;
                    }
                }
            }
        }

        private float H;
        private float G;
        private float F;
        private int x, y;
        public Button button = new Button();
        private Casilla padre;
        private Boolean bloqueo;
        public ToolTip buttoninfo = new ToolTip();

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

        internal Casilla Padre
        {
            get
            {
                return padre;
            }

            set
            {
                padre = value;
            }
        }

        public bool Bloqueo
        {
            get
            {
                return bloqueo;
            }

            set
            {
                bloqueo = value;
            }
        }

        public Casilla ()
            {
            button.Size = new Size(20, 20);
            button.Text = "";
            button.Click += button_Click;

            F1 = 0;
            H1 = 0;
            G1 = 0;
        }

        

    }
}
