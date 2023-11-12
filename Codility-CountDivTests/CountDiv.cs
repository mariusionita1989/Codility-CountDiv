using Codility_CountDiv;

namespace Codility_CountDivTests
{
    public class SolutionTests
    {
        [Fact]
        public void TestExample()
        {
            Solution solution = new Solution();
            int result = solution.solution(6, 11, 2);
            Assert.Equal(3, result);
        }

        [Fact]
        public void TestRangeWithNoDivisibleNumbers()
        {
            Solution solution = new Solution();
            int result = solution.solution(1, 5, 7);
            Assert.Equal(0, result);
        }

        [Fact]
        public void TestRangeWithSingleDivisibleNumber()
        {
            Solution solution = new Solution();
            int result = solution.solution(10, 10, 2);
            Assert.Equal(1, result);
        }

        [Fact]
        public void TestRangeWithAllDivisibleNumbers()
        {
            Solution solution = new Solution();
            int result = solution.solution(0, 20, 5);
            Assert.Equal(5, result);
        }

        [Fact]
        public void TestInvalidInput_AboveRange()
        {
            Solution solution = new Solution();
            int result = solution.solution(0, 2000000001, 5);
            Assert.Equal(0, result);
        }

        [Fact]
        public void TestInvalidInput_KOutOfRange()
        {
            Solution solution = new Solution();
            int result = solution.solution(1, 10, 0);
            Assert.Equal(0, result);
        }

        [Fact]
        public void TestInvalidInput_AGreaterThanB()
        {
            Solution solution = new Solution();
            int result = solution.solution(5, 1, 2);
            Assert.Equal(0, result);
        }
    }
}