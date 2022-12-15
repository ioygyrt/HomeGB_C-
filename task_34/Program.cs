Console.WriteLine("Привет, задайте число массива");
int sizeUs = Convert.ToInt32(Console.ReadLine());
int[] numb = new int[sizeUs];
FillArrayRandomNumb(numb);
Console.WriteLine("Вот так будет выглядеть массив: ");
PrintArray(numb);

int count = 0; 
for (int z = 0; z < numb.Length; z++)
if (numb[z] % 2 == 0)
count++;

Console.WriteLine($"всего {numb.Length} чисел, {count} из них чётные");

void FillArrayRandomNumb(int[] numb)
{
    for (int i = 0; i < numb.Length; i++)
    {
        numb[i] = new Random().Next(1,5000);
    }
}

void PrintArray(int[] numb)
{
    Console.Write("[");
    for (int i = 0; i < numb.Length; i++)
    {
        Console.Write(numb[i] + " ");
    }
    Console.Write(" ]");
    Console.WriteLine();
}