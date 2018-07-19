using System;
using System.Linq;
using System.Collections.Generic;

namespace Transform
{
    public static class Transform 
    {
        public delegate int del(int num);

        public static int[] Map(this int[] numbers, del operation)
        {
            int[] result = new int[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                result[i] = operation(numbers[i]);
            }
            return result;
        }
    }
}
