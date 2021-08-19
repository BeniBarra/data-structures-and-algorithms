using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
  public class CC28QuickSort
  {

    public static void QuickSort(int[] arr, int left, int right)
    {
      if (left < right)
      {
        int position = Partition(arr, left, right);
        QuickSort(arr, left, position - 1);
        QuickSort(arr, position + 1, right);
      }
    }

    public static int Partition(int[] arr, int left, int right)
    {
      int pivot = arr[right];
      int low = left - 1;
      for (int i = left; i < right; i++)
      {
        if (arr[i] <= pivot)
        {
          low++;
          Swap(arr, i, low);
        }
      }
       
      Swap(arr, right, low + 1);

      return low + 1;
    }

    public static void Swap(int[] arr, int i, int low)
    {
      int temp = arr[i];
      arr[i] = arr[low];
      arr[low] = temp;
    }

  }
}
