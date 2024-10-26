// Example file for Advanced C#: Object Oriented Programming by Joe Marini
// Using object and collection initializers

// TODO: Use the initializer syntax to create new objects
Dog dog = new() { Name="Fido", Age=4, IsTrained=true };
Cat cat = new() { Name="Bingo", Age=10, IsDeclawed=false };
//Console.WriteLine($"{dog.Name}");
//Console.WriteLine($"{cat.Name}");

// TODO: Initializers can be used on anonymous types


// TODO: Collections can also be initialized this way
int[] nums = new int[] { 1, 2, 3, 4, 5, 6 };
//Console.WriteLine($"{nums.Length}");

// TODO: Initialize a collection with a set of objects
PetOwner owner = new() {
    Name="Migs",
    Pets = new List<Pet> {
        new Dog { Name="Kenzo", Age=2 },
        new Dog { Name="Nugget", Age=1 },
        new Cat { Name="No Cat", Age=0 }
    }
};

Console.WriteLine($"{owner.Name}'s Pets:");

foreach(Pet p in owner.Pets)
{
    Console.WriteLine($"{p.Name}");
}