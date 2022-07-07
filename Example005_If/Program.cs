Console.WriteLine("Please, insert your name: ");
string username = Console.ReadLine();

if (username.ToLower() == "mary")
{   
    Console.WriteLine("Hey, it's MARY!!");
}
else
{
    Console.WriteLine("Hello, ");
    Console.WriteLine(username);
}