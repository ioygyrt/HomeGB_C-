Console.WriteLine("задайте размер массива");
int UserSize = Convert.ToInt32(Console.ReadLine());
int[] numb = new int[UserSize];
FillArrayRandomNumb(numb);
Console.WriteLine("Вот наш массив: ");
PrintArray(numb);
int sum = 0;

for (int z = 0; z < numb.Length; z+=2)
    sum = sum + numb[z];

    Console.WriteLine($"всего {numb.Length} чисел, сумма элементов на нечётных позициях = {sum}");


void FillArrayRandomNumb(int[] numb)
{
    for(int i = 0; i < numb.Length; i++)
        {
            numb[i] = new Random().Next(1,10);
        }
}
void PrintArray(int[] numb)
{
    Console.Write("[");
    for(int i = 0; i < numb.Length; i++)
        {
            Console.Write(numb[i] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}
