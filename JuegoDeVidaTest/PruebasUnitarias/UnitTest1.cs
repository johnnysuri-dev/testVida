using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace PruebasUnitarias
  
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {



        }
        public void PerderVida() {

            ComponenteVida vida = new ComponenteVida();
            vida.VidaTotal = 50f;
            vida.PierdeVida(10f);

            //Assert.AreEqual(40f, VidaTotal);
            Assert.AreEqual(40f, 0);
        }
    }
}
