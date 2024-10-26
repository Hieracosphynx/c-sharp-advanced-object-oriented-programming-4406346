// Example file for Advanced C#: Object Oriented Programming by Joe Marini
// Using inheritance to define a class hierarchy

// Instantiate some objects
Circle c = new(10);
Rectangle r = new(10,20);
Square sq = new(5);

// TODO: Exercise the ToString() method
//Console.WriteLine($"{c}");
//Console.WriteLine($"{r}");

// TODO: Use the "is" operator to test an object type
//Console.WriteLine($"{c is Shape2D}");
//Console.WriteLine($"{c is Rectangle}");

// TODO: Call the GetArea() function on each one
Console.WriteLine(c.GetArea());
Console.WriteLine(r.GetArea());
Console.WriteLine(sq.GetArea());

// TODO: Print the area of each shape
void PrintArea(Shape2D shape)
{
    Console.WriteLine($"{shape.GetArea()}");
}

// TODO: All of the classes derive from Shape2D, so we can treat each one
// as an instance of the base class. 
PrintArea(c);
PrintArea(r);
PrintArea(sq);