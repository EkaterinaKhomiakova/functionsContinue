// Задайте одномерный массив из 123 случайных чисел
// Найдите колличество элементов массива, значение которых лежат в отрезке [10,99]
// Пример для массива из 5, а не 123 элементов. В своем решении сделайте для 123
// [5,18,123,6,2]->1
// [1,2,3,6,2]->0
// [10,11,12,13,14]->5

void InputArray(int[] array)
{
  for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(0, 100);
}

int ReleaseArray(int[] array)
{
  int sum = 0;
  for (int i = 0; i < array.Length; i++)
    if (array[i] >= 10 && array[i] <= 99)
      sum++;
  return sum;
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
Console.Write(ReleaseArray(array));
