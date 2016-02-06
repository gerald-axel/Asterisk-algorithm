using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aestrella
{
    //Esta clase me servira para poder obtener la ruta al final y 
    //mantener el orden de los nodos en esta clase se implementara el a*
    static class Arbol
    {
        private static Casilla nodoinicial;
        private static Casilla nodofinal;

        internal static Casilla Nodoinicial
        {
            get
            {
                return nodoinicial;
            }

            set
            {
                nodoinicial = value;
            }
        }

        internal static Casilla Nodofinal
        {
            get
            {
                return nodofinal;
            }

            set
            {
                nodofinal = value;
            }
        }

        public static void algoritmo_estrella()
        {
            List<Casilla> frontera = new List<Casilla>();
            List<Casilla> interior = new List<Casilla>();
            frontera.Add(Nodoinicial);
            Nodoinicial.H1 = Math.Abs((Nodoinicial.X+1) - (Nodofinal.X+1)) + Math.Abs((Nodoinicial.Y+1) - (Nodofinal.Y+1));
            Nodoinicial.G1 = 0;
            Nodoinicial.F1 = Nodoinicial.H1 + Nodoinicial.G1;
            Boolean sucess = false;
            do
            {
                if (!frontera.Any())
                {
                    MessageBox.Show("Error!");
                    break;
                }
                Casilla n = frontera.First();
                frontera.Remove(frontera.First());
                interior.Add(n);
                n.button.BackColor = Color.LightGreen;
                if (n == Nodofinal)
                {
                    sucess = true;
                }
                else
                {
                    for(int x = n.X-1; x <= n.X+1; x++)
                    {
                        for (int y = n.Y - 1; y <= n.Y + 1; y++)
                        {
                            if(x >= 0 && x < Configuracion.Dimensionx)
                            {
                                if (y >= 0 && y < Configuracion.Dimensiony)
                                {
                                    if(!frontera.Contains(Configuracion.matriz[x,y]) && !interior.Contains(Configuracion.matriz[x, y]))
                                    {
                                        if (!Configuracion.matriz[x, y].Bloqueo)
                                        {
                                            Casilla sucesor = Configuracion.matriz[x, y];
                                            frontera.Add(sucesor);
                                            sucesor.button.BackColor = Color.PaleVioletRed;
                                            sucesor.Padre = n;
                                            sucesor.H1 = Math.Abs((sucesor.X + 1) - (Nodofinal.X + 1)) + Math.Abs((sucesor.Y + 1) - (Nodofinal.Y + 1));
                                            sucesor.G1 = sucesor.Padre.G1;
                                            if (sucesor.X==n.X || sucesor.Y == n.Y)
                                            {
                                                sucesor.G1 = sucesor.G1 + Configuracion.Pesocruz;
                                            }
                                            else
                                            {
                                                sucesor.G1 = sucesor.G1 + Configuracion.Pesodiagonal;
                                            }
                                            sucesor.F1 = sucesor.G1 + sucesor.H1;
                                        }
                                    }
                                    else if(frontera.Contains(Configuracion.matriz[x, y]))
                                    {
                                        float F, G, H;
                                        Casilla sucesor = Configuracion.matriz[x, y];
                                        H = Math.Abs((sucesor.X + 1) - (Nodofinal.X + 1)) + Math.Abs((sucesor.Y + 1) - (Nodofinal.Y + 1));
                                        G = sucesor.Padre.G1;
                                        if (sucesor.X == n.X || sucesor.Y == n.Y)
                                        {
                                            G = G + Configuracion.Pesocruz;
                                        }
                                        else
                                        {
                                            G = G + Configuracion.Pesodiagonal;
                                        }
                                        F = G + H;
                                        if (F < sucesor.F1)
                                        {
                                            sucesor.Padre = n;
                                            sucesor.F1 = F;
                                            sucesor.G1 = G;
                                            sucesor.H1 = H;
                                        }

                                    }
                                }
                            }
                        }
                    }
                   frontera = frontera.OrderBy(o => o.F1).ToList();
                }

            } while (!sucess);
            if (sucess)
            {
                Casilla n = Nodofinal;
                while (n != null)
                {
                    n.button.BackColor = Color.Orange;
                    n = n.Padre;
                }
            }
            for(int x = 0; x < Configuracion.Dimensionx; x++)
            {
                for (int y = 0; y < Configuracion.Dimensiony; y++)
                {
                    Casilla n = Configuracion.matriz[x, y];
                    String mensaje = "Coordenadas: [" + (n.X+1) + "," + (n.Y+1) + "]" + " F:" + n.F1 + "\r\n" + "G:" + n.G1 + " H:" + n.H1;
                    n.buttoninfo.AutoPopDelay = 10000;
                    n.buttoninfo.SetToolTip(n.button, mensaje);
                }
            }
        }
    }
}
