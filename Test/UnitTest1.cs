using NUnit.Framework;
using Domain;

namespace Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            CuentaAhorro cuenta = new CuentaAhorro("12345", "Donaciones", "Valledupar",true);
            var mensaje = cuenta.Consignar(0, "Valledupar");

            Assert.AreEqual("El valor a consignar es incorrecto", mensaje);
            Assert.Pass();
        }

        [Test]
        public void Test2()
        {
            CuentaAhorro cuenta = new CuentaAhorro("12345", "Donaciones", "Valledupar", true);
            var mensaje = cuenta.Consignar(20000, "Valledupar");

            Assert.AreEqual("el valor minimo de la primera consignacion debe ser de $50000 mil pesos", mensaje);
            Assert.Pass();
        }

        [Test]
        public void Test3()
        {
            CuentaAhorro cuenta = new CuentaAhorro("12345", "Donaciones", "Valledupar", true);
            var mensaje = cuenta.Consignar(50000, "Valledupar");

            Assert.AreEqual("Consignacion exitosa su nuevo saldo es 50000", mensaje);
            Assert.Pass();
        }

        [Test]
        public void Test4()
        {
            CuentaAhorro cuenta = new CuentaAhorro("12345", "Donaciones", "Valledupar", true);
            var mensaje = cuenta.Consignar(0, "Valledupar");

            Assert.AreEqual("El valor a consignar es incorrecto", mensaje);
            Assert.Pass();
        }


    }
}