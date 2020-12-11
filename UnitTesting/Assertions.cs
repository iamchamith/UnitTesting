using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace UnitTesting
{
    public class Assertions
    {
        public void A()
        {

            Assert.Equal("a", "a");
            Assert.NotEqual("a", "b");

            Assert.True(true);
            Assert.False(false);

            Assert.Contains("my name is khan", "name", StringComparison.InvariantCultureIgnoreCase);
            Assert.DoesNotContain("my name is khan", "don", StringComparison.InvariantCultureIgnoreCase);


            Assert.Matches(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$", "iamchamith@gmail.com");
            Assert.DoesNotMatch(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$", "iamchamith@gmail@.com");

            Assert.Empty(null);
            Assert.NotEmpty("abc");

            Assert.EndsWith("my name is khan", "khan");

            Assert.IsType<string>("a");
            Assert.IsNotType<string>(1);

            Assert.InRange(actual: 5, low: 1, high: 10);
            Assert.NotInRange(actual: 0, low: 1, high: 10);

            Assert.StartsWith("my name is khan", "my");
        }
    }
}
