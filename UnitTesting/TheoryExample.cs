using System.Collections;
using System.Collections.Generic;
using Xunit;

namespace UnitTesting
{
    public class TheoryExample
    {
        TestableClass _testableClass;
        public TheoryExample()
        {
            _testableClass = new TestableClass();
        }
        [Theory]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(5)]
        [InlineData(71)]
        public void IsPrime_Yes(int value)
        {
            var result = _testableClass.IsPrime(value);

            Assert.True(result);
        }

        [Theory]
        [InlineData(6)]
        [InlineData(77)]
        [InlineData(100)]
        [InlineData(81)]
        public void IsPrime_No(int value)
        {
            var result = _testableClass.IsPrime(value);

            Assert.False(result);
        }

        [Theory]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(5)]
        [InlineData(8)]
        public void Persons_Success(int value)
        {
            var result = _testableClass.IsPrime(value);

            Assert.True(result);
        }

        [Theory]
        [ClassData(typeof(PersonClassData))]
        public void IsEmployee(object a)
        {

            System.Console.WriteLine("tess");
            //  Assert.True(person.IsEmployee);
        }

        [Fact(Skip = "need to skip")]
        public void Skip()
        {

        }
    }

    public class PersonClassData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] {
                new Person(1,"Kamal","Kandana",true),
                 new Person(2,"Supun","Kottawa",true),
                  new Person(3,"Nimal","Gampaha",true),
                   new Person(4,"Anil","Nugegoda",true)
            };
        }
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
