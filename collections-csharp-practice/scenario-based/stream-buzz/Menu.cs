using System;
using System.Collections.Generic;

public class Menu
{
    public void RegisterCreator(CreatorStats record)
    {
        CreatorStats.EngagementBoard.Add(record);
    }

    public Dictionary<string, int> GetTopPostCounts(List<CreatorStats> records, double likeThreshold)
    {
        Dictionary<string, int> result = new Dictionary<string, int>();

        foreach (CreatorStats creator in records)
        {
            int count = 0;

            foreach (double likes in creator.WeeklyLikes)
            {
                if (likes >= likeThreshold)
                {
                    count++;
                }
            }

            if (count > 0)
            {
                result.Add(creator.CreatorName, count);
            }
        }

        return result;
    }

    public double CalculateAverageLikes()
    {
        double total = 0;
        int count = 0;

        foreach (CreatorStats creator in CreatorStats.EngagementBoard)
        {
            foreach (double likes in creator.WeeklyLikes)
            {
                total += likes;
                count++;
            }
        }

        return count == 0 ? 0 : total / count;
    }

    public void DisplayMenu()
    {
        bool running = true;

        while (running)
        {
            Console.WriteLine("1. Register Creator");
            Console.WriteLine("2. Show Top Posts");
            Console.WriteLine("3. Calculate Average Likes");
            Console.WriteLine("4. Exit");
            Console.WriteLine("\nEnter your choice:");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    CreatorStats creator = new CreatorStats();

                    Console.WriteLine("Enter Creator Name:");
                    creator.CreatorName = Console.ReadLine();

                    creator.WeeklyLikes = new double[4];
                    Console.WriteLine("Enter weekly likes (Week 1 to 4):");

                    for (int i = 0; i < 4; i++)
                    {
                        creator.WeeklyLikes[i] = double.Parse(Console.ReadLine());
                    }

                    RegisterCreator(creator);
                    Console.WriteLine("Creator registered successfully\n");
                    break;

                case 2:
                    Console.WriteLine("Enter like threshold:");
                    double threshold = double.Parse(Console.ReadLine());

                    var result = GetTopPostCounts(CreatorStats.EngagementBoard, threshold);

                    if (result.Count == 0)
                    {
                        Console.WriteLine("No top-performing posts this week\n");
                    }
                    else
                    {
                        foreach (var item in result)
                        {
                            Console.WriteLine(item.Key + " - " + item.Value);
                        }
                        Console.WriteLine();
                    }
                    break;

                case 3:
                    Console.WriteLine(
                        "Overall average weekly likes: " + CalculateAverageLikes() + "\n");
                    break;

                case 4:
                    Console.WriteLine("Logging off - Keep Creating with StreamBuzz!");
                    running = false;
                    break;
            }
        }
    }
}
