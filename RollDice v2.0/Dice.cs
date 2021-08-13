using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RollDice_v2._0
{
    class Dice
    {
        static int[][] allDice = new int[7][];
        Random random = new Random();
        static Dice()
        {
            allDice[0] = Enumerable.Range(1, 4).ToArray();
            allDice[1] = Enumerable.Range(1, 6).ToArray();
            allDice[2] = Enumerable.Range(1, 8).ToArray();
            allDice[3] = Enumerable.Range(1, 10).ToArray();
            allDice[4] = Enumerable.Range(1, 12).ToArray();
            allDice[5] = Enumerable.Range(1, 20).ToArray();
            allDice[6] = Enumerable.Range(1, 100).ToArray();
        }
        public int D4(int noumberOfDice)
        {
            int summDice = 0;
            for (int i = 0; i < noumberOfDice; i++)
            {
                var index = random.Next(allDice[0].Length);
                summDice += allDice[0][index];
            }
            return summDice;
        }
        public int D6(int noumberOfDice)
        {
            int summDice = 0;
            for (int i = 0; i < noumberOfDice; i++)
            {
                var index = random.Next(allDice[1].Length);
                summDice += allDice[1][index];
            }
            return summDice;
        }
        public int D8(int noumberOfDice)
        {
            int summDice = 0;
            for (int i = 0; i < noumberOfDice; i++)
            {
                var index = random.Next(allDice[2].Length);
                summDice += allDice[2][index];
            }
            return summDice;
        }
        public int D10(int noumberOfDice)
        {
            int summDice = 0;
            for (int i = 0; i < noumberOfDice; i++)
            {
                var index = random.Next(allDice[3].Length);
                summDice += allDice[3][index];
            }
            return summDice;
        }
        public int D12(int noumberOfDice)
        {
            int summDice = 0;
            for (int i = 0; i < noumberOfDice; i++)
            {
                var index = random.Next(allDice[4].Length);
                summDice += allDice[4][index];
            }
            return summDice;
        }
        public int D20(int noumberOfDice)
        {
            int summDice = 0;
            for (int i = 0; i < noumberOfDice; i++)
            {
                var index = random.Next(allDice[5].Length);
                summDice += allDice[5][index];
            }
            return summDice;
        }
        public int D100(int noumberOfDice)
        {
            int summDice = 0;
            for (int i = 0; i < noumberOfDice; i++)
            {
                var index = random.Next(allDice[6].Length);
                summDice += allDice[6][index];
            }
            return summDice;
        }

    }
}
