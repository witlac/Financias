using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class CuentaAhorro
    {
        private string NumeroCuenta;
        private string Nombre;
        private decimal Saldo;
        private string Ciudad;
        private Boolean PrimeraConsignacion = false;

        public CuentaAhorro(string numeroCuenta, string nombre, string ciudad, Boolean primera)
        {
            this.NumeroCuenta = numeroCuenta;
            this.Nombre = nombre;
            this.Saldo = 0;
            this.Ciudad = ciudad;
            this.PrimeraConsignacion = primera;

        }

        public string Consignar(decimal valorConsignacion, string ciudad)
        {

            if (valorConsignacion <= 0)
            {
                return "El valor a consignar es incorrecto";
            }
            else
            {

                if (this.PrimeraConsignacion == true)
                {
                    if (valorConsignacion >= 50000)
                    {
                        this.PrimeraConsignacion = false;

                        if (ciudad == this.Ciudad)
                        {
                            this.Saldo += valorConsignacion;
                        }
                        else
                        {
                            this.Saldo += valorConsignacion - 10000;
                        }

                        return $"Consignacion exitosa su nuevo saldo es ${this.Saldo}";
                    }
                    else
                    {
                        return "el valor minimo de la primera consignacion debe ser de $50000 mil pesos";
                    }
                }
                else
                {
                    if (ciudad == this.Ciudad)
                    {
                        this.Saldo += valorConsignacion;
                    }
                    else
                    {
                        this.Saldo += valorConsignacion - 10000;
                    }
                    return $"Consignacion exitosa su nuevo saldo es ${this.Saldo}";
                }

            }
        }
    }
}
