// Задаю количество строк массива и заполняю строки
Console.Write("Введите количество строк: ");
int n = int.Parse(Console.ReadLine()!);
string[] inputArr = new string[n];
for (int i = 0; i < n; i++)
{
    Console.Write($"Введите строку {i + 1}: ");
    inputArr[i] = Console.ReadLine()!;
}
// Создаю новый массив строк и инициализирую его пустыми значениями.
string[] outputArr = new string[n];
int k = 0;
//Проход по каждой строке из исходного массива. 
//Если длина текущей строки меньше или равна 3 символам, то добавить ее в новый массив строк.
for (int i = 0; i < n; i++)
{
    if (inputArr[i].Length <= 3)
    {
        outputArr[k] = inputArr[i];
        k++;
    }
}
// Вывод результата
Console.WriteLine("-> ");
for (int i = 0; i < k; i++)
{
    Console.WriteLine(outputArr[i]);
}
