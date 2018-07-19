using System;
using System.Linq;
using System.Collections.Generic;

namespace Transform
{
    public static class Transform 
    {
        public static TResult[] Map<TResult>(this int[] numbers, Func<int, TResult> operation)
        {
            TResult[] result = new TResult[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                result[i] = operation(numbers[i]);
            }
            return result;
        }
    }
}
