using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.dsa_csharp_linked_list
{
    public class FriendNode
    {
        public int FriendID;
        public FriendNode Next;

        public FriendNode(int id)
        {
            FriendID = id;
            Next = null;
        }
    }

    public class User
    {
        public int UserID;
        public string Name;
        public int Age;
        public FriendNode FriendsList; // Singly linked list of Friend IDs
        public User Next;

        public User(int id, string name, int age)
        {
            UserID = id;
            Name = name;
            Age = age;
            FriendsList = null;
            Next = null;
        }
    }



    public class SocialMediaManager
    {
        private User head = null;

        public void AddUser(int id, string name, int age)
        {
            User newUser = new User(id, name, age);
            newUser.Next = head;
            head = newUser;
        }

        private User FindUser(int id)
        {
            User current = head;
            while (current != null)
            {
                if (current.UserID == id) return current;
                current = current.Next;
            }
            return null;
        }

        public void AddFriendConnection(int id1, int id2)
        {
            User u1 = FindUser(id1);
            User u2 = FindUser(id2);

            if (u1 != null && u2 != null)
            {
                u1.FriendsList = AddFriendID(u1.FriendsList, id2);
                u2.FriendsList = AddFriendID(u2.FriendsList, id1);
            }
        }

        private FriendNode AddFriendID(FriendNode list, int id)
        {
            FriendNode current = list;
            while (current != null)
            {
                if (current.FriendID == id) return list;
                current = current.Next;
            }
            return new FriendNode(id) { Next = list };
        }

        public void RemoveFriendConnection(int id1, int id2)
        {
            User u1 = FindUser(id1);
            User u2 = FindUser(id2);

            if (u1 != null && u2 != null)
            {
                u1.FriendsList = RemoveFriendID(u1.FriendsList, id2);
                u2.FriendsList = RemoveFriendID(u2.FriendsList, id1);
            }
        }

        private FriendNode RemoveFriendID(FriendNode list, int id)
        {
            if (list == null) return null;
            if (list.FriendID == id) return list.Next;

            FriendNode current = list;
            while (current.Next != null)
            {
                if (current.Next.FriendID == id)
                {
                    current.Next = current.Next.Next;
                    return list;
                }
                current = current.Next;
            }
            return list;
        }

        public void FindMutualFriends(int id1, int id2)
        {
            User u1 = FindUser(id1);
            User u2 = FindUser(id2);
            if (u1 == null || u2 == null) return;

            Console.Write($"Mutual Friends of {u1.Name} and {u2.Name}: ");
            FriendNode f1 = u1.FriendsList;
            while (f1 != null)
            {
                FriendNode f2 = u2.FriendsList;
                while (f2 != null)
                {
                    if (f1.FriendID == f2.FriendID)
                    {
                        User mutual = FindUser(f1.FriendID);
                        Console.Write($"{mutual.Name} ");
                    }
                    f2 = f2.Next;
                }
                f1 = f1.Next;
            }
            Console.WriteLine();
        }

        public void DisplayUserFriends(int id)
        {
            User u = FindUser(id);
            if (u == null) return;

            Console.Write($"{u.Name}'s Friends: ");
            FriendNode current = u.FriendsList;
            while (current != null)
            {
                User f = FindUser(current.FriendID);
                Console.Write($"{f.Name} ");
                current = current.Next;
            }
            Console.WriteLine();
        }

        public void SearchUser(string name = null, int? id = null)
        {
            User current = head;
            while (current != null)
            {
                if ((id.HasValue && current.UserID == id.Value) ||
                    (name != null && current.Name.Equals(name, StringComparison.OrdinalIgnoreCase)))
                {
                    Console.WriteLine($"Found: {current.Name} (ID: {current.UserID}), Age: {current.Age}");
                    return;
                }
                current = current.Next;
            }
            Console.WriteLine("User not found.");
        }

        public void DisplayFriendCounts()
        {
            User current = head;
            while (current != null)
            {
                int count = 0;
                FriendNode f = current.FriendsList;
                while (f != null) { count++; f = f.Next; }
                Console.WriteLine($"{current.Name}: {count} friends");
                current = current.Next;
            }
        }

        public static void Main()
        {
            SocialMediaManager sm = new SocialMediaManager();
            sm.AddUser(1, "Alice", 20);
            sm.AddUser(2, "Bob", 22);
            sm.AddUser(3, "Charlie", 21);
            sm.AddUser(4, "David", 23);

            sm.AddFriendConnection(1, 2);
            sm.AddFriendConnection(1, 3);
            sm.AddFriendConnection(4, 2);
            sm.AddFriendConnection(4, 3);

            sm.DisplayUserFriends(1);
            sm.FindMutualFriends(1, 4);
            sm.DisplayFriendCounts();
        }
    }
}
