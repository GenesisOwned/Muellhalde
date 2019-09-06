using System;
using System.Diagnostics;
using System.Text.RegularExpressions;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;

namespace Ludenbunker
{
    [TestFixture]
    //[TestClass] // Microsoft Testframework Attribute
    public class ClassNr3_Test
    {
        // Eingabe
        string eingabe = "nsfHJ§)($NRUW)DFf2NU)UWFNu2w9fn9uuwn9df2";
        // Erwartete Ausgabe
        string ausgabe = "NSFhj§)($nruw)dfF2nu)uwfnU2W9FN9UUWN9DF2";

        [Test]
        public void TestMethodShouldBeEqual3()
        {
            Console.WriteLine(eingabe);

            var result = Output_Source.GetAValidString(eingabe);

            Console.WriteLine(result);

            Assert.AreEqual(ausgabe, result);
        }


    }

    public static class Output_Source
    {
        public static string GetAValidString(string eingabe)
        {
            string output_temp = "";
            char[] charArr = eingabe.ToCharArray();
            foreach (char ch in charArr)
            {
                if(Regex.IsMatch(ch.ToString(),"[a-z]"))
                {
                  output_temp=output_temp + ch.ToString().ToUpper();
                }
                else if (Regex.IsMatch(ch.ToString(), "[A-Z]"))
                {
                    output_temp = output_temp + ch.ToString().ToLower();
                }
                else
                {
                    output_temp = output_temp + ch.ToString();
                }
            }
            
            return output_temp;
        }
    }
}
