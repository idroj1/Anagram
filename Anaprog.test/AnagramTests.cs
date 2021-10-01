using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System. Diagnostics;
using System.Linq;
using System.Text;

namespace Anaprog.test
{
    public class AnagramTests
    {
        [SetUp]
        public void Setup()
        {
        }

        StreamReader Lista = File.OpenText("wordlist.txt");
        /*
        StreamReader sr = new StreamReader(@"C:\jordi\desktop\Anagram\wordlist.txt");

        [Test]
        public void TestN()
        {
            string[] foo = new string[] {};
            Assert.That(() => AnagramReader.Equals, Throws.ArgumentNullException);
        }
        */
        
        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}