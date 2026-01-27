using System;

public class VehicleQueue
{
    private string[] queue;
    private int front, rear, size, capacity;

    public VehicleQueue(int cap)
    {
        capacity = cap;
        queue = new string[cap];
        front = 0;
        rear = -1;
        size = 0;
    }

    public bool IsFull() => size == capacity;
    public bool IsEmpty() => size == 0;

    public void Enqueue(string vehicle)
    {
        if (IsFull())
        {
            Console.WriteLine("Queue Overflow!");
            return;
        }

        rear = (rear + 1) % capacity;
        queue[rear] = vehicle;
        size++;
        Console.WriteLine($"{vehicle} added to queue.");
    }

    public string Dequeue()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Queue Underflow!");
            return null;
        }

        string vehicle = queue[front];
        front = (front + 1) % capacity;
        size--;
        return vehicle;
    }

    public void DisplayQueue()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Queue is empty.");
            return;
        }

        Console.Write("Waiting Queue: ");
        int i = front;
        for (int count = 0; count < size; count++)
        {
            Console.Write(queue[i] + " ");
            i = (i + 1) % capacity;
        }
        Console.WriteLine();
    }
}
