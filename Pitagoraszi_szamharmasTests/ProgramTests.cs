using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pitagoraszi_szamharmas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pitagoraszi_szamharmas.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void derekszoguTest()
        {
            Haromszog h = new Haromszog("3 4 5");
            Assert.AreEqual(true, Program.derekszogu(h));
            
        }
    }
}