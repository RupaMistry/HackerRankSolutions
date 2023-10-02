using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankSolutions.Interview_Preparation_Kit.Warm_up_Challenges
{
    // https://www.hackerrank.com/challenges/repeated-string/problem
    internal class RepeatedString
    {
        public static long Solution(string s, long n)
        {
            long count = 0;

            foreach (var c in s)
            {
                if (c == 'a')
                    count++;
            }

            var repeatCount = n / s.Length;
            count *= repeatCount;
            var len = n % s.Length;

            for (int i = 0; i < len; i++)
            {
                if (s[i] == 'a')
                    count++; 
            }

            return count;
        }
    }
}
