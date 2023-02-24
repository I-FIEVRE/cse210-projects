using System;

class Program
{
    static void Main(string[] args)
    {
        
        Square sq = new Square("red", 3.2);
        Rectangle rec = new Rectangle("green", 3.2, 2.5);
        Circle cir = new Circle("blue", 4.5);

        List<Shape> shapes = new List<Shape>();
        shapes.Add(sq);
        shapes.Add(rec);
        shapes.Add(cir);

        foreach(Shape sh in shapes)
        {
            string color = sh.GetColor();
            double area = sh.GetArea();
            Console.WriteLine($"The {color} shape of paper has an area of {area}.");
        }

        /*string sqColor = sq.GetColor();
        double sqArea = sq.GetArea();
        Console.WriteLine($"{sqColor} {sqArea}");

        string recColor = rec.GetColor();
        double recArea = rec.GetArea();
        Console.WriteLine($"{recColor} {recArea}");

        string cirColor = cir.GetColor();
        double cirArea = cir.GetArea();
        Console.WriteLine($"{cirColor} {cirArea}");*/
    }
}