using System;
using System.Linq;
using Algorithms.Sort;
using FluentAssertions;
using Xunit;

namespace Tests.Algorithms.Sort
{
    public class SelectionSortTests
    {
        private readonly int[] _unsortedArrayWithUniqueItems =
        {
            27, 17, 25, 4, 1, 3, 2, 6, 11, 12, 9, 7, 15, 5, 13, 17, 20, 16, 18, 14, 22, 23, 21
        };

        private readonly int[] _unsortedArrayWithDuplicateItems =
        {
            2, 27, 17, 25, 2, 4, 1, 3, 27, 2, 6, 11, 21, 12, 9, 7, 15, 5, 13, 1, 17, 20, 7, 16, 1, 18, 1, 1, 14, 22, 23, 21
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

        [Fact(DisplayName = "SST-002: SelectionSort sorts an unsorted array with unique items correctly.")]
        public void SST002()
        {
            // assign
            var temp = _unsortedArrayWithUniqueItems.ToList();
            temp.Sort();
            var expectedSortedArray = temp.ToArray();

            // act
            var result = SelectionSort.Sort(_unsortedArrayWithUniqueItems);

            // assert
            result.Should().BeEquivalentTo(expectedSortedArray);
        }

        [Fact(DisplayName = "SST-003: SelectionSort sorts an unsorted array with duplicate items correctly.")]
        public void SST003()
        {
            // assign
            var temp = _unsortedArrayWithDuplicateItems.ToList();
            temp.Sort();
            var expectedSortedArray = temp.ToArray();

            // act
            var result = SelectionSort.Sort(_unsortedArrayWithDuplicateItems);

            // assert
            result.Should().BeEquivalentTo(expectedSortedArray);
        }
    }
}
