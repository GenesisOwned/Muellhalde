using System;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;

namespace Ludenbunker
{
    [TestFixture]
    //[TestClass] // Microsoft Testframework Attribute
    public class MyTestClass
    {
        [Test]
        //[TestMethod] // Microsoft Testframework Attribute
        public void TestMethodShouldBeEqual()
        {
            var eingabe = StaticStringMethode.GetAValidString();

            Assert.AreEqual("Hello World!", eingabe);
        }

        [Test]
        // [TestMethod] // Microsoft Testframework Attribute
        public void TestMethodShouldNotBeEqual()
        {            
            var eingabe = new StringMethode().GetAValidString();

            Assert.AreNotEqual("hello world?", eingabe);
        }      
    }


    public static class StaticStringMethode
    {

        public static string GetAValidString()
        {
            return "Hello World!";
        }

    }

    public class StringMethode
    {

        public string GetAValidString()
        {
            return "Hello World!";
        }

    }
}
