using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Scenario_oops.CustomFurnitureMnufacturing
{
    internal class Furniture
    {
        public int[] Length { get; private set; }
        public int[] Price { get; private set; }

        public Furniture()
        {
            this.Length = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            this.Price = new int[] { 2, 5, 7, 8, 10, 13, 17, 18, 20, 22, 24, 25 };
        }

        public int[] getLength()
        {
            return this.Length; 
        }

        public int[] getPrice()
        {
            return this.Price;
        }
        
    }
}
