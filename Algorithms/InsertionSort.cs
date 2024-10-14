namespace Algorithms.Sort;

public static class InsertionSort
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

        for (int i = 1; i < elements.Count; ++i)
        {
            T key = elements[i];
            int j = i - 1;
            while (j >= 0 && comparer.Compare(elements[j], key) > 0)
            {
                elements[j + 1] = elements[j];
                j -= 1;
            }

            elements[j + 1] = key;
        }
    }
}