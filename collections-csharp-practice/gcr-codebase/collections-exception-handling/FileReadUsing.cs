using System;
using System.IO;

class FileReadUsing
{
  static void Main()
  {
    try
    {
      using (StreamReader reader = new StreamReader("info.txt"))
      {
        string firstLine = reader.ReadLine();
        Console.WriteLine(firstLine);
      }
    }
    catch (IOException)
    {
      Console.WriteLine("Error reading file");
    }
  }
}
