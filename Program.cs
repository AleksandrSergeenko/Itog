/* Вариант решения с заполнением массива с клавиатуры:
// Задаю количество строк массива и заполняю его строками
Console.Write("Введите количество строк: ");
int n = int.Parse(Console.ReadLine()!);
string[] array = new string[n];
for (int i = 0; i < n; i++)
{
    Console.Write($"Введите строку {i + 1}: ");
    array[i] = Console.ReadLine()!;
}
// Создаю новый массив строк и инициализирую его пустыми значениями.
string[] result = new string[n];
int k = 0;
//Проход по каждой строке из исходного массива: 
//цикл выполняется, если длина текущей строки меньше или равна 3 символам. Если условие выполняется, то строка добавляется в новый массив строк.
for (int i = 0; i < n; i++)
{
    if (array[i].Length <= 3)
    {
        result[k] = array[i];
        k++;
    }
}
// Вывод результата
Console.WriteLine("-> ");
for (int i = 0; i < k; i++)
{
    Console.WriteLine(result[i]);
}
 */
// Вариант решения с заданным на старте выполнения массивом {"hello", "2", "world", ":-)"}
string[] startArray = new string[4] {"hello", "2", "world", ":-)"};
String.Join(", ", startArray); 
Console.Write($"[{String.Join(", ", startArray)}] -> "); // красивый вывод заполненного массива, строки через запятую, в квадратных скобках, со стрелочкой - для наглядности
string[] resultArray = new string[startArray.Length];

//Метод, в котором цикл выполняется, если длина текущей строки меньше или равна 3 символам. 
//Если условие выполняется, то строка добавляется в новый массив строк resultArray.
void ResultArray(string[] startArray, string[] resultArray)
{
    int count = 0;
    for (int i = 0; i < startArray.Length; i++)
    {
        if(startArray[i].Length <= 3)
            resultArray[count] = startArray[i];
            count++; 
    } 
}

//Метод вывода массива
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    Console.Write($"{array[i]}");
}

// Вызываю методы
ResultArray(startArray, resultArray);
PrintArray(resultArray);
