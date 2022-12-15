Console.WriteLine("Введите размер массива");
int UserSize = Convert.ToInt32(Console.ReadLine());
double[] numb = new double[UserSize];
FillArrayRandomNumbers(numb);
Console.WriteLine("Вот наш массив: ");
PrintArray(numb);
double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int z = 0; z < numb.Length; z++)
{
    if (numb[z] > max)
        {
            max = numb[z];
        }
    if (numb[z] < min)
        {
            min = numb[z];
        }
}

Console.WriteLine($"всего {numb.Length} чисел. Максимальное значение = {max}, минимальное значение = {min}");
Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");

void FillArrayRandomNumbers(double[] numb)
{
    for(int i = 0; i < numb.Length; i++)
        {
            numb[i] = Convert.ToDouble(new Random().Next(1,100));
        }
}
void PrintArray(double[] numb)
{
    Console.Write("[");
    for(int i = 0; i < numb.Length; i++)
        {
            Console.Write(numb[i] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}
