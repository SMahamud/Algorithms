using JUST;
using System;
using System.IO;

namespace Transformations
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = File.ReadAllText(@"C:\Users\shaik.mahamud\Desktop\pvav-929\provider.json");
            Console.WriteLine(input);
            string transformer = File.ReadAllText(@"C:\Users\shaik.mahamud\Desktop\pvav-929\transormerprovider.json"); ;

            string transformedString = JsonTransformer.Transform(transformer, input);
            Console.WriteLine(transformedString);
            Console.WriteLine("Hello World!");
        }
    }
}
