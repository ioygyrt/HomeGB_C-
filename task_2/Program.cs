Console.Clear ();

Console.WriteLine ("Привет-привет. Введи циферку");
int FirstNumb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("А теперь вторую");
int SecondNumb = Convert.ToInt32(Console.ReadLine());
if (FirstNumb > SecondNumb)
{
    Console.WriteLine ("Цифра " + FirstNumb + " больше " + SecondNumb + " Thanks!");
}  
else
{
    if (FirstNumb == SecondNumb)
{
    Console.WriteLine ("Цифра " + SecondNumb + " равна " + FirstNumb + " Thanks!");
}
else
{
    Console.WriteLine ("Цифра " + SecondNumb + " больше " + FirstNumb + " Thanks!");
}}   
