using System;
using System.Collections.Generic;

public class BrowserManager
{
    private List<BrowserTab> openTabs = new List<BrowserTab>();
    private Stack<BrowserTab> closedTabs = new Stack<BrowserTab>();

    public void OpenNewTab(string homepage)
    {
        openTabs.Add(new BrowserTab(homepage));
        Console.WriteLine("New tab opened.");
    }

    public void CloseTab(int index)
    {
        if (index >= 0 && index < openTabs.Count)
        {
            closedTabs.Push(openTabs[index]);
            openTabs.RemoveAt(index);
            Console.WriteLine("Tab closed.");
        }
        else
        {
            Console.WriteLine("Invalid tab index.");
        }
    }

    public void RestoreClosedTab()
    {
        if (closedTabs.Count > 0)
        {
            openTabs.Add(closedTabs.Pop());
            Console.WriteLine("Closed tab restored.");
        }
        else
        {
            Console.WriteLine("No closed tabs to restore.");
        }
    }

    public BrowserTab GetTab(int index)
    {
        if (index >= 0 && index < openTabs.Count)
            return openTabs[index];

        return null;
    }

    public int TabCount()
    {
        return openTabs.Count;
    }
}
