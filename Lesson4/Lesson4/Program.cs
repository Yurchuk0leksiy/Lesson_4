﻿
//static void MyMethod() 
//{
//  Console.WriteLine("I just got executed!");
//}
//MyMethod();
//MyMethod();
//MyMethod();
//MyMethod();
//MyMethod();





//static void MyMethod1(string fname)
//{
//    Console.WriteLine(fname + " Refsnes");
//}

//MyMethod1("Liam");
//MyMethod1("Jenny");
//MyMethod1("Anja");


//static void MyMethod(string country = "Norway")
//{
//    Console.WriteLine(country);
//}

//MyMethod("Sweden");
//MyMethod("India");
//MyMethod();
//MyMethod("USA");

//static void MyMethod(string fname, int age)
//{
//    Console.WriteLine(fname + " is " + age + " " + "year");
//}
//MyMethod("Liam", 5);
//MyMethod("Jenny", 8);
//MyMethod("Anja", 31);


//static int MyMethod(int x)
//{
//    return 5 + x;
//}


//Console.WriteLine(MyMethod(3));

//static void MyMethod(string child1, string child2, string child3)
//{
//    Console.WriteLine("The youngest child is: " + child3);
//}

//MyMethod(child2: "John", child1: "Liam", child3: "Liam");



//static int PlusMethodInt(int x, int y)
//{
//    return x + y;
//}

//static double PlusMethodDouble(double x, double y)
//{
//    return x + y;
//}
//int myNum1 = PlusMethodInt(8, 5);
//double myNum2 = PlusMethodDouble(4.3, 6.26);
//Console.WriteLine("Int: " + myNum1);
//Console.WriteLine("Double: " + myNum2
//

//Lesson4 less = new Lesson4();
//int myNum1 = less.PlusMethod(8, 5);
//double myNum2 = less.PlusMethod(4.3, 6.26);
//Console.WriteLine("Int: " + myNum1);
//Console.WriteLine("Double: " + myNum2);
//public class Lesson4
//{
//    public int PlusMethod(int x, int y)
//    {
//        return x + y;
//    }
//    public double PlusMethod(double x, double y)
//    {
//        return x + y;
//    }
//} 

//void SayHello() => Console.WriteLine("Hello");


//void SayHello()
//{
//    Console.WriteLine("Hello");
//}


//string GetMessage()
//{
//    return "hello";
//}


//string GetMesage() => "hello";


//void Increment(int n)
//{
//    n++;
//    Console.WriteLine($"Число в методе Increment: {n}");
//}
//int number = 5;
//Console.WriteLine($"Число до метода Increment: {number}");
//Increment(number);
//Console.WriteLine($"Число после метода Increment: {number}");



//void Increment(ref int n)
//{
//    n++;
//    Console.WriteLine($"Число в методе Increment: {n}");
//}
//int number = 5;
//Console.WriteLine($"Число до метода Increment: {number}");
//Increment(ref number);
//Console.WriteLine($"Число после метода Increment: {number}");

//void Sum(int x, int y, out int result)
//{
//    result = x + y;
//}
//int number;
//Sum(10, 15, out number);
//Console.WriteLine(number);

//void Sum(int x, int y, out int result)
//{
//    Console.WriteLine(x + y);
//    result = 0;
//}


void GetRectangleData(int width, int height, out int rectArea, out int rectPerimetr)
{
    rectArea = width * height;       // площадь прямоугольника - произведение ширины на высоту
    rectPerimetr = (width + height) * 2; // периметр прямоугольника - сумма длин всех сторон  
}
int area;
int perimetr;
GetRectangleData(10, 20, out area, out perimetr);
Console.WriteLine($"Площадь прямоугольника: {area}");
Console.WriteLine($"Периметр прямоугольника: {perimetr}");
//checked
