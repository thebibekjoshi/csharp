
    int a,b;
    Console.WriteLine("Enter two integers to do operation");
    a=int.Parse(Console.ReadLine());
    b=int.Parse(Console.ReadLine());
    Console.WriteLine("operations\n-------");
    Console.WriteLine("1=Addition\n2=Subtraction\n3=Multiplication\n");
    Console.WriteLine("operations\n-------");
    Console.WriteLine("Enter the operation code:");
    int op=int.Parse(Console.ReadLine());
    switch(op)
    {
        case 1:
        Console.WriteLine("Add="+(a+b));
        break;
        case 2:
        Console.WriteLine("Subs=" +(a-b));
        break;
        case 3:
        Console.WriteLine("Multiply=" +(a*b));
        break;
        default:
        Console.WriteLine("Wrong choice");
        break;

    }
