Console.Write("Введите имя пользователя");
string username = Console.ReadLine();

if(username.ToLower() == "иконостас")
{
    Console.WriteLine(" _Маша_ ");
}
else
{
    Console.Write("привет");
    Console.WriteLine(username);
}