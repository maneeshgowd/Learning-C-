static void Main(string[] args)
{
    // path to work with file paths without performing string opertions
    var path = @"c:\temp\users\temp2\random.txt";

    Console.WriteLine("Extension: " + Path.GetExtension(path));
    Console.WriteLine("File Name: " + Path.GetFileName(path));
    Console.WriteLine("File Name Without Extension: " + Path.GetFileNameWithoutExtension(path));
    Console.WriteLine("Directory Name: " + Path.GetDirectoryName(path));
}