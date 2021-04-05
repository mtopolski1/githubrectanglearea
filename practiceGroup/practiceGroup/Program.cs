using System;

namespace practiceGroup
{
    class Program
    {
        static void Main(string[] args)
        {

            //User inputs Rectangle Area: A (area) = L (length) x W (width)
            //User inputs length of rectangle
            Console.Write("Please write the length of your rectangle: ");
            string length = Console.ReadLine();
            double L = double.Parse(length);

            Console.WriteLine("Please write the width of your rectangle: ");
            string width = Console.ReadLine();
            double w = double.Parse(width);
            double area = L * w;
            double perimeter = (L * 2) + (w * 2);

            Console.WriteLine("The area of the rectangle is " + area + " and the parimeter is " + perimeter);

            Console.ReadLine();

        }
    }
}


/*Get length of rectangle
get width of rectangle
Calculate area and perimeter
display those values
make new github
push to github*/