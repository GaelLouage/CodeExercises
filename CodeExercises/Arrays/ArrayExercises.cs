using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
