// See https://aka.ms/new-console-template for more information

/*
Console.WriteLine("Hello, World!");
int a = 20;
char b = 'A';
string name = "albert";
Console.WriteLine(a);
Console.WriteLine("the value of a is " + a);

Console.WriteLine(b);
Console.WriteLine("the value of b is " + b);

Console.WriteLine(name);
Console.WriteLine("the value of name is " + name);
//another method for concatination
Console.WriteLine($"Your  name is {name}");

int c = 21;
Console.WriteLine("the value of c is "+c);

Console.WriteLine("the sum of a and c is "+ (a+c));

int sum = a + c;
Console.WriteLine("the sum of two variable is "+ sum);
*/

//to take input from the user we use ReadLine() it only takes string
/*
string s = Console.ReadLine();
Console.WriteLine("your name is "+ s);
*/
/*
Console.WriteLine("Enter your first name");
string fname=Console.ReadLine();

Console.WriteLine("Enter your Last name");
string lname=Console.ReadLine();

Console.WriteLine($"Your name is {fname} {lname}");
*/

Console.WriteLine("Enter first number");
string first = Console.ReadLine();
int num1 = Convert.ToInt32(first);

Console.WriteLine("Enter second number");
string second = Console.ReadLine();
int num2 = Convert.ToInt32(second);

int sum = num1 + num2;
Console.WriteLine($"The sum of {num1} and {num2} is {sum}  ");






