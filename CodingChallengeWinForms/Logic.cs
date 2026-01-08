using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;

namespace CodingChallengeWinForms
{
    internal class Logic
    {
        public static List<BigInteger> GenerateSequence(int n, int a, int b)
        {
            var sequence = new List<BigInteger>(n);
            for (int i = 1; i <= n; i++)
            {
                int ia = i - a;
                int ib = i - b;

                if(ia < 1 || ib < 1)
                {
                    sequence.Add(BigInteger.One);
                }
                else
                {
                    sequence.Add(sequence[ia - 1] + sequence[ib - 1]);
                }
            }
            return sequence;
        }

        public static string Substitute(BigInteger value, int x, int y, string phraseX, string phraseY, string phraseBoth)
        {
            bool divX = value % x == 0;
            bool divY = value % y == 0;

            if (divX && divY)
            {
                return phraseBoth;
            }
            if (divX)
            {
                return phraseX; 
            }
            if (divY)
            {
                return phraseY;
            }
            return value.ToString();
        }
    }
}
