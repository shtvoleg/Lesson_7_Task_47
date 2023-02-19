// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// Функция InputNum вводит размерность массива с консоли и проверяет её корректность
int InputNum(string txt)
{
    Console.WriteLine(txt);	        //  запрос размерности массива по вертикали
    int num = Convert.ToInt32(Console.ReadLine());
    while (num <= 0)
    {
        Console.WriteLine($"Число должно быть целое, больше 0! \n{txt}");	        //  запрос размерности массива по вертикали
        num = Convert.ToInt32(Console.ReadLine());
    }
    return (num);
}

// Функция FillArray наполняет массив случайными действительными значениями
double[,] FillArray(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
        for (int j = 0; j < matr.GetLength(1); j++)
            matr[i, j] = new Random().Next(-100, 100) / 10.0;     //  делим именно на 10 с точкой
    return matr;
}

// Функция PrintArray выводит значения массива на консоль
void PrintArray(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
            Console.Write("\t" + matr[i, j]);
        Console.WriteLine();
    }
}

Console.Clear();				                                    //  очистка консоли
int m = InputNum("Введите размерность по вертикали (m): ");         //  запрос размерности массива по вертикали
int n = InputNum("Введите размерность по горизонтали (n): ");       //  запрос размерности массива по горизонтали
double[,] matrix = new double[m, n];
FillArray(matrix);                                                  //  вызов функции по наполнению массива случайными вещ. числами
PrintArray(matrix);                                                 //  вызов функции по выводу массива в консоль