using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aestrella
{
    static class Configuracion
    {
        private static int dimensionx;
        private static int dimensiony;
        private static float pesocruz;
        private static float pesodiagonal;
        public static menu menuU;
        public static mapa mapaU;

        public static Casilla[,] matriz;
        private static Casilla Nodoinicial;
        private static Casilla Nodofinal;
        private static int marcado;

        public static int Dimensionx
        {
            get
            {
                return dimensionx;
            }

            set
            {
                dimensionx = value;
            }
        }

        public static int Dimensiony
        {
            get
            {
                return dimensiony;
            }

            set
            {
                dimensiony = value;
            }
        }

        public static float Pesocruz
        {
            get
            {
                return pesocruz;
            }

            set
            {
                pesocruz = value;
            }
        }

        public static float Pesodiagonal
        {
            get
            {
                return pesodiagonal;
            }

            set
            {
                pesodiagonal = value;
            }
        }

        public static int Marcado
        {
            get
            {
                return marcado;
            }

            set
            {
                marcado = value;
            }
        }
    }
}
