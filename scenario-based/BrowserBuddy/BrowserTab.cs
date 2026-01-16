using System;

public class BrowserTab
{
    private HistoryNode current;

    public BrowserTab(string homepage)
    {
        current = new HistoryNode(homepage);
    }

    public void Visit(string url)
    {
        HistoryNode newNode = new HistoryNode(url);
        current.Next = newNode;
        newNode.Prev = current;
        current = newNode;
    }

    public void Back()
    {
        if (current.Prev != null)
        {
            current = current.Prev;
        }
        else
        {
            Console.WriteLine("No previous page.");
        }
    }

    public void Forward()
    {
        if (current.Next != null)
        {
            current = current.Next;
        }
        else
        {
            Console.WriteLine("No next page.");
        }
    }

    public string GetCurrentPage()
    {
        return current.Url;
    }
}
