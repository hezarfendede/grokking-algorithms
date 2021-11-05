using System;
using Algorithms.Search;
using FluentAssertions;
using Xunit;

namespace Tests.Algorithms.Search
{
    public class BinarySearchTests
    {
        private readonly int[] _sortedArray =
        {
            1, 2, 3, 4, 5, 6, 7, 9, 11, 12, 13, 14, 15, 16, 17, 18, 20, 21, 22, 23, 25, 26, 27
        };

        [Fact(DisplayName = "BST-001: BinarySearch throws an ArgumentNullException when the array is null.")]
        public void BST001()
        {
            // assign

            // act
            Action act = () => BinarySearch.Search(null, 8);

            // assert
            act.Should()
                .Throw<ArgumentNullException>();
        }

        [Fact(DisplayName = "BST-002: BinarySearch can't find an item that does not exist in the array.")]
        public void BST002()
        {
            // assign
            int item = 8;

            // act
            var result = BinarySearch.Search(_sortedArray, item);

            // assert
            result.Should().BeNull();
        }

        [Fact(DisplayName = "BST-003: BinarySearch can find the index of an item that exists in the array.")]
        public void BST003()
        {
            // assign
            int item = 7;

            // act
            var result = BinarySearch.Search(_sortedArray, item);

            // assert
            result.Should().Be(6);
        }
    }
}
