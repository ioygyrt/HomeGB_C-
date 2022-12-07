Console.Clear ();

Console.WriteLine ("Привет-привет. Введите циферку, а я скажу четная она или нет");
int UserNumb = Convert.ToInt32(Console.ReadLine());
if (UserNumb % 2 == 0)
{ 
    Console.WriteLine ("Число " + UserNumb + " является четным");
}
else 
{
    Console.WriteLine ("Число " + UserNumb + " является нечетным");
}