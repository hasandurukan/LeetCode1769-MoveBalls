using System;

namespace MoveBallsLeetCode1769
{
    class Program
    {
        static void Main(string[] args)
        {
            string boxes = "001011";
            int[] result = MinOperations(boxes);
            for (int i = 0; i < result.Length; i++)
            {
                Console.Write(result[i] + ",");
            }
            Console.ReadKey();
        }
        static int[] MinOperations(string boxes)
        {
            int[] result = new int[boxes.Length];
            for (int i = 0; i < boxes.Length; i++)
            {
                for (int m = 0; m < boxes.Length; m++)
                {
                    if (boxes[m] == '1' && i != m)
                    {
                        result[i] += Math.Abs(m - i);
                    }
                }
            }
            return result;
        }
    }
}
