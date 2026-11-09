using Microsoft.Win32.SafeHandles;

namespace someProblemsForAiRoadmap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Problem 1: Find the largest prime factor of a given number:
            Console.WriteLine("Please enter a number:");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                while (n % i == 0)
                {
                    n /= i;
                }
            }
            Console.WriteLine("The largest prime factor is: " + n);

            // Problem 2: Find all triplets in an array that sum to 0:
            int[] arr = { -1, 0, 1, 2, 3, -1, -4 };
            Console.WriteLine("Triplets that sum to 0:");
            for (int i = 0; i < arr.Length - 2; i++)
            {
                for (int j = i + 1; j < arr.Length - 1; j++)
                {
                    for (int k = j + 1; k < arr.Length; k++)
                    {
                        if (arr[i] + arr[j] + arr[k] == 0)
                        {
                            Console.WriteLine(arr[i] + ", " + arr[j] + ", " + arr[k]);
                        }
                    }
                }
            }

            //Problem 3: Median of two sorted arrays of the same size:
            int[] nums1 = { 1, 5, 7 };
            int[] nums2 = { 2, 3, 9 };
            int[] mergedArray = new int[nums1.Length + nums2.Length];
            int smallest = nums1[0];
            for (int i = 0; i < mergedArray.Length; i++)
            {
                for (int j = i; j < nums1.Length; j++)
                {
                    for (int k = i; k < nums2.Length; k++)
                    {
                        if (nums1[j] < nums2[k])
                        {
                            if (smallest > nums1[j])
                            {
                                smallest = nums1[j];
                            }
                        }
                        else if (nums1[j] > nums1[k])
                        {
                            if (smallest > nums2[k])
                            {
                                smallest = nums2[k];
                            }
                        }
                    }
                    mergedArray[i] = smallest;
                }
            }
            for (int i = 0; i < 6; i ++)
            {
                Console.WriteLine(mergedArray[i]);
            }
        }
    }
}
