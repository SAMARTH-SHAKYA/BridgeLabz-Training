using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Methods.level1
{
    internal class SimpleHandShakes
    {
        public void SimpleHand()

        {
            //taking inoput from the user
            int numberOfStudents = Convert.ToInt32(Console.ReadLine());
            //calcluating number of handshakes
            int answer = (numberOfStudents * (numberOfStudents - 1)) / 2;
            //printing the answer
            Console.WriteLine($"Handshakes of {numberOfStudents} is {answer}");
        }
    }
}
