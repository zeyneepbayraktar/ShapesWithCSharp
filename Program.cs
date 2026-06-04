using System;

abstract class Shape
{
    public abstract double getArea();
    
    public override string ToString()
    {
        return this.GetType().Name;
    }
}
abstract class TwoDimensionalShape : Shape
{
    public abstract override double getArea();
}
abstract class ThreeDimensionalShape : Shape
{
    public abstract override double getArea();
    public abstract double getVolume();
}

class Circle :  TwoDimensionalShape
{
    private double radius;
    public Circle(double radius){
        this.radius = radius;
    }
    public override double getArea()
    {
        return Math.PI*radius*radius;
    }
}

class Square : TwoDimensionalShape
{
    private double edge;
    public Square(double edge){
        this.edge = edge;
    }

    public override double getArea()
    {
        return edge*edge;
    }
}
class Sphere : ThreeDimensionalShape
{
    private double radius;
    public Sphere(double radius){
        this.radius = radius;
    }
    public override double getArea()
    {
        return 4*Math.PI*radius*radius;
    }
    public override double getVolume()
    {
        return (4.0/3.0)*Math.PI*radius*radius*radius;
    }
}
class Cube : ThreeDimensionalShape
{
    private double edge;
    public Cube(double edge)
    {
        this.edge = edge;
    }
    public override double getArea()
    {
        return 6*edge*edge;
    }
    public override double getVolume()
    {
        return edge*edge*edge;
    }
}
class Program
{
    static void Main(string[] args)
    {
       Circle c = new Circle(5);
       Square s = new Square(3.5);
       Sphere sp = new Sphere(6.1);
       Cube cb = new Cube(9);
       Console.WriteLine(c.ToString());
       Console.WriteLine(c.getArea());
       Console.WriteLine(s.ToString());
       Console.WriteLine(s.getArea());
       Console.WriteLine(sp.ToString());
       Console.WriteLine(sp.getArea());
       Console.WriteLine(sp.getVolume());
       Console.WriteLine(cb.ToString());
       Console.WriteLine(cb.getArea());
       Console.WriteLine(cb.getVolume());
    }
}
