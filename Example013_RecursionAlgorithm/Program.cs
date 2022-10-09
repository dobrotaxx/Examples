﻿// string[,] table = new string[2, 5];
// // string.Empty - по умолчанию строки инициализируются пустой строкой
// // table[0, 0]  table[0, 1]  table[0, 2]  table[0, 3]  table[1, 4]
// // table[1, 0]  table[1, 1]  table[1, 2]  table[1, 3]  table[1, 4]
// // table[1, 2] = "слово"; // обращение к элементу массива 1 - строка, 2 - столбец
// // for (int rows = 0; rows < 2; rows++) // цикл печати массива, где rows - строки, начинаем с 0
// // {
// //     for (int columns = 0; columns < 5; columns++) // columns - столбцы
// //     {
// //         Console.WriteLine($"-{table[rows, columns]}-"); // команда печати
// //     }
// // }

// void PrintArray(int[,] matr) //метод печатающий массив
// {
//     for (int rows = 0; rows < matr.GetLength(0); rows++)
//     // matrix.GetLength(0); - выдаст нам количество строк
//     {
//         for (int columns = 0; columns < matr.GetLength(1); columns++)
//         // matrix.GetLength(1); - выдаст нам количество столбцов
//         {
//             Console.Write($"{matr[rows, columns]} ");// печатаем в одну строку
//         }
//         Console.WriteLine();// добавляем пустую строку, чтобы массив печатался прямоугольником
//     }
// }

// void FillArray(int[,] matr) // метод заполняет массив случайными числами
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             matr[i, j] = new Random().Next(1,10);// полуинтервал [1;10)
//         }
//     }
// }

// int[,] matrix = new int[3, 4]; //числовой массив
// PrintArray(matrix);
// FillArray(matrix);
// Console.WriteLine();
// PrintArray(matrix);

// int[,] pic = new int[,] /*new int[,] - не обязательно указывать число строк и столбцов если есть фиксированные 
// данные*/
// {
//     {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
//     {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
//     {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
//     {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
//     {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
//     {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
//     {0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
//     {0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
//     {0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
//     {0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
//     {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
//     {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
//     {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
//     {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
//     {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
//     {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
//     {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
//     {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
//     {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0 },
//     {0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0 },
//     {0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0 },
//     {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0 },
//     {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// };

// void PrintImage(int[,] image)
// {
//     for (int i = 0; i < image.GetLength(0); i++)//перебор строк
//     {
//         for (int j = 0; j < image.GetLength(1); j++)//перебор столбцов
//         {
//             if (image[i, j] == 0) Console.Write($" ");
//             else Console.Write($"+");
//         }
//         Console.WriteLine();
//     }
// }

// void FillImage(int row, int col) //int row - строка, int col - пиксель (с которых должнгы начать закраску)
// {
//     if (pic[row, col] == 0)/*если пиксель на текущей позиции pic[row, col] равен нулю (не закрашен), то в этом
//     случае мы будем его красить*/
//     {
//         pic[row, col] = 1; // красим единичкой
//         FillImage(row - 1, col); /* метод вызывает сам себя и мы определяем правило (что идет за чем)
//         (row-1, col) - поднимаемся на строчку выше*/
//         FillImage(row, col - 1); // дальше в той же строке, но идем влево - (row, col-1), меняя позицию столбика
//         FillImage(row + 1, col); // далее идем вниз увеличивая на 1 позицию строки - (row+1, col)
//         FillImage(row, col + 1); // далее идем вправо оставаясь в той же строке увеличивая на 1 стобик - (row, col+1)
//     }
// }
// PrintImage(pic);
// FillImage(13, 13);
// PrintImage(pic);

// double Factorial(double n) // метод принимает число и находит его факториал
// {
//     // 1! = 1
//     // 0! = 1
//     if (n == 1) return 1; // если мы дошли до 1 (наша n = 1), то возвращаем 1 (по определению факториала)
//     else return n * Factorial(n - 1); // иначе возвращаем текущее значение и умноженное на факториал предыдущего числа
// }
// for (double i = 1; i < 40; i++)
// {
//     Console.WriteLine($"{i}!={Factorial(i)}");

// }

// Числа Фибоначчи
//  f(1) = 1
//  f(2) = 1
//  f(n) = f(n-1) + f(n-2)

double Fibonacci(double n)
{
    if (n == 1 || n == 2) return 1;
    else return Fibonacci(n - 1) + Fibonacci(n - 2);

}

for (double i = 1; i < 50; i++)
{
    Console.WriteLine($"f({i}) = {Fibonacci(i)}");
}