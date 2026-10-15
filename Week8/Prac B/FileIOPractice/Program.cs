using System;
using System.IO;

string path = @"./MyTest.txt";
using (StreamWriter sw = File.CreateText(path))
{
    sw.WriteLine("Hello, World!");
    sw.WriteLine("This is a test file.");
}
Console.WriteLine("File created and text written successfully.");


//Read the file
using (StreamReader sr = File.OpenText(path))
{
    string s;
    while ((s = sr.ReadLine()) != null)
    {
        Console.WriteLine(s);
    }
}