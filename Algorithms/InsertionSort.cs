using System.Diagnostics;

namespace Algorithms.Sort;

public static class InsertionSort
{
    public static void DoAscending(IList<int> elements)
    {
        Do(elements, (n1, n2) => n1 > n2);
    }

    public static void DoDescending(IList<int> elements)
    {
        Do(elements, (n1, n2) => n1 < n2);
    }

   private static void Do(IList<int> elements, Func<int, int, bool> comparer)
   {
        Debug.Assert(comparer != null);

         if (elements == null)
            return;

        if (elements.Count == 0 || elements.Count == 1)
            return;

        for (int i = 1; i < elements.Count; ++i)
        {
            int key = elements[i];
            int j = i - 1;
            while (j >= 0 && comparer(elements[j], key))
            {
                elements[j + 1] = elements[j];
                j -= 1;
            }

            elements[j + 1] = key;
        }
   }
}