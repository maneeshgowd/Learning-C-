// Directory and DirectoryInfo classes for working with directories

static void Main(string[] args)
{

    // Creates a directory but slower than DirectoryInfo
    Directory.CreateDirectory(@"c:\temp\temp2");

    var directories = Directory.GetDirectories(@"c:\users");
    //foreach(var d in directories)
    //{
    //    Console.WriteLine(d);
    //}

    var files = Directory.GetFiles(@"c:\users\mgowd");

    //foreach(var file in files ) {
    //    Console.WriteLine(file);
    //}


    // similar to FileInfo, faster the Directory
    var directoryInfo = new DirectoryInfo("@c:\temp\temp2");
    directoryInfo.GetFiles();
    directoryInfo.GetDirectories();
}