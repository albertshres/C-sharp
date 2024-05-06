
//9. create an interface representing a shape with methods like calculate Area and Display shape info . Implement this interface in different classes representing shape

using System;
namespace Interface
{
     interface Ishape
        {
            void CalArea();
            void DisplayShape();    
        }
    

    class  Triangle : Ishape
    {    int breadth,height;
        public Triangle(int breadth,int height) {

            this.breadth = breadth;
            this.height = height;   
        
        }   
        public void CalArea() {
        
            int res= (breadth*height)/2;
            Console.WriteLine($"the area of the triangle is {res}" );
        }

        public void DisplayShape()
        {
            Console.WriteLine("Shape is Triangular");
            Console.WriteLine($"It has breadth = {breadth} and it has height = {height}");
        }
    }


    class Circle : Ishape
    {
        int radius;
        double pie = 3.14;
        public Circle(int radius)
        {

            this.radius = radius;
            

        }
        public void CalArea()
        {

            double res = pie * radius * radius;
            Console.WriteLine($"the area of the triangle is {res}");
        }

        public void DisplayShape()
        {
            Console.WriteLine("Shape is Circular");
            Console.WriteLine($"It has radius = {radius} ");
        }
    }

    class Program
    {
        static void Main(string[] args) { 
        Triangle myTriangle = new Triangle(1,2);
            myTriangle.CalArea();
            myTriangle.DisplayShape();
        
        Circle myCircle= new Circle(5);
            myCircle.CalArea();
            myCircle.DisplayShape();
        }
    }
}