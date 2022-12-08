Console.Clear ();

Console.WriteLine("Давайте проверим... Введите цифру от 1 до 7 и я скажу Вам выходной это или нет =) ");
int UserDayWeek = Convert.ToInt32(Console.ReadLine());

void CheckDayWeek (int UserDayWeek) {
  if (UserDayWeek == 6 || UserDayWeek == 7) {
  Console.WriteLine("Урррра выходноой");
  }
  else if (UserDayWeek < 1 || UserDayWeek > 7) {
    Console.WriteLine("Ну что вы дней то всего 7");
  }
  else Console.WriteLine("Иди работай");
}

CheckDayWeek(UserDayWeek);
