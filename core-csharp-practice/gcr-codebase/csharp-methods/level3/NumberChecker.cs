using BridgeLabzTraining.Methods.level1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BridgeLabzTraining.Methods.level3
{
    internal class NumberChecker
    {
        public static int CountDigits(int number)
        {
            int count = 0;
            while (number > 0)
            {
                number /= 10;
                count++;
            }
            return count;
        }

        public static int[] StoreDigits(int number)
        {
            int length = CountDigits(number);
            int[] arr = new int[length];
            int counter = length-1;
            while (number > 0)
            {
                arr[counter] = number % 10;
                number /= 10;
                counter--;
            } 
            return arr;
        }

        public static void DuckNumber(int number)
        {
            while (number > 0)
            {
                if (number % 10 == 0)
                {
                    Console.WriteLine("DuckNumber");
                    return;
                }
                number /= 10;
            }
            Console.WriteLine("Not a duck number");
        }

        public static void ArmstrongNumber(int number)
        {

            int[] temp = StoreDigits(number);
            int tempLength = temp.Length;
            double store = 0;
            for (int i = 0; i < tempLength; i++)
            {
                store += Math.Pow(temp[i], tempLength);
            }
            if (store == number)
            {
                Console.WriteLine("Armstrong Number");
                return;
            }
            Console.WriteLine("Not a Armstrong Number");
        }
        
        public static void SecondLargest(int number)
        {
            int[] arr = StoreDigits(number);
            int arrLength = arr.Length;
            int largest = int.MinValue;
            int slargest = int.MinValue;


            //applying logic to find largest and second largest 
            for (int i = 0; i < arrLength; i++)
            {
                if (arr[i] > largest)
                {
                    slargest = largest;
                    largest = arr[i];

                }
                else if (arr[i] > slargest && arr[i] < largest)
                {
                    slargest = arr[i];
                }
                else
                {
                    continue;
                }
            }
            if (slargest == int.MinValue)
            {
                Console.WriteLine("Second largest element does not exist");
            }
            Console.WriteLine($"Largest Element {largest}");
            Console.WriteLine($"Second Largest Element {slargest}");
        }

        public static void SecondSmallest(int number)
        {
            int[] arr = StoreDigits(number);
            int arrLength = arr.Length;
            int smallest = int.MaxValue;
            int ssmallest = int.MaxValue;

            //applying logic to find smallest and second smallest 
            for (int i = 0; i < arrLength; i++)
            {
                if (arr[i] < smallest)
                {
                    ssmallest = smallest;
                    smallest = arr[i];
                }
                else if (arr[i] < ssmallest && arr[i] > smallest)
                {
                    ssmallest = arr[i];
                }
                else
                {
                    continue;
                }
            }

            if (ssmallest == int.MaxValue)
            {
                Console.WriteLine("Second smallest element does not exist");
            }

            Console.WriteLine($"Smallest Element {smallest}");
            Console.WriteLine($"Second Smallest Element {ssmallest}");
        }

        public static int SumDigits(int number)
        {
            int[] temp = StoreDigits(number);
            int sum = 0;
            for (int i = 0; i < temp.Length; i++)
            {
                sum+= temp[i];
            }

            Console.WriteLine($"Sum of the digits is {sum}");
            return sum;
        }

        public static void SumSquareDigits(int number)
        {
            int[] temp = StoreDigits(number);
            double sum = 0;
            for (int i = 0; i < temp.Length; i++)
            {
                sum += Math.Pow(temp[i],2);
            }
            Console.WriteLine($"Sum of square of the digits is {sum}");
        }

        public static void HarshadNumber(int n)
        {
            int sum = 0;
            int temp = n;
            while (n > 0)
            {
                sum = sum + n % 10;
                n = n / 10;
            }
            if (temp % sum == 0)
            {
                Console.WriteLine("Harshad Number");
            }
            else
            {
                Console.WriteLine("Not a Harshad Number");
            }
        }
        public static int CountFrequency(int x,int[] arr)
        {
            int count = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                if (x == arr[i])
                {
                    count++;
                }
            }
            return count;

        }
        public static void Frequency(int number)
        {
            int[] arr = StoreDigits(number);
            int[,] finalArr = new int[10, 2];

            for(int i= 0; i < 10; i++)
            {
                for(int j = 0; j < 2; j++)
                {
                    if (j == 0)
                    {
                        finalArr[i,j] = i;
                    }
                    else
                    {
                        finalArr[i, j] = CountFrequency(i, arr);
                    }
                }
            }

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    if (j == 0)
                    {
                        Console.Write($"The number {finalArr[i, j]} occurs ");
                    }
                    else
                    {
                        Console.WriteLine($"{finalArr[i, j]} times");
                    }
                }
            }


        }

        public static void Reverse(int[] arr)
        {
            for(int i = 0; i < arr.Length / 2; i++)
            {
                int temp = arr[i];
                arr[i] = arr[arr.Length - 1 - i];
                arr[arr.Length - 1 - i] = temp;
            }
        }

        public static void CheckArrEqual(int[] arr1, int[] arr2)
        {
            if(arr1.Length != arr2.Length)
            {
                Console.WriteLine("Not equal");
                return;
            }

            for(int i=0; i < arr1.Length; i++)
            {
                if (arr1[i] != arr2[i])
                {
                    Console.WriteLine("Not Equal");
                    return;
                }
            }
            Console.WriteLine("Both the arrays are equal");
        }

        public static void Palindrome(int[] arr)
        {
            for(int i = 0; i < arr.Length / 2; i++)
            {
                if (arr[i] != arr[arr.Length - 1 - i])
                {
                    Console.WriteLine("Not Palindrome");
                    return;
                }

            }
            Console.WriteLine("Palindrome");
        }

        public static void DuckNumberArray(int[] arr)
        {
            for(int i=0;i< arr.Length; i++)
            {
                if (arr[i]== 0)
                {
                    Console.WriteLine("DuckNumber");
                    return;
                }
            }
            Console.WriteLine("Not a Duck Number");
        }

        public static void PrimeNumber(int number)
        {
            if (number <= 1)
            {
                Console.WriteLine("Not a valid number to check for prime");
                return;
            }
            for(int i = 2; i < number / 2; i++)
            {
                if(number % i == 0)
                {
                    Console.WriteLine("Not a prime number");
                    return;
                }
            }
            Console.WriteLine("Prime number");
        }

        public static void NeonNumber(int number)
        {
            int sum = SumDigits(number);
            int square = number*number;

            if(sum == square)
            {

                Console.WriteLine("neon number");
                return;
            }
            Console.WriteLine("Not a neon number");
        }

        public static int ProductDigit(int number)
        {
            int product = 1;

            while(number > 0)
            {
                product *= number % 10;
                number /= 10;
            }
            return product;
        }

        public static void SpyNumber(int number)
        {
            int sum = SumDigits(number);
            int product = ProductDigit(number);

            if (sum == product)
            {
                Console.WriteLine("Spy number");
                return;
            }
            Console.WriteLine("Not a Spy Number");

        }

        public static void AutomorphicNumber(int number)
        {
            int square = Convert.ToInt32(Math.Pow(number, 2));

            int[] squareArr = StoreDigits(square);
            int[] numberArr = StoreDigits(number);

            int idx = squareArr.Length - 1;

            for(int i = numberArr.Length - 1; i >= 0; i--)
            {
                if(numberArr[i] != squareArr[idx])
                {
                    Console.WriteLine("Not a automorphic number");
                    return;
                }
                idx--;
            }
            Console.WriteLine("automorphic number");
        }

        public static void BuzzNumber(int number)
        {
            if(number%7==0 || number % 10 == 7)
            {
                Console.WriteLine("Buzz number");
                return;
            }
            Console.WriteLine("Not a Buzz number");

        }

        public static int[] FindFactors(int num)
        {
            int temp = 0;
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    temp++;
                }

            }
            int[] arr = new int[temp];
            int count = 0;
            //checking the factors and intilizing into the factors array
            for (int i = 1; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    arr[count] = i;
                    count++;
                }
            }
            return arr;
        }

        public static void GreatestFactor(int num)
        {
            int[] factors = FindFactors(num);
            int greatest = factors[0];
            for (int i = 1; i < factors.Length; i++) 
            {
                if (factors[i] > greatest)
                {
                    greatest = factors[i];
                }
            }
            Console.WriteLine($"Greatest factors is {greatest}");
        }

        public static int FactorsSum(int[] arr)
        {
            int sum = 0;
            for(int i=0; i<arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }

        public static int FactorsProduct(int[] arr)
        {
            int product = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                product *= arr[i];
            }
            return product;
        }

        public static double FactorsCubeProduct(int[] arr)
        {
            double product = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                product *= Math.Pow(arr[i], 3);
            }
            return product;
        }

        public static void PerfectNumber(int number)
        {
            int[] factors = FindFactors(number);
            int sum = 0;
            for (int i = 0; i < factors.Length; i++)
            {
                sum += factors[i];
            }

            if (sum == number)
            {
                Console.WriteLine("Perfect Number");
                return;
            }
            Console.WriteLine("Not a Perfect Number");
        }

        public static void AbundantNumber(int number)
        {
            int[] factors = FindFactors(number);
            int sum = 0;

            for (int i = 0; i < factors.Length; i++)
            {
                sum += factors[i];
            }

            if (sum > number)
            {
                Console.WriteLine("Abundant Number");
                return;
            }
            Console.WriteLine("Not an Abundant Number");
        }

        public static void DeficientNumber(int number)
        {
            int[] factors = FindFactors(number);
            int sum = 0;

            for (int i = 0; i < factors.Length; i++)
            {
                sum += factors[i];
            }

            if (sum < number)
            {
                Console.WriteLine("Deficient Number");
                return;
            }
            Console.WriteLine("Not a Deficient Number");
        }

        public static void StrongNumber(int number)
        {
            int temp = number;
            int sum = 0;

            while (temp > 0)
            {
                int digit = temp % 10;
                int fact = 1;

                for (int i = 1; i <= digit; i++)
                {
                    fact *= i;
                }

                sum += fact;
                temp /= 10;
            }

            if (sum == number)
            {
                Console.WriteLine("Strong Number");
                return;
            }
            Console.WriteLine("Not a Strong Number");
        }

        public static void main()
        {
            //taking input from the user
            int number = Convert.ToInt32(Console.ReadLine());

            //calling methods one by one
            // count digits
            int count = CountDigits(number);
            Console.WriteLine($"Count of the number is {count}");

            // storing in digits arr
            int[] arr = StoreDigits(number);
            Console.WriteLine("Printing the array in which digits are stored");
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(arr[i]);
            }

            DuckNumber(number);
            ArmstrongNumber(number);
            SecondLargest(number);
            SecondSmallest(number);
            SumDigits(number);
            SumSquareDigits(number);
            HarshadNumber(number);
            Frequency(number);
            Reverse(arr);

            //Printing the array again to check it gets reversed or not
            for(int i = 0; i < count; i++)
            {
                Console.WriteLine(arr[i]);
            }

            //Checking for two arrays are equal or not
            int[] tempArr = { 1, 2, 3, 4 };
            int[] tempArr1 = { 1, 2, 3, 5 };
            CheckArrEqual(tempArr, tempArr1);


            Palindrome(arr);

            DuckNumberArray(arr);

            PrimeNumber(number);

            SpyNumber(number);

            AutomorphicNumber(number);

            BuzzNumber(number);

            int[] factorsArr = FindFactors(number);

            GreatestFactor(number);

            

        }
    }
}
