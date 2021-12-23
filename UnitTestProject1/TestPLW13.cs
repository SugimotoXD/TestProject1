using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TestLaba1i3;

namespace UnitTestProject1
{
    [TestClass]
    public class TestPLW13
    {
        [TestMethod]
        public void TestMethod()
        {
            Atmosfera auto = new Atmosfera("Атмосфера");
            Luna auto2 = new Luna("Луна");

            Assert.AreEqual("Атмосфера", auto.name);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Atmosfera auto = new Atmosfera("Атмосфера");
            Assert.AreEqual("Iz-za razrajennosti atmosferi", auto.Zadacha());
        }

        [TestMethod]
        public void TestMethod3()
        {
            Luna auto2 = new Luna("Луна");
            Noch auto3 = new Noch("Ночь");

            Assert.AreEqual("Луна", auto2.name);
        }

        [TestMethod]
        public void TestMethod4()
        {
            Luna auto2 = new Luna("Луна");
            Assert.AreEqual("i iz-za togo chto luni ne bilo", auto2.Zadacha2());
        }

        [TestMethod]
        public void TestMethod5()
        {
            Noch auto3 = new Noch("Ночь");
            Artur auto4 = new Artur("Скорость");
            Starik auto5 = new Starik("Старик");

            Assert.AreEqual("Ночь", auto3.name);
        }

        [TestMethod]
        public void TestMethod6()
        {
            Noch auto3 = new Noch("Ночь");
            Assert.AreEqual("Noch nastupila ochen bistro, i bilo yje ochen temno.", auto3.Zadacha3());
        }

        [TestMethod]
        public void TestMethod7()
        {
            Artur auto4 = new Artur("Артур");
            Assert.AreEqual(auto4.name, "Артур");
        }

        [TestMethod]
        public void TestMothod8()
        {
            Artur auto4 = new Artur("Артур");
            Assert.AreEqual(auto4.Zadacha4(), "Po etomy Atrur ne zametil");
        }
        [TestMethod]
        public void TestMethod9()
        {
            Starik auto5 = new Starik("Старик");
            Assert.AreEqual(auto5.name, "Старик");
        }

        [TestMethod]
        public void TestMothod10()
        {
            Starik auto5 = new Starik("Старик");
            Assert.AreEqual(auto5.Zadacha5(), "Starika, poka ne stolknulsa s nim");
        }

    }
}




   