using System;
using System.IO;

class FileNotFoundException
{
  static void Main()
  {
    try
    {
      string content = File.ReadAllText("data.txt");
      Console.WriteLine("File contents:");
      Console.WriteLine(content);
    }
    catch (IOException)
    {
      Console.WriteLine("File not found");
    }
  }
}
