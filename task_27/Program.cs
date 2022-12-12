Console.Clear();
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

  int SumNumber(int num){
    
    int vvod = Convert.ToString(num).Length;
    int dvi = 0;
    int result = 0;

    for (int i = 0; i < vvod; i++){
      dvi = num - num % 10;
      result = result + (num - dvi);
      num = num / 10;
    }
   return result;
  }

int sumNumber = SumNumber(num);
Console.WriteLine("Сумма цифр в числе: " + sumNumber);