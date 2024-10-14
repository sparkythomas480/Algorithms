using Algorithms.Sort;

namespace Algorithms.Tests;

public class InsertionSortTests
{
    private static readonly int[] ascendSortedFiveElements = new[] { 3, 4, 5, 6, 10 };
    private static readonly int[] descendSortedFiveElements = new[] { 10, 6, 5, 4, 3 };

    [Fact]
    public void DoAscending_Throws_ArgumentNullException_When_Arg_Null()
    {
        var exception = Assert.Throws<ArgumentNullException>(() => InsertionSort.DoAscending(null!));
        Assert.Equal("elements", exception.ParamName);
        Assert.Equal("The elements argument must not be null. (Parameter 'elements')", exception.Message);
    }

    [Fact]
    public void DoAscending_Sorts_Correctly_When_Five_Elements()
    {
        var toSort = new List<int> {10, 3, 5, 4, 6};
        InsertionSort.DoAscending(toSort);
        Assert.Equal(ascendSortedFiveElements, toSort);
    }

    [Fact]
    public void DoDescending_Throws_ArgumentNullException_When_Arg_Null()
    {
        var exception = Assert.Throws<ArgumentNullException>(() => InsertionSort.DoDescending(null!));
        Assert.Equal("elements", exception.ParamName);
        Assert.Equal("The elements argument must not be null. (Parameter 'elements')", exception.Message);
    }

    [Fact]
    public void DoDescending_Sorts_Correctly_When_Five_Elements()
    {
        var toSort = new List<int> {10, 3, 5, 4, 6};
        InsertionSort.DoDescending(toSort);
        Assert.Equal(descendSortedFiveElements, toSort);
    }
}