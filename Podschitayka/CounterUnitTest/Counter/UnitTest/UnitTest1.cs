using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Counter;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            
            string d = "ёуеэоаыяию";
            int b = 10;
            int a = Program.Obrabotchik(d);
            Assert.AreEqual(a, b);
        }
        [TestMethod]
        public void TestMethod2()
        {
            string d = "ЁУЕЭОАЫЯИЮ";
            int b = 10;
            int a = Program.Obrabotchik(d);
            Assert.AreEqual(a, b);
        }
        [TestMethod]
        public void TestMethod3()
        {
            string d = "ЁУЕЭО!АЫЯИЮ";
            int b = 5;
            int a = Program.Obrabotchik(d);
            Assert.AreEqual(a, b);
        }
        [TestMethod]
        public void TestMethod4()
        {
            string d = "!ЁУЕЭОАЫЯИЮ";
            int b = 0;
            int a = Program.Obrabotchik(d);
            Assert.AreEqual(a, b);
        }
        [TestMethod]
        public void TestMethod5()
        {
            string d = "ЁкнгУпрЕЭОФВаыЯИ!Пю";
            int b = 9;
            int a = Program.Obrabotchik(d);
            Assert.AreEqual(a, b);
        }
        [TestMethod]
        public void TestMethod6()
        {
            string d = "ОАИЫааыуац146416вфацвцфв";
            int b = 10;
            int a = Program.Obrabotchik(d);
            Assert.AreEqual(a, b);
        }
        [TestMethod]
        public void TestMethod7()
        {
            string d = "«3Э,.Юцйа;:?";
            int b = 3;
            int a = Program.Obrabotchik(d);
            Assert.AreEqual(a, b);
        }
        [TestMethod]
        public void TestMethod8()
        {
            string d = "Ифнв мгВАГ ВЦВиш гвищцв ";
            int b = 4;
            int a = Program.Obrabotchik(d);
            Assert.AreEqual(a, b);
        }

    }
}
