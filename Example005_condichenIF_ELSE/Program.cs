Console.Write("Введите имя: ");
string username = Console.ReadLine();

if(username.ToLower() == "Имам")

{
    Console.WriteLine("Ура это же маша");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}