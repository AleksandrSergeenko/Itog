# Итоговая проверочная работа.
**Задача:**
Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

**Примеры:**
>*["hello", "2", "world", ":-)"] -> ["2", ":-)"]*

# Блок-схема основной содержательной части (т.к. выделил отдельный метод)

![](/BS.png)

# Описание решения (с заданием массива на старте выполнения алгоритма): 
1. Задаю два массива: startArray и resultArray.
2. Создаю метод, в котором цикл выполняется, если длина текущей строки меньше или равна 3 символам. Если условие выполняется, то строка добавляется в новый массив строк resultArray.
3. Создаю метод вывода массива.
4. Вызываю первый метод.
5. Вызываю второй метод.
