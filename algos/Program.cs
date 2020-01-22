using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace algos
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] returnedArray = new int[2];
            //returnedArray = HashTableFun();
            returnedArray = DictionaryFun();
            Console.WriteLine("Index 0: {0} | Index 1: {1}", returnedArray[0], returnedArray[1]);
                        
            // Easy e = new Easy();
            // RunTheMethod(e.TwoSum, ref returnedArray);
        }

        static void RunTheMethod(Func<int[], int, int[]> methodToBeRun, ref int[] returnedArray)
        {
            Stopwatch stopwatch = new Stopwatch();
            int[] nums = {7, 2, 11, 15};
            int target = 26;

            stopwatch.Start();

            returnedArray = methodToBeRun(nums, target);

            stopwatch.Stop();
            TimeSpan stopwatchElapsed = stopwatch.Elapsed;

            Console.WriteLine("Execution Time (Milliseconds) for {0}: {1}", methodToBeRun.Method.Name, Convert.ToDouble(stopwatchElapsed.TotalMilliseconds));
        }

        static int[] HashTableFun()
        {
            int[] returnVal = new int[2];
            
            int[] nums = {7, 2, 11, 15};
            int target = 17;
            
            Hashtable ht = new Hashtable();

            for (int i = 0; i < nums.Length; i++)
            {
                ht.Add(nums[i], i);
            }

            for (int i = 0; i < nums.Length; i++)
            {
                int desiredValue = target - nums[i];

                if (ht.ContainsKey(desiredValue))
                {
                    returnVal[0] = i;
                    returnVal[1] = (int)ht[desiredValue];
                    return returnVal;
                }
            }

            return returnVal;
        }

        static int[] DictionaryFun()
        {
            int[] returnVal = new int[2];

            int[] nums = {7, 2, 11, 15, 7};
            int target = 14;

            var d = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int desiredValue = target - nums[i];

                if (d.ContainsKey(desiredValue))
                {
                    returnVal[0] = d[desiredValue];
                    returnVal[1] = i;
                    return returnVal;
                }

                d.Add(nums[i], i);
            }

            return returnVal;
        }
    }
}
