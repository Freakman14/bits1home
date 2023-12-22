double a = Convert.ToDouble(Console.ReadLine());

var cir1 = new Circle();
cir1.Radius = a;
System.Console.WriteLine("Area: " + cir1.GetArea());
System.Console.WriteLine("Diameter: " + cir1.GetDiameter());
System.Console.WriteLine("Circumference: " + cir1.GetCircumference());




public class Circle
{
    private double radius;
    private double pi = 3.14;

    public double Radius
    {
        get
        {
            return radius;
        }
        set
        {
            radius = value;
        }

    }

    public double Pi
    {
        get
        {
            return pi;
        }
        set
        {
            pi = value;
        }
    }
    public Circle() { }



    public double GetArea()
    {
        double area = pi * radius * radius;
        return area;
    }

    public double GetDiameter()
    {
        double diameter = radius * 2;
        return diameter;
    }
    public double GetCircumference()
    {
        double circumference = 2 * pi * radius;
        return circumference;
    }
}
