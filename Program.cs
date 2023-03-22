

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

//2 печать массива
void PrintArray (string [] array)
{
  System.Console.WriteLine(String.Join(", ", array));
}

//3 проверка длины элементов массива
string [] CheckStringArray (string [] array)
{
int size = array.Length; 
string [] newarray = new string [size];
for (int i = 0; i < size; i++)
{
  if (array[i].Length>3)
  {
    continue;
  }
  else
  {
    newarray[i] = array[i];
  }
}
return newarray;
}




string [] matrix = InputStringArray();
PrintArray(matrix);
string [] newmatrix = CheckStringArray (matrix);
System.Console.WriteLine();
PrintArray(newmatrix);
