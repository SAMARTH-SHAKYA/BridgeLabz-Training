using System;

class Program
{
    static void Main(string[] args)
    {
        BrowserManager manager = new BrowserManager();
        manager.OpenNewTab("google.com");

        BrowserTab tab = manager.GetTab(0);
        tab.Visit("youtube.com");
        tab.Visit("github.com");

        Console.WriteLine("Current Page: " + tab.GetCurrentPage());

        tab.Back();
        Console.WriteLine("After Back: " + tab.GetCurrentPage());

        tab.Forward();
        Console.WriteLine("After Forward: " + tab.GetCurrentPage());

        manager.CloseTab(0);
        manager.RestoreClosedTab();

        Console.WriteLine("Tab restored successfully!");
    }
}
