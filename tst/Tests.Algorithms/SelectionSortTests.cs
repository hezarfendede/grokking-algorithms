using System;
using System.Linq;
using Algorithms.Sort;
using FluentAssertions;
using Xunit;

namespace Tests.Algorithms.Sort
{
    public class SelectionSortTests
    {
        private readonly int[] _unsortedArray =
        {
            27, 17, 25, 4, 1, 3, 2, 6, 11, 12, 9, 7, 15, 5, 13, 17, 20, 16, 18, 14, 22, 23, 21
        };

        [Fact(DisplayName = "SST-001: SelectionSort throws an ArgumentNullException when the array is null.")]
        public void SST001()
        {
            // assign

            // act
            Action act = () => SelectionSort.Sort(null);

            // assert
            act.Should()
                .Throw<ArgumentNullException>();
        }

        [Fact(DisplayName = "SST-002: SelectionSort sorts an unsorted array correctly.")]
        public void SST002()
        {
            // assign
            var temp = _unsortedArray.ToList();
            temp.Sort();
            var expectedSortedArray = temp.ToArray();

            // act
            var result = SelectionSort.Sort(_unsortedArray);

            // assert
            result.Should().BeEquivalentTo(expectedSortedArray);
        }

        //[Fact(DisplayName = "BST-003: BinarySearch can find the index of an item that exists in the array.")]
        //public void BST003()
        //{
        //    // assign
        //    int item = 7;

        //    // act
        //    var result = BinarySearch.Search(_sortedArray, item);

        //    // assert
        //    result.Should().Be(6);
        //}
    }
}
