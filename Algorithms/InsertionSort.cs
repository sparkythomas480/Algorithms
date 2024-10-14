using System.Diagnostics;

namespace Algorithms.Sort;

public static class InsertionSort
{
    private sealed class DescendingComparer : IComparer<int>
    {
        public static readonly DescendingComparer instance = new DescendingComparer();
        private readonly Comparer<int> ascendingComparer = Comparer<int>.Default;

        int IComparer<int>.Compare(int x, int y)
        {
            return ascendingComparer.Compare(y, x);
        }
    }

    public static void DoAscending(IList<int> elements)
    {
        Do(elements, Comparer<int>.Default);
    }

    public static void DoDescending(IList<int> elements)
    {
        Do(elements, DescendingComparer.instance);
    }

   private static void Do(IList<int> elements, IComparer<int> comparer)
   {
        Debug.Assert(comparer != null);

         if (elements == null)
            throw new ArgumentNullException(nameof(elements), "The elements argument must not be null.");

        for (int i = 1; i < elements.Count; ++i)
        {
            int key = elements[i];
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