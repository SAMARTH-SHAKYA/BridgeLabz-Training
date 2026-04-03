using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Methods.level3
{
    internal class SixDigitOTP
    {
        public static int GenerateOtp()
        {
            Random rand = new Random();
            return rand.Next(100000,1000000);
        }

        public static int[] GenerateOtpArray()
        {
            int[] otpArray = new int[10];
            for (int i = 0; i < 10; i++)
            {
                otpArray[i] = GenerateOtp();
            }
            return otpArray;
        }

        public static void CheckOtpArray(int[] otpArray)
        {
            for (int i = 0; i < 9; i++)
            {
                for(int j = i + 1; j < 10; j++)
                {
                    if (otpArray[i] == otpArray[j])
                    {
                        Console.WriteLine("Not Unique");
                        return;
                    }
                }
            }

            Console.WriteLine("Unique");
        }

        public static void main()
        {
            int[] otpArray = GenerateOtpArray();

            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(otpArray[i]);
            }

            CheckOtpArray(otpArray);

        }
    }
}
