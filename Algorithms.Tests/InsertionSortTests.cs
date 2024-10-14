namespace Algorithms.Sort.Tests;

public class InsertionSortTests
{
    private static readonly int[] sortedSingleElement = new[] { 5 };
    private static readonly int[] sortedFiveElements = new[] { 3, 4, 5, 6, 10 };

    [Fact]
    public void DoOneArg_Throws_ArgumentNullException_When_Elements_Arg_Null()
    {
        var exception = Assert.Throws<ArgumentNullException>(() => InsertionSort.Do<double>(null!));
        Assert.Equal("elements", exception.ParamName);
        Assert.Equal("The elements argument must not be null. (Parameter 'elements')", exception.Message);
    }

    [Fact]
    public void DoOneArg_Works_Correctly_When_Zero_Elements()
    {
        var toSort = new List<int>();
        InsertionSort.Do(toSort);
        Assert.Empty(toSort);
    }

    [Fact]
    public void DoOneArg_Works_Correctly_When_One_Element()
    {
        var toSort = new List<int> { 5 };
        InsertionSort.Do(toSort);
        Assert.Equal(sortedSingleElement, toSort);
    }

    [Fact]
    public void DoOneArg_Sorts_Correctly_When_Five_Elements()
    {
        var toSort = new List<int> { 10, 3, 5, 4, 6 };
        InsertionSort.Do(toSort);
        Assert.Equal(sortedFiveElements, toSort);
    }

    [Fact]
    public void DoTwoArgs_Throws_ArgumentNullException_When_Elements_Arg_Null()
    {
        var exception = Assert.Throws<ArgumentNullException>(() => InsertionSort.Do(null!, Comparer<double>.Default));
        Assert.Equal("elements", exception.ParamName);
        Assert.Equal("The elements argument must not be null. (Parameter 'elements')", exception.Message);
    }

    [Fact]
    public void DoTwoArgs_Throws_ArgumentNullException_When_Comparer_Arg_Null()
    {
        var exception = Assert.Throws<ArgumentNullException>(() => InsertionSort.Do(new List<double>(), null!));
        Assert.Equal("comparer", exception.ParamName);
        Assert.Equal("The comparer argument must not be null. (Parameter 'comparer')", exception.Message);
    }

    [Fact]
    public void DoTwoArgs_Works_Correctly_When_Zero_Elements()
    {
        var toSort = new List<int>();
        InsertionSort.Do(toSort, Comparer<int>.Default);
        Assert.Empty(toSort);
    }

    [Fact]
    public void DoTwoArgs_Works_Correctly_When_One_Element()
    {
        var toSort = new List<int> { 5 };
        InsertionSort.Do(toSort, Comparer<int>.Default);
        Assert.Equal(sortedSingleElement, toSort);
    }

    [Fact]
    public void DoTwoArgs_Sorts_Correctly_When_Five_Elements()
    {
        var toSort = new List<int> { 10, 3, 5, 4, 6 };
        InsertionSort.Do(toSort, Comparer<int>.Default);
        Assert.Equal(sortedFiveElements, toSort);
    }
}