using Microsoft.VisualStudio.TestTools.UnitTesting;
using ObligatoriskOpg1_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [TestClass()]
    public class TrophyRepositoryTests
    {
        TrophyRepository trophyRepository = new TrophyRepository();
        Trophy trophy1 = new Trophy() { Competition = "NFL", Year = 2024 };
        Trophy trophy2 = new Trophy() { Competition = "NBA", Year = 1970 };
        Trophy trophy3 = new Trophy() { Competition = "Wimbeldon", Year = 2024 };
        Trophy trophy4 = new Trophy() { Competition = "MLB", Year = 1970 };
        Trophy trophy5 = new Trophy() { Competition = "Formula 1", Year = 2024 };


        [TestMethod()]
        public void AddTest()
        {
            trophyRepository.AddTrophy(trophy1);
            trophyRepository.AddTrophy(trophy2);
            trophyRepository.AddTrophy(trophy3);
            trophyRepository.AddTrophy(trophy4);
            trophyRepository.AddTrophy(trophy5);
        }

        [TestMethod()]
        public void ReadTest()
        {
            trophyRepository.Read();
        }

        [TestMethod()]
        public void DeleteTest()
        {
            trophyRepository.DeleteTrophy(1);
        }
    }
}