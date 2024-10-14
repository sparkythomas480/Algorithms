using System.Diagnostics;

namespace Algorithms.Sort;

public static class SelectionSort
{
    public static void DoAscending<T>(IList<T> elements)
    {
        Do(elements);
    }

    public static void DoDescending<T>(IList<T> elements)
    {
        Do(elements);
    }

   private static void Do<T>(IList<T> elements)
   {
         if (elements == null)
            throw new ArgumentNullException(nameof(elements), "The elements argument must not be null.");
   }
}