using System;
using Xunit;
using System.Collections.Generic;

namespace Assignment3.Tests
{
    public class QueriesTests
    {
         [Fact]
        public void queries_wizards_invented_by_rowling()
        {
            //Arrange
            var expected = new List<string>() { "VOLDEMORT", "RON", "Lilly", "James", "Arthur", "Harry" };

            //Act
            var actual = Queries.wizards_invented_by_rowling();

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void queries_wizards_invented_by_rowling_extension()
        {
            //Arrange
            var expected = new List<string>(){ "VOLDEMORT", "RON", "Lilly", "James", "Arthur", "Harry" };

            //Act
            var actual = Queries.wizards_invented_by_rowling_extension();

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void year_the_first_sith_lord_was_introduced()
        {
            //Arrange
            var expected = 1977;

            //Act
            var actual = Queries.year_the_first_sith_lord_was_introduced();

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void unique_list_of_harry_potter_wizards_(){
            //Arrange
            var expected = new []{
                ("DUMBLEDORE", 2021),
                ("VOLDEMORT", 2002),
                ("RON", 2000),
                ("Lilly", 1998),
                ("James", 1999),
                ("Arthur", 1997),
                ("Harry", 1996),
            };

            //Act
            var actual = Queries.unique_list_of_harry_potter_wizards();

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void unique_list_of_harry_potter_wizards_extension(){
            //Arrange
            var expected = new []{
                ("DUMBLEDORE", 2021),
                ("VOLDEMORT", 2002),
                ("RON", 2000),
                ("Lilly", 1998),
                ("James", 1999),
                ("Arthur", 1997),
                ("Harry", 1996),
            };

            //Act
            var actual = Queries.unique_list_of_harry_potter_wizards_extension();

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void list_of_wizard_names_grouped_by_creator_in_reverse_order()
        {
            var expected = new []{
                ("Merlin"),
                ("GLINDA"),
                ("WILLOW"),
                ("Sauron"),
                ("GANDALF"),
                ("DUMBLEDORE"),
                ("VOLDEMORT"),
                ("RON"),
                ("Lilly"),
                ("James"),
                ("Harry"),
                ("Arthur"),
                ("Darth Vader"),
            };
            
            //Act
            var actual = Queries.list_of_wizard_names_grouped_by_creator_in_reverse_order();

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void list_of_wizard_names_grouped_by_creator_in_reverse_order_extension()
        {
            var expected = new []{
                ("Merlin"),
                ("GLINDA"),
                ("WILLOW"),
                ("Sauron"),
                ("GANDALF"),
                ("DUMBLEDORE"),
                ("VOLDEMORT"),
                ("RON"),
                ("Lilly"),
                ("James"),
                ("Harry"),
                ("Arthur"),
                ("Darth Vader"),
            };
            
            //Act
            var actual = Queries.list_of_wizard_names_grouped_by_creator_in_reverse_order_extension();
            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
