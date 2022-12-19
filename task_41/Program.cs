Console.Clear();
Console.WriteLine("Здрасте, введит числа сколько хотите через запятую");
int[] UserNumb = StringToNum(Console.ReadLine());
PrintArray(UserNumb);
int sum = 0;
for (int i = 0; i < UserNumb.Length; i++)
{
    if (UserNumb[i] > 0)
    {
        sum++;
    }
}
Console.WriteLine();
Console.WriteLine($"количество значений больше 0 = {sum}");


int[] StringToNum(string input)
{
    int count = 1;
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] == ',')
        {
            count++;
        }
    }

    int[] UserNumb = new int [count];
    int index = 0;

    for (int i = 0; i < input.Length; i++)
    {
        string temp = "";

        while (input [i] != ',')
        {
        if(i != input.Length - 1)
        {
            temp += input [i].ToString();
            i++;
        }
        else
        {
            temp += input [i].ToString();
            break;
        }
        }
        UserNumb[index] = Convert.ToInt32(temp);
        index++;
    }
    return UserNumb;
}


void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + "");
    }
    Console.Write("]");
}
