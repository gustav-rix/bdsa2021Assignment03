using System;
using Xunit;

namespace Assignment3.Tests
{
    public class DelegatesTests
    {
        public delegate string ReverseString(string x);
        public delegate int Product(int a, int b);
        public delegate Boolean IsNumber(string stringNumber, int intNumber);

        [Fact]
        public void takes_a_string_and_prints_the_content_in_reverse_order_by_character()
        {
            //Arrange
            var expected = "xofnworb";
            var teststring = "brownfox";
           Func<string, string> reverseString = (x) => {
                 char[] charArray = x.ToCharArray();
                 Array.Reverse( charArray );
                 return new string( charArray );
            };
            //Act
            var actual = reverseString(teststring);

            //Assert
            Assert.Equal(expected, actual);
        }
        
        [Fact]
        public void takes_two_decimals_return_the_product()
        {
            //Arrange
            Func<double, double, double> product = (a, b) => {return a * b;};
            var x1 = 2.0;
            var y1 = 1.2;
            var expected = 2.4;
            //Act
            var actual = product(x1, y1);

            //Assert
            Assert.Equal(expected, actual);
        }
          [Fact]
        public void Delegate_tests_if_string_is_numerical()
        {
            //Arrange
            Func<string, int, bool> isAnNumber = (s, i) => {int o; return int.TryParse(s, out o);};
            var s1 = "0042";
            var i1 = 42;
            var expected = true;
            //Act
            var actual = isAnNumber(s1,i1);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
