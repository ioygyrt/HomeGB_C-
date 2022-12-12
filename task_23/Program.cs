Console.Clear();
Console.WriteLine("Здравствуйте, введите любое число");
int cubeNum = Convert.ToInt32(Console.ReadLine());

void kubik(int[] cubeNum){
  int counter = 0;
  int length = cubeNum.Length;
  while (counter <  length){
    cubeNum[counter] = Convert.ToInt32(Math.Pow(counter, 3));
    counter++;
  }
}

void pokazArry(int[] coll){
  int count = coll.Length;
  int index = 0;
  while(index < count){
    Console.Write(coll[index]+ " ");
    index++;
  }
} 

int[] array = new int[cubeNum+1];
kubik(array);
pokazArry(array);