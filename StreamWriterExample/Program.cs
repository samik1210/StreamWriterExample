using System;
using System.IO;

namespace StreamWriterExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            FileStream f = new FileStream("c:\\output.txt", FileMode.Create);
            StreamWriter s = new StreamWriter(f);

            s.WriteLine("hello c#");
            s.Close();
            f.Close();
            Console.WriteLine("File created successfully...");
        }
    }
}
