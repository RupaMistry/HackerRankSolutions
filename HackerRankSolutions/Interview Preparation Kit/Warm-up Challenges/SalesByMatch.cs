namespace HackerRankSolutions.InterviewPreparationKit.WarmUpChallenges
{
    // https://www.hackerrank.com/challenges/sock-merchant/problem
    internal class SalesByMatch
    {
        public static int sockMerchant(int n, List<int> ar)
        {
            int pairsCount = 0;

            for (int i = 0; i < ar.Count; i++)
            {
                for (int j = i + 1; j < ar.Count; j++)
                {
                    if (ar[i] > 0 && ar[j] > 0 && ar[i] == ar[j])
                    {
                        pairsCount++;
                        ar[i] = -1;
                        ar[j] = -1;
                        break;
                    }
                }
            }

            return pairsCount;
        }
    }
}
