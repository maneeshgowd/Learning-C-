// Indexer is a special kind of property that allows accessing elements
// of a list by an index.


public class HttpCookie
{
    private readonly Dictionary<string, string> _dictionary;

    public HttpCookie()
    {
        _dictionary = new Dictionary<string, string>();
    }

    public string this[string key]
    {
        get
        {
            return _dictionary[key];
        }

        set
        {
            _dictionary[key] = value;
        }
    }

    static void Main(string[] args)
    {
        HttpCookie cookie = new HttpCookie();
        cookie["name"] = "maneesh";
        Console.WriteLine(cookie["name"]);
    }
}

