using Microsoft.VisualStudio.TestTools.UnitTesting;
using ObligatoriskOpg1_2;
using ObliOpgave1_2.ObligatoriskOpg1_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObliOpgave1_2.ObligatoriskOpg1_2.Tests
{
    [TestClass()]
    public class TrophyTests
    {

        [TestMethod()]
        public void ValidateYearTest()
        {
            Trophy trophy1 = new Trophy() { Year = 1970 };
            Trophy trophy2 = new Trophy() { Year = 2024 };
            trophy1.ValidateYear();
            trophy2.ValidateYear();
        }

        [TestMethod()]
        public void ValidateYearFailTest()
        {
            Trophy trophy1Fail = new Trophy() { Year = 1969 };
            Trophy trophy2Fail = new Trophy() { Year = 2025 };
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => trophy1Fail.ValidateYear());
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => trophy2Fail.ValidateYear());

        }

        [TestMethod()]
        public void ValidateCompTest()
        {
            Trophy comp1 = new Trophy() { Competition = "Cricket" };
            Trophy comp2 = new Trophy() { Competition = "NFL" };
            comp1.ValidateComp();
            comp2.ValidateComp();
        }

        [TestMethod()]
        public void ValidateCompFailTest()
        {
            Trophy compFail1 = new Trophy() { Competition = null };
            Trophy compFail2 = new Trophy() { Competition = "NF" };
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => compFail1.ValidateYear());
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => compFail2.ValidateYear());
        }
    }
}