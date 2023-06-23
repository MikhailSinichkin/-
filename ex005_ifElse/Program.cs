Console.Write("Введите имя пользователя");
string username = Console.ReadLine();

if(username.ToLower() == "маша")
{
    Console.WriteLine(" Привет ,Машуня! ");
}
else
{
    Console.Write("привет");
    Console.WriteLine(username);
}