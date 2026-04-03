using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.dsa_csharp_linked_list
{
    public class Process
    {
        public int PID;
        public int BurstTime;
        public int RemainingTime;
        public int Priority;
        public int FinishTime;
        public Process Next;

        public Process(int id, int bt, int p)
        {
            PID = id;
            BurstTime = bt;
            RemainingTime = bt;
            Priority = p;
        }
    }



    public class RoundRobinScheduler
    {
        private Process head = null;
        private Process tail = null;
        private int totalCount = 0;

        public void AddProcess(int id, int bt, int p)
        {
            Process newNode = new Process(id, bt, p);
            if (head == null)
            {
                head = newNode;
                tail = newNode;
                newNode.Next = head;
            }
            else
            {
                tail.Next = newNode;
                tail = newNode;
                tail.Next = head;
            }
            totalCount++;
        }

        public void Simulate(int quantum)
        {
            if (head == null) return;

            int currentTime = 0;
            int completedCount = 0;
            double totalWaitTime = 0;
            double totalTurnAroundTime = 0;

            // Arrays to store initial burst times and finish times for calculations without using List<T>
            int[] originalBursts = new int[totalCount + 1];
            int[] pids = new int[totalCount + 1];

            Process temp = head;
            for (int i = 0; i < totalCount; i++)
            {
                pids[i] = temp.PID;
                originalBursts[i] = temp.BurstTime;
                temp = temp.Next;
            }

            Process current = head;
            Process prev = tail;

            Console.WriteLine("Execution Start:");

            while (completedCount < totalCount)
            {
                int executeTime = (current.RemainingTime > quantum) ? quantum : current.RemainingTime;
                current.RemainingTime -= executeTime;
                currentTime += executeTime;

                if (current.RemainingTime == 0)
                {
                    current.FinishTime = currentTime;
                    int tat = current.FinishTime;
                    int wt = tat - current.BurstTime;

                    totalTurnAroundTime += tat;
                    totalWaitTime += wt;
                    completedCount++;

                    Console.WriteLine($"[Time {currentTime}] Process {current.PID} Finished. TAT: {tat}, WT: {wt}");

                    if (current == head && current == tail)
                    {
                        head = tail = null;
                    }
                    else
                    {
                        prev.Next = current.Next;
                        if (current == head) head = current.Next;
                        if (current == tail) tail = prev;
                        current = prev.Next;
                    }
                }
                else
                {
                    prev = current;
                    current = current.Next;
                }

                if (head != null) DisplayQueue();
            }

            Console.WriteLine($"Average Turnaround Time: {totalTurnAroundTime / totalCount:F2}");
            Console.WriteLine($"Average Waiting Time: {totalWaitTime / totalCount:F2}");
        }

        public void DisplayQueue()
        {
            if (head == null) return;
            Process temp = head;
            Console.Write("Queue State: ");
            do
            {
                Console.Write($"P{temp.PID}({temp.RemainingTime}) ");
                temp = temp.Next;
            } while (temp != head);
            Console.WriteLine();
        }

        public static void Main()
        {
            RoundRobinScheduler scheduler = new RoundRobinScheduler();
            scheduler.AddProcess(1, 10, 1);
            scheduler.AddProcess(2, 5, 2);
            scheduler.AddProcess(3, 8, 1);

            scheduler.Simulate(4);
        }
    }
}