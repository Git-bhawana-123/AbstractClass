using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    interface IsSquare
    {
        string Message(string text);
        

    }
    abstract class  Quadrilateral
    {
        protected double  length;
        protected double Breadth;

        public Quadrilateral()
        {

        }
        public Quadrilateral(double _length)
        {
            length = _length;   

        }
        public Quadrilateral(double _length,double _breadth)
        {
            length= _length;
            Breadth = _breadth;

        }
        public abstract void Area();
        public void Show()
        {

        }

    }
    class Square: Quadrilateral
    {
        public Square()
        {

        }
        public Square(double _length):base(_length)
        {

        }
        public override void Area()
        {
            double area = length * length;
            double perimeter = 4 * length;
            Console.WriteLine($"Area of Square is :{area}");
            Console.WriteLine($"Perimeter of Square is :{perimeter}");
        }
    }
    class Rectangle: Quadrilateral , IsSquare
    {
        public Rectangle()
        {

        }
        public Rectangle(double _length, double _breadth): base(_length,_breadth)
        {

        }
        public override void Area()
        {
            double area = length * Breadth;
            double perimeter= 2*(length+Breadth);
            Console.WriteLine($"Area of Rectangle is :{area}");
            Console.WriteLine($"Perimeter of Rectangle is:{perimeter}");
        }

        public string Message(  string  text )
        {
            return "true";
        }
    }
    internal class Program
    {   
        static void Show(double rectangle, double square)
        {
            if (rectangle > square)
            {
                Console.WriteLine("Rectangle Area is  Greater than Square Area");
            }
            else
            {
                Console.WriteLine("Square Area is Greater than Rectangle Square Area");
            }
        }
        static void Main(string[] args)
        {
            Quadrilateral rectangle = new Rectangle(5,6);
            rectangle.Area();
            rectangle.Show();

            Console.WriteLine("----------------------");

            Quadrilateral  square = new Square(4);
            square.Area();
            square.Show();

            Console.WriteLine("----------------------");
           

            
            Show(8,6);

            Console.WriteLine("----------------------");

            IsSquare isSquare = new Rectangle();
            Console.WriteLine($"Rectangle is a square:{isSquare.Message("true")}");


            Console.ReadLine();
                

        }
    }
}
