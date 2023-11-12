using System.Runtime.CompilerServices;

namespace Codility_CountDiv
{
    public class Solution
    {
        public const int RANGE_LOWEST_VALUE = 0;
        public const int RANGE_HIGHEST_VALUE = 2000000000;

        [MethodImpl(MethodImplOptions.AggressiveOptimization)]
        public int solution(int A, int B, int K)
        {
            if (A >= RANGE_LOWEST_VALUE     && A <= RANGE_HIGHEST_VALUE &&
                B >= RANGE_LOWEST_VALUE     && B <= RANGE_HIGHEST_VALUE &&
                K >= RANGE_LOWEST_VALUE + 1 && K <= RANGE_HIGHEST_VALUE &&
                A <= B) 
            {
                if (A % K != 0)
                    A = A + (K - (A % K));

                // Check if A is still less than or equal to B
                if (A <= B)
                {
                    // Calculate the count of divisible numbers within the range [A..B]
                    int count = (B - A) / K + 1;
                    return count;
                }
            }

            return 0;
        }
    }
}
