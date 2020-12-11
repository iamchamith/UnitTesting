using System;
using System.Diagnostics;

namespace UnitTesting
{
    public class MyFixture : IDisposable
    {
        public MyFixture()
        {
            Console.WriteLine("cTor:MyFixture");
        }

        public void Dispose()
        {
            Console.WriteLine("Dispose:MyFixture");
        }
    }
}
