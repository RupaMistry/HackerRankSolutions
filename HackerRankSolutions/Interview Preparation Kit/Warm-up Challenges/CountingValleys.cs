namespace HackerRankSolutions.InterviewPreparationKit.WarmUpChallenges
{
    // https://www.hackerrank.com/challenges/counting-valleys/problem
    internal class CountingValleys
    {        
        public static int Solution(int steps, string path)
        { 
            int map = 0;
            
            int valleyCount = 0;

            foreach (char p in path)
            {
                if (p == 'U')
                {
                    map++;
                    if (map == 0)
                        valleyCount++;
                }
                else
                    map--;
            }

            return valleyCount;
        } 
    }
}
