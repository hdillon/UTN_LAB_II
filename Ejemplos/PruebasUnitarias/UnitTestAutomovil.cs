using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EjemploExcepciones;

namespace PruebasUnitarias
{
    [TestClass]
    public class UnitTestAutomovil
    {

        [TestMethod]
        [ExpectedException(typeof(SinGasolinaException))]
        public void TestAcelerar()
        {
            AutoMovil auto = new AutoMovil("Auto");
            //lleno el tanque
            auto.CargarGasolina();
            auto.CargarGasolina();
            auto.CargarGasolina();
            //acelero hasta que se quede sin gasolina
            while (true)
            {
                auto.Acelerar();
            }
        }

        [TestMethod]
        public void TestInstanciaTanque()
        {
            AutoMovil auto = new AutoMovil("Auto");
            //verifico que el tanque se haya instanciado al crear el automovil
            Assert.AreNotEqual(null, auto.Tanque);
        }
    }
}
