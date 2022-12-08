Console.Clear ();
Console.WriteLine("Напишите ваши циферки сколько угодно. дальше видно будет ");
int randomUserNumb = Convert.ToInt32(Console.ReadLine());
string numberus = Convert.ToString(randomUserNumb);
if (numberus.Length > 2){
  Console.WriteLine("третья цифра -> " + numberus[2]);
}
else 
  Console.WriteLine("-> нету третьей цифры-то, нееету =) ");