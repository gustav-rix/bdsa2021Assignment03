using System;
using Xunit;
using System.Collections.Generic;
using System.Linq;

namespace Assignment3.Tests
{
    public class ExtensionsTests
    {
          [Fact]
        public static void Uri_is_secure_given_https(){
            //Assign         
            Uri uri = new Uri("https://www.google.com/");
            bool expected = true;
            //Act
            bool actual = Extensions.isSecure(uri);

            //Assert     
            Assert.Equal(expected, actual);
        }
         
         [Fact]
         public static void Uri_is_not_secure_given_http(){
            //Assign
            Uri uri = new Uri("http://www.google.com/");
            bool expected = false;

            //Act
            bool actual = Extensions.isSecure(uri);

            //Assert
            Assert.Equal(expected, actual);
         }
        
        [Fact]
        public static void WordCount(){
            //Assign
            string s = "Ape their form with different content Copy them exactly";
            int expected = 9;
            //Act
            int actual = s.wordCount();
            //Assert
            Assert.Equal(expected, actual);
    }
}
}