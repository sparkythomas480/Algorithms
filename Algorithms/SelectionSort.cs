namespace Algorithms.Sort;

public static class SelectionSort
{
    public static void Do<T>(IList<T> elements)
    {
        Do(elements, Comparer<T>.Default);
    }

    public static void Do<T>(IList<T> elements, IComparer<T> comparer)
    {
        if (elements == null)
            throw new ArgumentNullException(nameof(elements), "The elements argument must not be null.");

        if (comparer == null)
            throw new ArgumentNullException(nameof(comparer), "The comparer argument must not be null.");
    }
}