using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Cliente
    {
        private string Nombre;
        private string Ubicacion;
        private CuentaAhorro cuenta;

        public Cliente(string nombre, string ubicacion, CuentaAhorro cuenta)
        {
            this.Nombre = nombre;
            this.Ubicacion = ubicacion;
            this.cuenta = cuenta;
        }

    }
}
}
