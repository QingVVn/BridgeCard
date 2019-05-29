using System;
using BridgeCard;
using Xunit;

namespace BridgeCardTest
{
    public class Tests
    {
        [Theory]
        [InlineData("2H 3D 5S 9C KD","2C 3H 4S 8C AH","WhiteWin - HighCard")]
        public void ShouldWhiteWin(string black, string white, string expect)
        {
            var common = new Common(black,white);
            Assert.Equal(expect,common.GetResult());
        }
        
        [Theory]
        [InlineData("2H 4S 4C 2D 4H","2H 5S 5C 2D 5H","BlackWin - FullHouse")]
        public void ShouldBlackWin(string black, string white, string expect)
        {
            var common = new Common(black,white);
            Assert.Equal(expect,common.GetResult());
        }
        
        [Theory]
        [InlineData("2H 3D 5S 9C KD","2D 3H 5C 9S KH","Tie")]
        public void ShouldTie(string black, string white, string expect)
        {
            var common = new Common(black,white);
            Assert.Equal(expect,common.GetResult());
        }
    }
}