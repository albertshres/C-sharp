//7. Create a class representing or proporties like make , model and year. Create instance (object) and display properties

using System;
namespace myApp
{
    class Program
    {
        class Car
        {
            string make = "Germany";
            string model = "Vw Polo";
            int year = 2001;

            static void Main(string[] args)
            {
                Car obj = new Car();
                Console.WriteLine($" The car was from {obj.make} and it's model was {obj.model} and year of manufacture is {obj.year}");
            }
        }


    }
}



/*
using System;
namespace myApp
{
    class Program
    {
        class Car
        {
            public string makein = "";
            public string car_model = "";
            public int car_year;

        }
            static void Main(string[] args)
            {

                Car Ford = new Car();
                Ford.makein = "Germany";
                Ford.car_model = "Vw";
                Ford.car_year = 2000;

                Console.WriteLine($" The car was from {Ford.makein} and it's model was {Ford.car_model} and year of manufacture is {Ford.car_year}");
            }
        

    }
}
*/
/*
using System;
namespace myApp
{
    class Program
    {
        class Car
        {
            public string make,model;
            public int year;

            public Car(string makeIn, string modelOf, int yearOf)
            {

                 make = makeIn;
                 model = modelOf;
                 year = yearOf;


            }
            public void Sound()
            {
                Console.WriteLine("Racing Sound");
            }


            static void Main(string[] args)
            {
                Car obj1 = new Car("Japan", "Nissan", 2000);
                Car obj2 = new Car("USA", "Jeep", 2001);

                Console.WriteLine(obj1.make);
                Console.WriteLine(obj2.model);
                obj1.Sound();
                obj2.Sound();
            }
        }



    }
}
*/


