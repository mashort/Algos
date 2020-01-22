using Xunit;

namespace algos.tests
{
    public class TwoSumShould
    {
        [Fact]
        public void ReturnArrayWithTwoIndices()
        {
            int[] nums = {2, 7, 11, 15};
            int target = 9;
            
            Easy sut = new Easy();
            int[] returnedArray = sut.TwoSum(nums, target);

            Assert.Equal(2, returnedArray.Length);
        }

        [Fact]
        public void ReturnCorrectArrayWhenFirstIndexIsPartOfTheSum()
        {
            int[] nums = {2, 7, 11, 15};
            int target = 13;
            
            Easy sut = new Easy();
            int[] returnedArray = sut.TwoSum(nums, target);

            Assert.Equal(2, returnedArray.Length);
            Assert.Equal(0, returnedArray[0]);
            Assert.Equal(2, returnedArray[1]);
        }

        [Fact]
        public void ReturnCorrectArrayWhenFirstIndexIsNotPartOfTheSum()
        {
            int[] nums = {2, 7, 11, 15};
            int target = 18;
            
            Easy sut = new Easy();
            int[] returnedArray = sut.TwoSum(nums, target);

            Assert.Equal(2, returnedArray.Length);
            Assert.Equal(1, returnedArray[0]);
            Assert.Equal(2, returnedArray[1]);
        }

        [Fact]
        public void ReturnCorrectArrayWhenLastIndexIsPartOfTheSum()
        {
            int[] nums = {2, 7, 11, 15};
            int target = 26;
            
            Easy sut = new Easy();
            int[] returnedArray = sut.TwoSum(nums, target);

            Assert.Equal(2, returnedArray.Length);
            Assert.Equal(2, returnedArray[0]);
            Assert.Equal(3, returnedArray[1]);
        }

        [Fact]
        public void ReturnArrayWithTwoDifferentIndices()
        {
            int[] nums = {2, 7, 11, 15, 7};
            int target = 14;
            
            Easy sut = new Easy();
            int[] returnedArray = sut.TwoSum(nums, target);

            Assert.NotEqual(returnedArray[0], returnedArray[1]);
        }

        [Fact]
        public void ReturnCorrectArrayWhenInputHasARepeatedValue()
        {
            int[] nums = {230,863,916,585,981,404,316,785,88,12,70,435,384,778,887,755,740,337,86,92,325,422,815,650,920,125,277,336,221,847,168,23,677,61,400,136,874,363,394,199,863,997,794,587,124,321,212,957,764,173,314,422,927,783,930,282,306,506,44,926,691,568,68,730,933,737,531,180,414,751,28,546,60,371,493,370,527,387,43,541,13,457,328,227,652,365,430,803,59,858,538,427,583,368,375,173,809,896,370,789};
            int target = 542;

            Easy sut = new Easy();
            int[] returnedArray = sut.TwoSum(nums, target);

            Assert.Equal(2, returnedArray.Length);
            Assert.Equal(28, returnedArray[0]);
            Assert.Equal(45, returnedArray[1]);
        }
    }
}