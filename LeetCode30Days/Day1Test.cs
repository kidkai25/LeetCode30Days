using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetCode30Days
{
    public class Day1Test
    {
        //[Theory]
        ////[InlineData(new[] { 2,2,1})]
        //[InlineData(new[] { 4,1,2,1,2})]
        //void day1method(int[] array)
        //{
        //    //Arrange
        //    //var array = new[] { 2, 2, 1 };

        //    //Act
        //    var result = Day1.SingleNumber(array);
        //    //Assert
        //    Assert.Equal(4, result);

        //}
        //--------------------------------------------------------//
        //[Theory]
        //[InlineData(19)]
        //void day2method(int b)
        //{
        //    //Act
        //    var result = Day2.IsHappy(b);
        //    //Assert
        //    Assert.True(result);

        //}
        [Theory]
        [InlineData(new[]{0,1,0,3,12})]
        void day3method(int[] nums)
        {
            //Act
            var result = Day3.MoveZeroes(nums);
            //Assert
            Assert.Equal(new[] { 1, 3, 12, 0, 0 }, result);
        }
       

    }
}
