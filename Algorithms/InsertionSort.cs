using System.Diagnostics;

namespace Algorithms.Sort;

public static class InsertionSort
{
    private sealed class DescendingComparer<T> : IComparer<T>
    {
        public static readonly DescendingComparer<T> instance = new DescendingComparer<T>();
        private readonly Comparer<T> ascendingComparer = Comparer<T>.Default;

        int IComparer<T>.Compare(T? x, T? y)
        {
            // Note that we're swapping the arguments around here t make
            // the sort a descend instead of ascend. We could alternatively
            // call the original with (x, y) and then multiply the result by
            // -1
            return ascendingComparer.Compare(y, x);
        }
    }

    public static void DoAscending<T>(IList<T> elements)
    {
        Do(elements, Comparer<T>.Default);
    }

    public static void DoDescending<T>(IList<T> elements)
    {
        Do(elements, DescendingComparer<T>.instance);
    }

   private static void Do<T>(IList<T> elements, IComparer<T> comparer)
   {
        Debug.Assert(comparer != null);

         if (elements == null)
            throw new ArgumentNullException(nameof(elements), "The elements argument must not be null.");

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