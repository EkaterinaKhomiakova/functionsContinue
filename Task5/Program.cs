// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый
//  и последний элемент, второй и предпоследний и т.д.
// Результат запишите в новом массиве
// [1,2,3,4,5]->5 8 3
// [6,7,3,6]->36 21
void InputArray(int[] array)
{
  for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(1, 10);
}

void ReleaseArray(int[] array)
{
  for (int i = 0; i < array.Length / 2 + array.Length % 2; i++)
    Console.WriteLine($" {array[i] * array[array.Length - 1 - i]} ");
}

void PrintArray(int[] array)
{
  Console.WriteLine($"[{string.Join(", ", array)}]");
}


Console.Write($"n=");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
PrintArray(array);
ReleaseArray(array);
