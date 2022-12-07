Console.Clear ();

Console.WriteLine ("эхх давайте мне циферку... Выведем все четные числа до этой циферки так и быть");
int UserNumb = Convert.ToInt32(Console.ReadLine());
int index = 0;
while (index <= UserNumb)
{
    Console.WriteLine (index);
    index = index+2;
}
Console.WriteLine ("Это все четные числа до числа --> " + UserNumb);