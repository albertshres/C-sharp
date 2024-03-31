
//Inorder to create controller file. First right click on controller , then create mvc controller Empty and the write the name of file for eg HelloWorldController and the create



using Microsoft.AspNetCore.Mvc;

namespace _4_1.Controllers
{
    public class HelloWorldController : Controller
    {
        /*
       public string Index()
       {
           return "Hello World";
       }
       */
        public IActionResult Index()
        {
            return View();//now goes to the views file
        }


        public IActionResult Loop()
        {

            return View();

        }
        /*
        public string Name(string name, int roll)
        {
            //localhost:7239/HelloWorld/Name?name=Ram&roll=2 write this in url to get the value i.e get request

            string res = $"The name is {name} and has roll number {roll}";
            return res;
        }
        */

        public IActionResult Name(string name,int roll)
        {
            ViewData["name"] = name;
            ViewData["roll"] = roll;
            return View();
        }
        /*
        public int Sum(int a, int b)
        //localhost:7239/HelloWorld/Sum?a=2&b=3
        {
            return a + b;
        }
        */
        public IActionResult Sum(int a, int b)
        {
            ViewData["first"] = a;
            ViewData["second"] = b;
            return View();
        }

        public IActionResult Switch_case(int rating)
        {
            ViewData["rating"] = rating;
            return View();
        }

    }
}
