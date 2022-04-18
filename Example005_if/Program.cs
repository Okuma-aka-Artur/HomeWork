Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "артур")
{
    Console.WriteLine("Ура это же Ты");
}
else 
{
    Console.Write("Привет ");
    Console.WriteLine(username);
}
