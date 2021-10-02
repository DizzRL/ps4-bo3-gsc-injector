using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS4_BO3_GSC
{
    public class Enums
    {
        public enum GameVersion: ulong
        {
            OneThreeThree = 0x547EEF0,
            OneTwoSix = 0x6B9CFD0
        }

        public enum ConsoleVersion: int
        {
            fiveOFive = 0,
            sixSevenTwo = 1,
            sevenOTwo = 2,
            sevenFiveFive = 3
        }
    }
}
