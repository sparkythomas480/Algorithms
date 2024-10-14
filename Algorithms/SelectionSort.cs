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

        for (int i = 0; i < elements.Count - 1; ++i)
        {
            T key = elements[i];
            int index = i;
            for (int j = i + 1; j < elements.Count; ++j)
            {
                if (comparer.Compare(key, elements[j]) > 0)
                {
                    key = elements[j];
                    index = j;
                }
            }

            (elements[i], elements[index]) = (elements[index], elements[i]);
        }
    }
}