using System;
using System.Collections.Generic;

class PatientTriage
{
    static void Main()
    {
        // Create a priority queue where higher severity patients come first
        PriorityQueue<string, int> triageQueue = new PriorityQueue<string, int>();

        // Enqueue patients (priority = negative severity to make higher severity come first)
        triageQueue.Enqueue("John", -3);
        triageQueue.Enqueue("Alice", -5);
        triageQueue.Enqueue("Bob", -2);

        Console.WriteLine("Order of treatment:");

        while (triageQueue.Count > 0)
        {
            string patient = triageQueue.Dequeue();
            Console.WriteLine(patient);
        }
    }
}
