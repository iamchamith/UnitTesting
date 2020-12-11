using System;
using System.Diagnostics;
using Xunit;

namespace UnitTesting
{
    public class UnitTest2 : IDisposable, IClassFixture<MyFixture>
    {
        public UnitTest2()
        {
            Debug.WriteLine("cTor:UnitTest2");
        }

        public void Dispose()
        {
            Debug.WriteLine("Dispose:UnitTest2");
        }

        [Fact]
        public void TestOne()
        {
            Debug.WriteLine("UnitTest2/TestOne");
        }

        [Fact]
        public void TestTwo()
        {
            Debug.WriteLine("UnitTest2/TestTwo");
        }
    }
}
