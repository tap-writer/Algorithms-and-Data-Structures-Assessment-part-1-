using System;

namespace CampusParcelAssessment
{
    public static class Algorithms
    {
        public static void ExampleQuestion()
        {
            //F.C
            Console.WriteLine("Enter a number 1:");          // 1
            int num1 = Int32.Parse(Console.ReadLine());      // 1

            Console.WriteLine("Enter a number 2:");          // 1
            int num2 = Int32.Parse(Console.ReadLine());      // 1

            for (int i = 1; i <= num2; i++)                  // n + 1
            {
                Console.WriteLine(num1.ToString() + " X "
                    + i.ToString() + " = " + (num1 * i));   // n
            }

            Console.WriteLine("End of program...");         // 1

            Console.ReadLine();                             // 1


            //Working out

            // 7 + 2n - All F.Cs added together
            // 2n     - Constants removed
            // n      - Coefficients removed
            // O(n)   - Final answer
        }

        // Task C: select only parcels due on the requested date.
        // Add a frequency count beside every executable line in this method.
        // After the method, show:
        // 1. All frequency counts added together.
        // 2. Constants and lower-order terms removed.
        // 3. The most significant term retained and its coefficient removed.
        // 4. The final O(...) result.
        // refer to above ExampleQuestion for BigO notation calculation format
        public static DispatchEntry[] SelectParcelsForDate(Parcel[] parcels, DateTime date)
        {
            throw new NotImplementedException("Task C: implement date selection.");
        }



        // Task C: recursive generic QuickSort using CompareTo.
        // Use the provided QuickSort function as a starting point for
        // adjusting the functionality to make it generic. 
        static void swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }

        static public void QuickSort(int[] items, int left, int right)
        {
            int i, j;
            i = left; j = right;
            int pivot = items[left];

            while (i <= j)
            {
                for (; (items[i] < pivot) && (i < right); i++) ;
                for (; (pivot < items[j]) && (j > left); j--) ;

                if (i <= j)
                    swap(ref items[i++], ref items[j--]);
            }

            if (left < j) QuickSort(items, left, j);
            if (i < right) QuickSort(items, i, right);
        }
        
        
        public static void QuickSortGen<T>(T[] items) where T : IComparable
        {
            throw new NotImplementedException("Task C: implement generic QuickSort.");
        }

        // Add private recursive and partition methods here.
    }
}
