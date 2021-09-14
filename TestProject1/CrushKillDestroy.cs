using System;
using ClassLibrary1;
using Xunit;
using Xunit.Sdk;

namespace TestProject1
{
    public class CrushKillDestroy
    {
        [Fact]
        public void TwoStringsTest()
        {
            // arrange
            Class1 obj = new Class1();
            int length;
            string[] strings = {"Hello", "World"};
            
            // act
            length = obj.StringLengths(strings);

            // assert
            Assert.Equal("Hello".Length + "World".Length, length);
        }

        [Fact]
        public void EmptyArraytest()
        {
            Class1 obj = new Class1();
            string[] strings = { };

            int length = obj.StringLengths(strings);

            Assert.Equal(0, length);
        }

        [Fact]
        public void NullArraytest()
        {
            Class1 obj = new Class1();
            string[] strings = null;
            
            int length = obj.StringLengths(strings);

            Assert.Equal(0, length);
        }

        [Fact]
        public void TwoStringsAndNullTest()
        {
            // arrange
            Class1 obj = new Class1();
            int length;
            string[] strings = { "Hello", "World", null };

            // act
            length = obj.StringLengths(strings);

            // assert
            Assert.Equal("Hello".Length + "World".Length, length);
        }
    }
}
