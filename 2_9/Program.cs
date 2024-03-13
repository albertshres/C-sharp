﻿
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

    class Program
    {
        static void Main(string[] args) { 
        Triangle myTriangle = new Triangle(3,5);
            myTriangle.CalArea();
            myTriangle.DisplayShape();

        }
    }
}