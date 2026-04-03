using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.dsa_csharp_linked_list
{
    public class TaskNode
{
    public int TaskID;
    public string TaskName;
    public int Priority;
    public string DueDate;
    public TaskNode Next;

    public TaskNode(int id, string name, int priority, string dueDate)
    {
        TaskID = id;
        TaskName = name;
        Priority = priority;
        DueDate = dueDate;
        Next = null;
    }
}



public class TaskScheduler
{
    private TaskNode head = null;
    private TaskNode tail = null;
    private TaskNode currentTask = null;

    public void AddTask(int id, string name, int priority, string dueDate, int position)
    {
        TaskNode newNode = new TaskNode(id, name, priority, dueDate);

        if (head == null)
        {
            head = newNode;
            tail = newNode;
            newNode.Next = head;
            currentTask = head;
            return;
        }

        if (position <= 0) // Add at beginning
        {
            newNode.Next = head;
            tail.Next = newNode;
            head = newNode;
            return;
        }

        TaskNode current = head;
        int index = 0;
        // Traverse to find position or stop at tail
        while (index < position - 1 && current.Next != head)
        {
            current = current.Next;
            index++;
        }

        newNode.Next = current.Next;
        current.Next = newNode;

        if (current == tail)
        {
            tail = newNode;
        }
    }

    public void RemoveTask(int id)
    {
        if (head == null) return;

        TaskNode current = head;
        TaskNode prev = tail;

        do
        {
            if (current.TaskID == id)
            {
                if (current == head && current == tail)
                {
                    head = tail = currentTask = null;
                }
                else
                {
                    prev.Next = current.Next;
                    if (current == head) head = prev.Next;
                    if (current == tail) tail = prev;
                    if (current == currentTask) currentTask = prev.Next;
                }
                return;
            }
            prev = current;
            current = current.Next;
        } while (current != head);
    }

    public void ViewAndNext()
    {
        if (currentTask == null)
        {
            Console.WriteLine("No tasks in schedule.");
            return;
        }
        Console.WriteLine($"Current Task: [{currentTask.TaskID}] {currentTask.TaskName} | Priority: {currentTask.Priority}");
        currentTask = currentTask.Next;
    }

    public void DisplayAll()
    {
        if (head == null) return;

        TaskNode temp = head;
        do
        {
            Console.WriteLine($"ID: {temp.TaskID}, Name: {temp.TaskName}, Priority: {temp.Priority}, Due: {temp.DueDate}");
            temp = temp.Next;
        } while (temp != head);
    }

    public void SearchByPriority(int priority)
    {
        if (head == null) return;

        TaskNode temp = head;
        bool found = false;
        do
        {
            if (temp.Priority == priority)
            {
                Console.WriteLine($"Found: {temp.TaskName} (ID: {temp.TaskID})");
                found = true;
            }
            temp = temp.Next;
        } while (temp != head);

        if (!found) Console.WriteLine($"No tasks found with priority {priority}");
    }

    public static void Main()
    {
        TaskScheduler scheduler = new TaskScheduler();
        scheduler.AddTask(1, "Fix Bug", 1, "2026-01-10", 0);
        scheduler.AddTask(2, "Refactor", 2, "2026-01-15", 1);
        scheduler.AddTask(3, "Update Docs", 3, "2026-01-20", 2);

        Console.WriteLine("All Tasks:");
        scheduler.DisplayAll();

       
        scheduler.ViewAndNext();
        scheduler.ViewAndNext();

        
        scheduler.SearchByPriority(2);

       
        scheduler.RemoveTask(1);
        scheduler.DisplayAll();
    }
}
}
