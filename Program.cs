

//1 ввод массива с клавиатуры
static string[] InputStringArray()
{
  Console.WriteLine("Введите размер массива");
  int size = Convert.ToInt32(Console.ReadLine());
  string[] array = new string[size];
  for (int i = 0; i < size; i++)
  {
    Console.WriteLine("Введите {0}-й элемент", i + 1);
    array[i] = Console.ReadLine();
  }
  return array;
}

// печать массива
void PrintArray (string [] array)
{
  System.Console.WriteLine(String.Join(", ", array));
}

PrintArray(InputStringArray());
 

