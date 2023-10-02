namespace HackerRankSolutions.InterviewPreparationKit.WarmUpChallenges
{
    // https://www.hackerrank.com/challenges/jumping-on-the-clouds/problem
    internal class JumpingOnTheClouds
    { 
        public static int Solution(List<int> c)
        {
            bool isSafe = false;
            int jumps = 0;
            int i = 0;
             
            while (i < c.Count)
            {
                if (c[i] == 0)
                {
                    if (i < (c.Count - 2) && c[i + 2] == 0)
                    {
                        isSafe = true;
                        i = i + 2;
                    }
                    else if (i < (c.Count - 1) && c[i + 1] == 0)
                    {
                        isSafe = true;
                        i = i + 1;
                    }
                    else
                        i++;
                }

                if (isSafe)
                    jumps++;

                isSafe = false;
            }

            return jumps;
        }
    }
}