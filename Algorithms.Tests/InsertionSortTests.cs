using Algorithms.Sort;

namespace Algorithms.Tests;

public class InsertionSortTests
{
    private static readonly int[] sortedFiveElements = new[] { 3, 4, 5, 6, 10 };

    [Fact]
    public void DoAscending_Throws_ArgumentNullException_When_Arg_Null()
    {
        var exception = Assert.Throws<ArgumentNullException>(() => InsertionSort.DoAscending(null!));
        Assert.Equal("elements", exception.ParamName);
        Assert.Equal("The elements parameter must not be null.", exception.Message);
    }

    [Fact]
    public void DoAscending_Sorts_Correctly_When_Five_Elements()
    {
        var toSort = new List<int> {10, 3, 5, 4, 6};
        InsertionSort.DoAscending(toSort);
        Assert.Equal(sortedFiveElements, toSort);
    }
}