using System;
using System.Collections.Generic;
using System.Text;

namespace TiendaDeportes
{
    static class Global
    {
        private static Tienda miTienda;

        public static Tienda MiTienda
        {
            get { return miTienda; }
            set { miTienda = value; }
        }
    }
}
