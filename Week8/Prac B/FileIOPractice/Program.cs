using System;
using System.IO;

string path = @"./MyTest.txt";
using (StreamWriter sw = File.CreateText(path))
{
    sw.WriteLine("Hello, World!");
    sw.WriteLine("The old content should be replaced.");
}
Console.WriteLine("File created and text written successfully.");


//Read the file
string content = File.ReadAllText(path);
Console.WriteLine(content);