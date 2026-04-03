using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.dsa_csharp_linked_list
{
    public class TextState
    {
        public string Content;
        public TextState Prev;
        public TextState Next;

        public TextState(string content)
        {
            Content = content;
            Prev = null;
            Next = null;
        }
    }



    public class TextEditor
    {
        private TextState head = null;
        private TextState tail = null;
        private TextState current = null;
        private int historySize = 0;
        private const int MaxHistory = 10;

        public void Type(string text)
        {
            // When typing new text, any "redo" history beyond current state is cleared
            TextState newState = new TextState(text);

            if (head == null)
            {
                head = tail = current = newState;
                historySize = 1;
            }
            else
            {
                // Clear redo path
                current.Next = newState;
                newState.Prev = current;
                current = newState;
                tail = current;

                // Recalculate size after clearing redo path
                int count = 0;
                TextState temp = head;
                while (temp != null) { count++; temp = temp.Next; }
                historySize = count;

                // Enforce size limit
                if (historySize > MaxHistory)
                {
                    head = head.Next;
                    head.Prev = null;
                    historySize--;
                }
            }
            Console.WriteLine($"Typed: {text}");
        }

        public void Undo()
        {
            if (current != null && current.Prev != null)
            {
                current = current.Prev;
                Console.WriteLine("Action: Undo");
            }
            else
            {
                Console.WriteLine("Nothing to undo.");
            }
        }

        public void Redo()
        {
            if (current != null && current.Next != null)
            {
                current = current.Next;
                Console.WriteLine("Action: Redo");
            }
            else
            {
                Console.WriteLine("Nothing to redo.");
            }
        }

        public void Display()
        {
            if (current != null)
            {
                Console.WriteLine($"Current Screen: {current.Content}");
            }
            else
            {
                Console.WriteLine("Screen is empty.");
            }
        }

        public static void Main()
        {
            TextEditor editor = new TextEditor();

            editor.Type("Hello");
            editor.Type("Hello World");
            editor.Type("Hello World!");
            editor.Display();

            editor.Undo();
            editor.Display();

            editor.Undo();
            editor.Display();

            editor.Redo();
            editor.Display();

            editor.Type("Hello C#"); // This clears the previous redo "Hello World!"
            editor.Redo(); // Should show nothing to redo
            editor.Display();
        }
    }
}
