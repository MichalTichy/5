﻿using Examples;
using Xunit;

namespace Lecture02.Tests
{
    public class AsOperator
    {
        [Fact]
        public void AsOperatorTest()
        {
            WildCat unknownCat = new WildCat();

            Assert.Null(unknownCat as Cat);
        }
    }
}