using enteringValues;

Console.Title = "Calculator";

double a = 0;
double b = 0;

string act ="", c = "+", r = "+";



while (c == "+")
{
    Console.Clear();
    Input.Num();
    Input.actions();
    

    Console.WriteLine("Do you want to see the last five results?");
    r = Console.ReadLine();
    if(r == "+")
    {

    }
    else
    {
        continue;
    }
    
    Console.WriteLine("Do you want to continue?(+/-)");
    c = Console.ReadLine();

}


    

   

    
    

    
            