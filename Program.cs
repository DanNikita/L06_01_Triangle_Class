using System.Diagnostics;

internal class Program
{
    //public struct Sides
    //{
    //    public int Side_a;
    //    public int Side_B;
    //    public int Side_C;
    //}
    static void Main(string[] args)
    {
        Triangle Tr = new Triangle(); //create class example
        Console.Write("Enter three sides, a:");
        Tr.a = int.Parse(Console.ReadLine());
        Console.Write("b:");
        Tr.b = int.Parse(Console.ReadLine());
        Console.Write("c:");
        Tr.c = int.Parse(Console.ReadLine());
        Triangle.Print(Tr);
    }
}
public class Triangle
{
    public int a = 0;
    public int b = 0;
    public int c = 0;
    public static bool Check(int side1, int side2, int side3) //Checking sides
    {
        Console.WriteLine("Entering method to check sides");
        if (side1 != 0 & side2 != 0 & side3 != 0)
            return true;
        else
            return false;
    }
    public static int Perimeter(int side1, int side2, int side3) //Calculating perimeter
    { 
        int sum = side1 + side2 + side3;
        return sum;
    }
    public static double Square(int side1, int side2, int side3) //Calculating square
    {
        double per = Perimeter(side1,side2,side3);
        double s = Math.Sqrt(per * (per - side1) * (per - side2) * (per - side3));
        return s;   
    }
    public static void Print(Triangle toWrite) //Printing all sides
    {
        Console.WriteLine("Side a: {0}", toWrite.a); //What about Triangle.a???
        Console.WriteLine("Side b: {0}", toWrite.b);
        Console.WriteLine("Side b: {0}", toWrite.c);
        Console.WriteLine("Perimeter {0}", Perimeter(toWrite.a, toWrite.b, toWrite.c));
        Console.WriteLine("Square {0:F2}", Square(toWrite.a, toWrite.b, toWrite.c));
    }
    
    ////public static Sides NewTriangle(int input1, int input2, int input3)
    ////{
    ////    return new Sides { Side_a = input1,Side_B =  input2,Side_C = input3};
    ////}
    //public int perimeter(Sides)
    //{
    //    int sum = 0;
    //    return int sum =  Sides.Side_a +
    //}

}
