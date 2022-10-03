// Вид 1
void Method_1()
{
    Console.WriteLine("Автор ...");
}
//Method_1(); - вызов метода

// Вид 2
void Method_2(string msg)
{
    Console.WriteLine(msg);
}
//Method_2("Текст сообщения"); - вызов метода
//Method_2(msg: "Текст сообщения"); - именованное обращение к аргументу

void Method_2a(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
//Method_2a(msg: "Text", count: 4); - вызов метода, где msg: "Text" - сообщение, выводимое в консоль и count: 4 - количество выведенных сообщений

// Вид 3
int Method_3()
{
    return DateTime.Now.Year;
}

// int year = Method_3(); - кладем метод в переменную
// Console.WriteLine(year); - выводим значение переменной в консоль

// Вид 4
string Method_4(int count, string text) // метод принимающий аргументы int coount и string text
{
    int i = 0;
    string result = String.Empty; //Пустая строка в переменной string result

    while (i < count) // цикл будем работать пока i меньше заданного нами значения для переменной int count
    {
        result = result + text; // Значение переменной string text будет плюсоваться к имеющемуся значению string result
        i++;
    }
    return result; // возвращаем итоговое значение переменной string result
}
// string res = Method_4(10, "z"); - кладем в переменную res наш метод
// Console.WriteLine(res); - выводим в консоль наш метод с помощью переменной res

// Цикл for
string cycleFor(int count, string text)
{
    string result = String.Empty;
    for (int i = 0; i < count; i++) // в цикл for можно сразу писать и счетчик int i = 0; и условие i < count; и инкримент i++
    {
        result = result + text; // Значение переменной string text будет плюсоваться к имеющемуся значению string result
    }
    return result; // возвращаем итоговое значение переменной string result
}
// string res = cycleFor(10, "z"); -кладем в переменную res наш метод
// Console.WriteLine(res); -выводим в консоль наш метод с помощью переменной res

// Цикл в цикле 
// for (int i = 2; i <= 10; i++) // после отработки второго цикла и доавления пустой строки (Console.WriteLine();) в этом цикле будет увеличивать значение переменной i на 1 (сначала 2, затем 3 и тд)
// {
//     for (int j = 2; j <= 10; j++) // сначала отрабатывает этот цикл добавляя каждый раз в переменную j значение от 2 до 10
//     {
//         Console.WriteLine($"{i} x {j} = {i * j}"); // вывод в консоль таблицы умножения
//     }
//     Console.WriteLine(); // пустая строка для красивого разделения 
// }



// Задача 1. Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить черточками,
// маленькие буквы "к" заменить большими "К",
// а большие "С" заменить маленькими "c".

// Ясна ли задача?

string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";

// string s = "qwerty" - строка - это массив в котором есть символы
//             012     - индекс каждого символа в массиве
// s[3] // r           - для того, чтобы нам обратиться к символу "r" мы можем использовать s[3], 
//                       где s имя переменной string s

string Replace(string text, char oldValue, char newValue) // тип char - это символ от слова character
{
    string result = String.Empty; // инициализация пустой строки

    int length = text.Length; //Кладем массив в переменную для того, чтобы получить длину 
                              //нашей строки(длину массива) (text.Length - свойство)
    for (int i = 0; i < length; i++) // цикл будет работать пока индекс равный 0 меньше длины массива
    {
        if (text[i] == oldValue) result = result + $"{newValue}"; // если в массиве символ с каким-то индексом,
                                                                  // равен нужному нам символу (oldValue), то в  
                                                                  // переменную result кладется новый (newValue)
        else result = result + $"{text[i]}"; // иначе в переменной result остается имеющийся символ
    }
    return result;
}
// string newText = Replace(text, ' ', '_'); // в переименную кладем метод в котором берем нужный нам текст(массив)
//                                           // задаем символ который хотим изменить '' и символ на который меняем ''
// Console.WriteLine(newText); // выводим в консоль
// Console.WriteLine(); // добавляем пустую строку для красоты и читабельности
// newText = Replace(newText, 'к', 'К');
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(newText, 'С', 'с');
// Console.WriteLine(newText);



// Задача 2. Сортировка массива
int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

void PrintArray(int[] array) // Метод выводит массив на экран. В качестве аргумента приходит массив
{
    int count = array.Length; // в переменной длина массива

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} "); // Вывод массива в консоль
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)//Метод сортирует массив.
{
    for (int i = 0; i < array.Length - 1; i++)// Нужно отнять 1 потому что далее мы используем int j = i + 1
    {
        int minPosition = i; // Переменная определяет позицию на которую мы смотрим

        for (int j = i + 1; j < array.Length; j++)// Цикл ищет максимальный элемент. Начальная позиция 
            // i + 1 (в переменной int j) потому что мы уже не касаемся отсортерованного кусочка массива
        {
            if (array[j] < array[minPosition]) minPosition = j; // Ищем минимальный элемент. Для этого смотрим 
            // текущую позицию array[i] и если значение элемента в ней меньше предпологаемого в array[minPosition],
            // то сохраняем текущую позицию
        }

        int temporary = array[i]; // присваимваем рабочую позицию переменной temporary
        array[i] = array[minPosition];// в i-тую позицию кладем найденый элемент
        array[minPosition] = temporary;// в минимальную позицию кладем элемент, который был временным
    }
}
PrintArray(arr);// Вызов массива
SelectionSort(arr);// Вызов массива
PrintArray(arr);// Вызов массива
