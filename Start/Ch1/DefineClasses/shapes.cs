// Example file for Advanced C#: Object Oriented Programming by Joe Marini
// Defining and instantiating classes

class Rectangle
{
    public Rectangle(float h, float w)
    {
        height = h;
        width = w;
    }

    public Rectangle(int side)
    {
        width = height = side;
    }

    public float GetArea()
    {
        return width * height;
    }

    public float height;
    public float width;
}
// TODO: Define a class using the "class" keyword

    // TODO: The constructor accepts parameters used to create the object


    // TODO: For convenience, we can have a constructor that takes one value
    // for squares that have the same side size


    // TODO: Classes can define methods that return values


    // TODO: member variables hold data
