using Algorithms.Sort;

namespace Algorithms.Tests;

public class InsertionSortTests
{
    [Fact]
    public void DoAscending_Sorts_Correctly_When_Five_Elements()
    {
        var toSort = new List<int> {10, 3, 5, 4, 6};
        InsertionSort.DoAscending(toSort);
        Assert.Equal(new[] {3, 4, 5, 6, 10}, toSort);
    }
}