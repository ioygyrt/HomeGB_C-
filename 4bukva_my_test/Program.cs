Console.Clear();

Console.WriteLine("Hello, what is your name? Please write your name ---> ");
int Name = Convert.ToInt32(Console.ReadLine());
String NameConvert = Convert.ToString(Name);
Console.WriteLine("4 буква Вашего имени это --->" + NameConvert[3]);