Console.Clear();
Console.Write("Введите число  ---> ");
string UsNum = Console.ReadLine();

void CheckNum(string UsNum){
  if (UsNum[0]==UsNum[4] || UsNum[1]==UsNum[3]){
    Console.WriteLine($"Число -->  {UsNum} - палиндром");
  }
  else Console.WriteLine($"Число --> {UsNum} - Не палиндром");
}

if (UsNum.Length == 5){
  CheckNum(UsNum);
}
else Console.WriteLine("Введи пятизначное число");
