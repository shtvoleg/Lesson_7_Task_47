// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// Функция наполняет массив случайными действительными значениями
double[,] FillArray(double[,] matr) 
{
    for (int i = 0; i < matr.GetLength(0); i++)
        for (int j = 0; j < matr.GetLength(1); j++)
            matr[i, j] = new Random().Next(-100,100)/10.0;     //  делим именно на 10 с точкой
    return matr;
}

// Функция выводит значения массива на консоль
void PrintArray(double[,] matr)
{
     for (int i = 0; i < matr.GetLength(0); i++)
        {
        for (int j = 0; j < matr.GetLength(1); j++)
            Console.Write("\t"+matr[i, j]);
        Console.WriteLine("");
        }
}

Console.Clear();				                                    //  очистка консоли
Console.WriteLine("Введите размерность по вертикали m: ");	        //  запрос размерности массива по вертикали
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите размерность по горизонтали n: ");	    //  запрос размерности массива по горизонтали
int n = Convert.ToInt32(Console.ReadLine());
double[,] matrix = new double[m, n];
FillArray(matrix);                                                  //  вызов функции по наполнению массива случайными вещ. числами
PrintArray(matrix);                                                 //  вызов функции по выводу массива в консоль