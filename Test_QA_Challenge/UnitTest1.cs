using Xunit;
using QaChallenge;

namespace TestQaChallenge
{
    public class UnitTest1
    {
        readonly IndexSearch indexSearch = new IndexSearch();


        [Fact]
        public void TestFoundIndexSumIntEqualLeftWithRight()
        {
            int[] arrayIntegers = { 1, 2, 3, 4, 3, 2, 1 };
            int resultIndex = indexSearch.Return_smallest_index(arrayIntegers);
            Assert.Equal(3, resultIndex);
        }

        [Fact]
        public void TestEmptyArray()
        {
            int[] arrayIntegers = { };
            int resultIndex = indexSearch.Return_smallest_index(arrayIntegers);
            Assert.Equal(0, resultIndex);
        }

        [Fact]
        public void TestIndexZeroEqualSumRestElements()
        {
            int[] arrayIntegers = { 20, 10, -80, 10, 10, 15, 35 };
            int resultIndex = indexSearch.Return_smallest_index(arrayIntegers);
            Assert.Equal(0, resultIndex);
        }
        [Fact]
        public void TestNoFoundedIndex()
        {
            int[] arrayIntegers = { 1, 2, 10, 4, 5, 18 };
            int resultIndex = indexSearch.Return_smallest_index(arrayIntegers);
            Assert.Equal(-1, resultIndex);
        }
        [Fact]
        public void TestOnlyNegativeNumbers()
        {
            int[] arrayIntegers = { -1, -2, -3, -4, -3, -2, -1 };
            int resultIndex = indexSearch.Return_smallest_index(arrayIntegers);
            Assert.Equal(3, resultIndex);
        }
    }
}
