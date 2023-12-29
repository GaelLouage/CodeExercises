using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CodeExercises.Arrays
{
    internal static class ArrayExercises
    {
        #region FrequencyCounter
        /*Write a C# Sharp program to count the frequency of each element in an array.
        Test Data :
        Input the number of elements to be stored in the array :3
        Input 3 elements in the array :
        element - 0 : 25
        element - 1 : 12
        element - 2 : 43
        Expected Output :
        Frequency of all elements of array :
        25 occurs 1 times
        12 occurs 1 times
        43 occurs 1 times*/
        public static Dictionary<TKey, int> GenerateElementFrequencyMap<TKey>(TKey[] array)
        {
            var elements = new Dictionary<TKey, int>();
            foreach (var num in array)
            {
                if (elements.ContainsKey(num))
                {
                    elements[num]++;
                }
                else
                {
                    elements.Add(num, 1);
                }
            }
            return elements;
        }
        public static Dictionary<int, int> GenerateElementFrequencyMapLinq(int[] array) => array.GroupBy(x => x).ToDictionary(x => x.Key, c => c.Count());
        #endregion
        #region GetMinAndMaxValueOfArray
        /*Write a C# Sharp program to find the maximum and minimum elements in an array.
        Test Data :
        Input the number of elements to be stored in the array :3
        Input 3 elements in the array :
        element - 0 : 45
        element - 1 : 25
        element - 2 : 21
        Expected Output :
        Maximum element is : 45
        Minimum element is : 21*/
        public static (int Min, int Max) GetMinAndMaxValueLinq(int[] array) => (array.Min(), array.Max());
        public static (int Min, int Max) GetMinAndMaxValue(int[] array)
        {
            int max = Int32.MinValue;
            int min = Int32.MaxValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (max < array[i]) max = array[i];
                if (min > array[i]) min = array[i];
            }
            return (min, max);
        }
        #endregion
        #region OddAndEven
        /*Write a program in C# Sharp to separate odd and even integers into separate arrays.
        Test Data :
        Input the number of elements to be stored in the array :5
        Input 5 elements in the array :
        element - 0 : 25
        element - 1 : 47
        element - 2 : 42
        element - 3 : 56
        element - 4 : 32
        Expected Output:
        The Even elements are:
        42 56 32
        The Odd elements are :
        25 47*/
        public static (List<int> Odd, List<int> Even) SeperateOddAndEvenNumbers(int[] array)
        {
            var odd = new List<int>();
            var even = new List<int>();
            foreach (var num in array)
            {
                if (num % 2 is 0) even.Add(num);
                if (num % 2 is not 0) odd.Add(num);
            }
            return (odd, even);
        }
        public static (List<int> Odd, List<int> Even) SeperateOddAndEvenNumbersLinq(int[] array) =>
         (array.Where(x => x % 2 != 0).ToList(), array.Where(x => x % 2 == 0).ToList());
        #endregion

    }
}
