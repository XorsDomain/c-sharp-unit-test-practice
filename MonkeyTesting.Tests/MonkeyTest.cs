using System;
using Xunit;
using System.Linq;
using System.Collections.Generic;
using MonkeyTesting;
namespace MonkeyTesting.Tests
{
    public class MonkeyTesting
    {
        MonkeyTrouble monkeyTrouble;
        public MonkeyTesting()
        {
            monkeyTrouble = new MonkeyTrouble();
        }

        [Fact]
        public void BothMonkeys_Smiling_ReturnTrue()
        {
            bool monkeyASmiling = true;
            bool monkeyBSmiling = true;
            var expected = true;
            var actual = monkeyTrouble.Trouble(monkeyASmiling, monkeyBSmiling);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void OnlyMonkeyA_Smiling_ReturnsFalse()
        {
            bool monkeyASmiling = true;
            bool monkeyBSmiling = false;
            var expected = false;
            var actual = monkeyTrouble.Trouble(monkeyASmiling, monkeyBSmiling);
            Assert.Equal(expected, actual);
        }

                [Fact]
        public void OnlyMonkeyB_Smiling_ReturnsFalse()
        {
            bool monkeyASmiling = false;
            bool monkeyBSmiling = true;
            var expected = false;
            var actual = monkeyTrouble.Trouble(monkeyASmiling, monkeyBSmiling);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void NeitherMonkey_Smiling_ReturnsTrue()
        {
            bool monkeyASmiling = false;
            bool monkeyBSmiling = false;
            var expected = true;
            var actual = monkeyTrouble.Trouble(monkeyASmiling, monkeyBSmiling);
            Assert.Equal(expected, actual);
        }
    }
}
