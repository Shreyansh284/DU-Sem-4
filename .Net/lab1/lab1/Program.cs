// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");



using System.Security.Cryptography;


bool i = true;
while(i)
{
    Console.WriteLine("Enter Choice");
    //Console.WriteLine(" \r\n1. Write a program to print your name, address, contact number & city. \r\n2. Write a program to get two numbers from user and print those two \r\nnumbers. \r\n3. Write program to prompt a user to input his/her name and country name  \r\nand then output will be shown as given: Hello <yourname> from country \r\n<countryname> \r\n4. Write a program to calculate the size of the area in square-feet based on \r\nSpecified length and width. \r\n5. Write a program to calculate area of Square, Rectangle and Circle. \r\n6. Write a program to calculate Celsius to Fahrenheit and vice-versa using \r\nfunction. \r\n7. Write a program to find out Simple Interest using function. (I = PRN/100) \r\n8. Write a program to create a Simple Calculator for two numbers (Addition, \r\nMultiplication, Subtraction, Division) [Also using if…else & Switch Case] \r\n9. Write a program to Swapping without using third variable. \r\n10. Write a program to find maximum numbers from given 3 numbers using \r\nternary operator. ")
    int n = int.Parse(Console.ReadLine());
    switch (n)
    {
        case 1:
            Console.WriteLine("Shreyansh");
            Console.WriteLine("laxman Nagar");
            Console.WriteLine("9875211610");
            Console.WriteLine("Gondal");
            break;
        case 2:
            Console.WriteLine("Enter num1");

            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter num1");

            int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("num1 " + n1 + "num2 " + n2);
            break;
        case 3:
            string name = (Console.ReadLine());
            string country = (Console.ReadLine());
            Console.WriteLine("Hello " + name + "from country" + country);
            break;
        case 4:
            int l = int.Parse(Console.ReadLine());
            int w = int.Parse(Console.ReadLine());
            Console.WriteLine("Area" + l * w);
            break;
        case 5:
            Console.WriteLine("Enter Length");
            int length = int.Parse(Console.ReadLine());
            Console.WriteLine("Area of Square: " + length * length);
            Console.WriteLine("Enter Weight");
            int weight = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Height");
            int height = int.Parse(Console.ReadLine());
            Console.WriteLine("Area of rectangle: " + height * weight);
            Console.WriteLine("Enter Radius");
            int radius = int.Parse(Console.ReadLine());
            Console.WriteLine("Area of Circle: " + Math.PI * radius * radius);
            break;
        case 6:
            Console.WriteLine("Enter degree");
            double degree = double.Parse(Console.ReadLine());
            Console.WriteLine("Celisus: " + (degree * 9 / 5 + 32));

            Console.WriteLine("Enter  Fahrenhit");
            double far = double.Parse(Console.ReadLine());
            Console.WriteLine("Celisus: " + ((far - 32) * 5 / 9));
            break;
        case 7:
            Console.WriteLine("Enter Principle");
            int p = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter rate");
            int r = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter time");
            int time = int.Parse(Console.ReadLine());
            Console.WriteLine("Sp: " + p * r * time / 100);
            break;
        case 8:
            Console.WriteLine("Enter num1");
            int num1 = int.Parse(Console.ReadLine());
            string op = Console.ReadLine();
            Console.WriteLine("Enter num2");
            int num2 = int.Parse(Console.ReadLine());

            if (op == "+")
            {
                Console.WriteLine("addition: " + (num1 + num2));
            }

            else if (op == "-")
            {
                Console.WriteLine("subtartion: " + (num1 - num2));
            }
            else if (op == "*")
            {
                Console.WriteLine("mul: " + (num1 * num2));
            }
            else if (op == "/")
            {
                Console.WriteLine("div: " + (num1 / num2));
            }
            else
            {
                Console.WriteLine("Invalid Opration");
            }

            break;
        case 9:

            int a = 10;
            int b = 11;
            Console.WriteLine(" Before Swap A= " + a + " B= " + b);
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine(" After Swap A= " + a + " B= " + b);

            break;
        case 10:

            int a1 = 10;
            int b1 = 11;
            int c1 = 12;

            int max = (a1 > b1) ? ((a1 > c1) ? a1 : c1) : ((b1 > c1) ? b1 : c1);

            Console.WriteLine(max + " is max");
            break;
        case 11:
            i=false;
            break;
        default:
            Console.WriteLine("Invalid Number");
            break ;

    }















}