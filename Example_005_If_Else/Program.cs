Console.Write("Введите Ваше имя: ");
string username = Console.ReadLine();

if(username.ToLower() == "алексей") // ToLower означает "опускать" регистр заглавных букв 
{
    Console.WriteLine("Привет Лёха!!!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}