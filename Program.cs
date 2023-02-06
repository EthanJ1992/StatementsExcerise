/////// Exercise one/////////////
//Console.WriteLine("Guess My FavNumber");

//var r = new Random();
//var favNumber = r.Next(1, 1000);
//int userInput = int.Parse(Console.ReadLine());

//    if (userInput < favNumber)
//    {
//        Console.WriteLine("Nope guess to low");
//    }
//    else if (userInput > favNumber)
//    {
//        Console.WriteLine("Once again guess to high");
//    }
//    else
//    {
//        Console.WriteLine("About time that's correct");
//    }









/////////Exercise Two/////////
Console.WriteLine("What is your favorite subject");
string subject = Console.ReadLine().ToLower();
switch (subject)
{
    case "math":
        Console.WriteLine("No not my favorite");
        break;
    case "reading":
        Console.WriteLine("this troubles me");
        break;
    case "history":
        Console.WriteLine("It's overwhelimg");
        break;
    case "social studies":
        Console.WriteLine("I love this");
        break;
    case "science":
        Console.WriteLine("i hate this");
        break;
    default:
        Console.WriteLine("nope not at all");
        break;


}






        