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

            //Problem 3: Median of two sorted arrays of different sizes:       // STILL NEEDS TO BE FINISHED
            int[] nums1 = { 1, 5, 7 };
            int[] nums2 = { 2, 3, 9 };
            int[] mergedArray = new int[nums1.Length + nums2.Length];
            for (int i = 0; i < nums1.Length; i++)
            {
                mergedArray[i] = nums1[i];
            }
            for (int i = 0; i < nums2.Length; i++)
            {
                mergedArray[i + nums1.Length] = nums2[i];
            }

            int smallest = 312313;
            for (int i = 0; i < mergedArray.Length; i++)
            {
                for (int j = i; j < mergedArray.Length; j++)
                {
                    for (int k = (i + 1); k < mergedArray.Length; k++)
                    {
                        if (mergedArray[j] < mergedArray[k])
                        {
                            if (smallest > mergedArray[j])
                            {
                                smallest = mergedArray[j];
                            }
                        }
                        else if (mergedArray[j] > mergedArray[k])
                        {
                            if (smallest > mergedArray[k])
                            {
                                smallest = mergedArray[k];
                            }
                        }
                    }
                    mergedArray[i] = smallest;
                    smallest = 100;
                }
            }
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(mergedArray[i]);
            }



            /*
            int[] nums1 = { 1, 5, 7 };
            int[] nums2 = { 2, 3, 9 };
            int[] mergedArray = new int[nums1.Length + nums2.Length];
            int smallest = 5;
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
                    smallest = 100;
                }
            }
            for (int i = 0; i < 6; i ++)
            {
                Console.WriteLine(mergedArray[i]);
            }
            */ // This is all a failed attempt
        }
    }
}
