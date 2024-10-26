// Example file for Advanced C#: Object Oriented Programming by Joe Marini
// Creating and using Anonymous types

// TODO: Anonymous types can be declared using "new" and { }, similar to JS
var myObj = new {
    Name = "Hello",
    Age = 45,
    Address = new {
        Street = "14 Somewhere St.",
        City = "Anywhere"
    }
};

//Console.WriteLine($"{myObj.Name}");
//Console.WriteLine($"{myObj.Address}");
//Console.WriteLine($"{myObj.Address.Street}");
//Console.WriteLine(myObj);

// Anonymous types are read-only and cannot be modified
//myobj.Name = "Jane Doe"; # will cause an error

// TODO: To change a value, use non-destructive mutation and "with" clause
//var myObj2 = myObj with { Name = "Jane Doe" };
//Console.WriteLine($"{myObj2.Name}");

// TODO: You can check to see if an anonymous object contains a property
Console.WriteLine($"{myObj.GetType().GetProperty("Name") != null}");
Console.WriteLine($"{myObj.GetType().GetProperty("J") != null}");
