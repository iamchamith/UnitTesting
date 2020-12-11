using System;
using System.Diagnostics;
using Xunit;

namespace UnitTesting
{
    public class UnitTest1 : IDisposable, IClassFixture<MyFixture>
    {
        public UnitTest1()
        {
            Console.WriteLine("cTor:UnitTest1");
        }

        public void Dispose()
        {
            Console.WriteLine("Dispose:UnitTest1");
        }

        [Fact]
        public void TestOne()
        {
            Console.WriteLine("UnitTest1:TestOne");
        }

        [Fact]
        public void TestTwo()
        {
            Console.WriteLine("UnitTest1/TestTwo");
        }
    }
}
