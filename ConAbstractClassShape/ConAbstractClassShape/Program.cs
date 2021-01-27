using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAbstractClassShape
{
    abstract class Quadrilateral
    {
        public double length;
        public abstract double Area();
        public abstract void Perimeter();
        public Quadrilateral()
        {

        }
        public Quadrilateral(double length)
        {
            this.length = length;
        }
    }
    class Square : Quadrilateral
    {
        
        public Square(double length):base(length)
        {
           
        }
        public override double  Area()
        {
            
            double areaSqu=(length * length);
            Console.WriteLine($"Area of Square is {areaSqu}");
            return areaSqu;
            
        }
        public override void Perimeter()
        {
            double periOfSquare = 4* length;
            Console.WriteLine($"Perimeter of Square is {periOfSquare}");
        }
    }
    class Rectangle: Quadrilateral
    {
        int breath;
        double areaRec;

        public Rectangle(int length,int breath):base(length)
        {
            this.breath = breath;
        }
        public override double Area()
        {
             areaRec=length * breath;
            Console.WriteLine($"Area of Rectangle is {areaRec}");
            return areaRec;
        }
        public override void Perimeter()
        {
            double periOfRect = 2*(length + breath);
            Console.WriteLine($"Perimeter of rectangle is {periOfRect}");
        }

        
        public bool IsSquare
        {
            get
            {
                if (length==breath)
                {
                    
                   return true;
                }
                else
                {
                    return false;
                }
            }
            
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
           
            //Rectangle Object is created
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Area");
            Rectangle rec = new Rectangle(5,5);
            double areaOfRectangle=rec.Area();//Area method Calling
            Square sq = new Square(4);
            double areaOfSquare = sq.Area(); //Area method Calling

            //Checking Square area is greater or less than the rectangle area
            if (areaOfSquare > areaOfRectangle)
            {
                Console.WriteLine("Square area is greater than Rectangle area");
            }
            else
            {
                Console.WriteLine("Rectangle area is greater than Square area");
            }

            //Square Object is Created
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("PeriMeter");
            sq.Perimeter();// Perimeter Method Calling
            rec.Perimeter();// Perimeter Method Calling
            Console.WriteLine("-----------------------------------------");

            bool result = rec.IsSquare;
            Console.WriteLine(result+" Rectangle is Square");
            Console.WriteLine("--------------------------------------");




        }
    }
}
