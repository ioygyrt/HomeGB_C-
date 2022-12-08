Console.Clear();
Console.WriteLine("Снова здравствуйте, введите число из 3 знаков, а я Вам покажу какая цифра у вас вторая =)");
int NumbUser= Convert.ToInt32(Console.ReadLine());
string stringSeconNumb = Convert.ToString(NumbUser);
Console.WriteLine("вторая цифра этого числа -> "+stringSeconNumb[1]);