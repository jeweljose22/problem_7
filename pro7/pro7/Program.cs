// See https://aka.ms/new-console-template for more information
Console.WriteLine("enter name");
var name = Console.ReadLine();
Console.WriteLine("enter distance");
int distance = int.Parse(Console.ReadLine());
switch (distance)
{
    case (>0 and <=10000):
        {
            Console.WriteLine("awarded 0 falyerpoints");
            break;
        }
    case (>10000 and <=20000) :
        {
            Console.WriteLine("awarded 10 falyerpoints");
            break;
        }
    case (> 20000 and <= 50000):
        {
            Console.WriteLine("awarded 20 falyerpoints");
            break;
        }
    case (> 50000and <=1000000):
        {
            Console.WriteLine("awarded 30 falyerpoints");
            break;
        }
    case (> 1000000):
        {
            Console.WriteLine("awarded 50 falyerpoints");
            break;
        }
    default:
		break;
}
