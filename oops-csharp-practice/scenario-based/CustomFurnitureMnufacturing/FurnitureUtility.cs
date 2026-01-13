using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Scenario_oops.CustomFurnitureMnufacturing
{
    internal class FurnitureUtility : IFurniture
    {
        private Furniture furniture=new Furniture();
        

        public int MaxProfit(int n)
        {
            int[] length = furniture.getLength();
            int[] price = furniture.getPrice();

            int[] dp = new int[n + 1];


            //using dynamic programming for calcuating best prices
            dp[0] = 0;

            for (int i = 1; i <= n; i++)
            {
                int max = int.MinValue;

                for (int j = 0; j < length.Length; j++)
                {
                    if (length[j] <= i)
                    {
                        max = Math.Max(max, price[j] + dp[i - length[j]]);
                    }
                }

                dp[i] = max;
            }

            return dp[n];
        }


       
        public  int MaxProfitWithWaste(int n, int wasteAllowed)
        {

           
            int[] length = furniture.getLength();
            int[] price = furniture.getPrice();
            int[] dp = new int[n + 1];

            for (int i = 1; i <= n; i++)
            {
                int max = 0;

                for (int j = 0; j < length.Length; j++)
                {
                    if (length[j] <= i)
                    {
                        max = Math.Max(max, price[j] + dp[i - length[j]]);
                    }
                }

                dp[i] = max;
            }

            int bestProfit = 0;

            for (int used = n - wasteAllowed; used <= n; used++)
            {
                bestProfit = Math.Max(bestProfit, dp[used]);
            }

            return bestProfit;
        }
    }
}
