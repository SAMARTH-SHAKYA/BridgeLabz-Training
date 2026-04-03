using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.dsa_csharp_linked_list
{
    public class StudentManagementSystem
    {
        public int RollNumber;
        public string Name;
        public int Age;
        public char Grade;
        public StudentManagementSystem Next;

        public StudentManagementSystem(int roll, string name, int age, char grade)
        {
            RollNumber = roll;
            Name = name;
            Age = age;
            Grade = grade;
            Next = null;
        }
    }



    public class StudentManagementSystem
    {
        private StudentManagementSystem head;

        public void Add(int roll, string name, int age, char grade, int position)
        {
            StudentManagementSystem newNode = new StudentManagementSystem(roll, name, age, grade);

            if (position == 0 || head == null)
            {
                newNode.Next = head;
                head = newNode;
                return;
            }

            StudentManagementSystem current = head;
            for (int i = 0; current.Next != null && i < position - 1; i++)
            {
                current = current.Next;
            }

            newNode.Next = current.Next;
            current.Next = newNode;
        }

        public void Delete(int roll)
        {
            if (head == null) return;

            if (head.RollNumber == roll)
            {
                head = head.Next;
                return;
            }

            StudentManagementSystem current = head;
            while (current.Next != null && current.Next.RollNumber != roll)
            {
                current = current.Next;
            }

            if (current.Next != null)
            {
                current.Next = current.Next.Next;
            }
        }

        public void Search(int roll)
        {
            StudentManagementSystem current = head;
            while (current != null)
            {
                if (current.RollNumber == roll)
                {
                    Console.WriteLine($"Found: {current.Name}, Age: {current.Age}, Grade: {current.Grade}");
                    return;
                }
                current = current.Next;
            }
            Console.WriteLine("Student not found.");
        }

        public void UpdateGrade(int roll, char newGrade)
        {
            StudentManagementSystem current = head;
            while (current != null)
            {
                if (current.RollNumber == roll)
                {
                    current.Grade = newGrade;
                    Console.WriteLine("Grade updated successfully.");
                    return;
                }
                current = current.Next;
            }
            Console.WriteLine("Student not found.");
        }

        public void Display()
        {
            StudentManagementSystem current = head;
            if (current == null) Console.WriteLine("List is empty.");
            while (current != null)
            {
                Console.WriteLine($"Roll: {current.RollNumber}, Name: {current.Name}, Age: {current.Age}, Grade: {current.Grade}");
                current = current.Next;
            }
        }

        public static void Main()
        {
            StudentManagementSystem sms = new StudentManagementSystem();
            sms.Add(101, "Alice", 20, 'A', 0);
            sms.Add(102, "Bob", 21, 'B', 1);
            sms.Add(103, "Charlie", 22, 'C', 1);

            
            sms.Display();
            sms.Search(102);


            sms.UpdateGrade(101, 'S');

            sms.Delete(103);

            sms.Display();
        }
    }
}
