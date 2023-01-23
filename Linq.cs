// LINQ - Language Integrated Query

// Gives the capability to query objects

internal class Program
{
    static void Main(string[] args)
    {
        List<Person> users = new List<Person>()
            {
                new Person() {FirstName = "Maneesh", LastName="Kumar", Age=22,Profession="ST"},
                new Person() {FirstName = "Rajesh", LastName="Dev", Age=21,Profession="ST"},
                new Person() {FirstName = "Ajay", LastName="Kumar", Age=20,Profession="GET"},
                new Person() {FirstName = "Bavesh", LastName="Dev", Age=25,Profession="SE2"},
                new Person() {FirstName = "Suresh", LastName="Gowd", Age=25,Profession="SE"},
                new Person() {FirstName = "Rahul", LastName="Gowd", Age=22,Profession="SE"}
            };

        // Filters the users whose lastname is kumar
        var kumar = users.Where(user => user.LastName == "Kumar");


        // Finds the first occurence with profession as SE if not found return null
        var user = users.FirstOrDefault(user => user.Profession == "SE");

        // Finds the last occurence with profession as SE if not found return null
        var userr = users.LastOrDefault(user => user.Profession == "SE");

        users.Min(u => u.Age); // user with min age
        users.Max(u => u.Age); // user with max age 


        users.Sum(); // return sum
        users.Count(); // total obj

        var d = users.Skip(2).Take(3); // Skips first 2 obj and selects next immediate 3
    }
}


// Use cases

// 1. Objects in memory, eg collections
// 2. Databases
// 3. XML