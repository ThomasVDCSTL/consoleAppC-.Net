using System;
using ConsoleApplication1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsoleApplication1.Tests
{
    [TestClass]
    public class ConsoleAppTest
    {
        private iTime _time = new FakeTime(new DateTime(2023, 12, 21, 10, 20, 20));

        [TestMethod]
        public void test1()
        {
            Hello hello = new Hello(9, 12, 18, _time);
            Assert.AreEqual(hello.getHelloMessage(),"Bonjour thomas.vandecasteele ");
        }

        [TestMethod]
        public void test2()
        {
            Hello hello = new Hello(9, 9, 9, new FakeTime(new DateTime(2023, 12, 21, 10, 20, 20)));
            Assert.AreEqual("Bonsoir thomas.vandecasteele ", hello.getHelloMessage());
        }
        
    }
}