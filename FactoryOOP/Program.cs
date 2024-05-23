namespace FactoryOOP;

public interface Shape
{
    void Draw();
}

public class Circle : Shape
{
    public void Draw()
    {
        Console.WriteLine("Drawing circles!");
    }
}

public class Square : Shape
{
    public void Draw()
    {
        Console.WriteLine("Drawing squares!");
    }
}

public class ShapeFactory
{
    public Shape GetShape(string shapeType)
    {
        if (string.IsNullOrWhiteSpace(shapeType))
        {
            return null;
        }

        shapeType = shapeType.ToLower();

        switch(shapeType)
        {
            case "circle":
                return new Circle();
            case "square":
                return new Square();
            default:
                return null;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        ShapeFactory shapeFactory = new ShapeFactory();

        Shape circle = shapeFactory.GetShape("circle");
        circle.Draw();

        Shape square = shapeFactory.GetShape("square");
        square.Draw();
    }
}
