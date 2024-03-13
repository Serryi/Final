
Console.Write("Введите количество элементов массива: ");
int m = Convert.ToInt32(Console.ReadLine());
string [] stringArray = new string [m];
void GetArray(string [] stringArray) //заполнение массива
{
  for (int i = 0; i<stringArray.Length; i++)
  {
     Console.WriteLine($"Введите {i+1} элемент массива");
     stringArray[i] = Console.ReadLine();
  }
}
string[] Second(string [] stringArray) //новый массив с заданными условиями
{
  int n = 0;
  for (int i = 0;i<stringArray.Length;i++)
  {
    if(stringArray[i].Length <=3)
    n++;
  }
  string [] rez = new string [n];
  int j = 0;
  for (int i = 0;i<stringArray.Length;i++)
  {
    if(stringArray[i].Length <=3)
    {
        rez[j] = stringArray[i];
        j++;
    }
  }
  return rez;
}
void PrintArray(string[] array) //вывод на печать
{
  Console.Write("[");
  for (int i = 0; i < array.Length; i++)
  {
      Console.Write(array[i]);
      if (i < array.Length - 1)
      {
        Console.Write(", ");
      }
  }
  Console.WriteLine("]");
}
GetArray(stringArray);
Second(stringArray);
PrintArray(Second(stringArray));