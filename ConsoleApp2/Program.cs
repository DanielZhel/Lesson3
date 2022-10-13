Console.Title = "Calculator";

string act,c;
double a, b;

c = "+";

double[] fiveREZ = new double[5];

while (c == "+")
{
    Console.Clear();

    try // checking data type
    {
        Console.WriteLine("Enter first number.");
        a = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter second number.");
        b = Convert.ToDouble(Console.ReadLine());
    }
    catch (Exception)
    {
        Console.WriteLine("No valid number. Try again!");
        Console.ReadLine();
        continue;
    }

    Console.WriteLine("Choose on of the action: sub, mult, div, add.");
    act = Console.ReadLine();

    switch (act)
    {
        case "sub":
            Console.WriteLine($"Result: {a - b}");
            break;
        case "add":
            Console.WriteLine($"Result: {a + b}");
            break;
        case "div":
            if (b == 0)
            {
                Console.WriteLine("Can`t be divided by 0. Try again!"); //prevent division by 0
            }
            Console.WriteLine($"Result: {a / b}");
            break;
        case "mult":
            Console.WriteLine($"Result: {a * b}");
            break;
        default:
            Console.WriteLine("No valid action. Try again!");
            break;
    }

    Console.WriteLine("If you want to continue calculations PRESS +, otherwise PRESS -!");
    c = Console.ReadLine();

        if (c == "+" )
        {
            c = "+";
        }

}


    
    

    
            