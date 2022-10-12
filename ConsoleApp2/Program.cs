Console.Title = "Calculator";
string act;
double a, b;
Console.WriteLine("Enter first number");
    a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter second number");
    b = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Choose on of the action: sub, mult, div, add"); 
act = Console.ReadLine();                                           //(act == "sub" || act == "mult" || act == "div" || act == "add")
    switch (act)
    {
        case "sub":
            Console.WriteLine($"Result {a - b}");
            break;
        case "add":
            Console.WriteLine($"Result {a + b}");
            break;
        case "div":
            Console.WriteLine($"Result {a / b}");
            break;
        case "mult":
            Console.WriteLine($"Result: {a * b}");
            break;
        default:
            Console.WriteLine("No valid action. Try again");
        break;

    }



    
    

    
            