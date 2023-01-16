// File and File info class to access files


static void Main(string[] args)
{
    // Static way to access Files
    // Slower because performs security checkin for every static method call.
    var path = @"c:\temp\random.txt";

    File.Copy(@"c:\temp\random.txt", @"c:\temp\noRandom.txt", true);

    var content = File.ReadAllText(path);

    if (File.Exists(path))
    {
        File.Delete(path);
    }


    ////////////////////////////////////
    /// Faster method to access file using FileInfo instance
    /// Performs security checking only during instantiation.

    var fileInfo = new FileInfo(path);

    fileInfo.CopyTo(@"c:\temp\noRandom.txt", true);

    if (fileInfo.Exists)
    {
        fileInfo.Delete();
    }

}