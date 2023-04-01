/* Задача:
Написать программу, которая из имеющегося массива строк формирует массив из строк, 
длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами.
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
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    Console.Write($"{array[i]}, ");
    Console.Write($"{array[startArray.Length - 1]}]");
}

// Вызываю методы
ResultArray(startArray, resultArray);
PrintArray(resultArray);
