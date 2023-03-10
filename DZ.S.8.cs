

/*Урок 8. Двумерные массивы. Продолжение
При оценивании учитывается чистота программного кода (выбор имени и стиля написания). Учитывается наличие Гитхаба. summary ЖЕЛАТЕЛЬНЫ

Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/


/// <summary>
/// GetArray - метод создает массив
/// </summary>
/// <param name="rows"></param> строки
/// <param name="cols"></param> столбцы
/// <param name="min"></param> минимальное значение в массиве
/// <param name="max"></param> максимальное зачение в массиве
/// <returns> возвращаем созданую матрицу Array</returns>
/*
int[,] GetArray(int rows, int cols, int min, int max)// Задаем массив целых чисел
{
    int[,] Array = new int[rows, cols];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            Array[i, j] = new Random().Next(min, max + 1);
        }
    }
    return Array;
}
/// <summary>
/// Метод печатает созданный ранее массив
/// </summary>
/// <param name="inputArray"></param>
void PrintArray(int[,] inputArray)
{
    for (int i = 0; i < inputArray.GetLength(0); i++)//Столбцы, где 1 - индекс столбцов
    {
        for (int j = 0; j < inputArray.GetLength(1); j++) //Строки, где 0 - индекс строк
        {
            Console.Write(inputArray[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
//Заполняем матрицу "rezultArray" с помощью метода GetArray

int[,] rezultArray = GetArray(4, 4, 0, 10);
// печатаем матрицу
PrintArray(rezultArray);

/// <summary>
/// Метод ChangeRows расставляет значения метода в строках по убыванию
/// </summary>
/// <param name="rezultArray"></param>

void ChangeRows(int[,] rezultArray)
{
    int temp;//Переменная temp, в которую будем помещать значниия строк массива
    int lastRow = rezultArray.GetLength(0) - 1;// Количество элементов в строке
    int lastCol = rezultArray.GetLength(1) - 1;// Количество элементов в столбце
    for (int i = 0; i < lastCol + 1; i++)
    {
        for (int j = 0; j < lastRow + 1; j++)
        {
            for (int k = 0; k < lastRow; k++)//Вводим индекс для сравнительной проверки каждого элемента строки 
            {
                if (rezultArray[i, k] < rezultArray[i, k + 1])//цикл сравнения индексов строки и замена в правую сторону
                {
                    temp = rezultArray[i, k + 1];
                    rezultArray[i, k + 1] = rezultArray[i, k];
                    rezultArray[i, k] = temp;
                }
            }
        }
    }
}
Console.WriteLine();
ChangeRows(rezultArray);//Изменяем заданные строки массива
PrintArray(rezultArray);//Печатаем полученный массив


/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
*/

/*int[,] GetArray(int rows, int cols, int min, int max)// Задаем массив целых чисел
{
    int[,] Array = new int[rows, cols];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            Array[i, j] = new Random().Next(min, max + 1);
        }
    }
    return Array;
}
/// <summary>
/// Метод печатает созданный ранее массив
/// </summary>
/// <param name="inputArray"></param>
void PrintArray(int[,] inputArray)
{
    for (int i = 0; i < inputArray.GetLength(0); i++)//Строки, где 0 - индекс строк
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)//Столбцы, где 1 - индекс столбцов
        {
            Console.Write(inputArray[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
//Заполняем матрицу "rezultArray" с помощью метода GetArray

int[,] rezultArray = GetArray(4, 4, 0, 10);
Console.WriteLine();
// печатаем матрицу
PrintArray(rezultArray);

/// <summary>
/// Задаем метод поиска строки с наименьшей суммой элементов
/// </summary>
/// <returns></returns>
int SumArray(int[,] rezultArray)
{
    int n = -1;
    int summ = 0;
    for (int i = 0; i < rezultArray.GetLength(0); i++)//Строки, где 0 - индекс строк
    {
        int sum = 0;
        for (int j = 0; j < rezultArray.GetLength(1); j++)//Столбцы, где 1 - индекс столбцов
        {
            sum = sum + rezultArray[i, j];
        }
        Console.Write("Строка -" + (i) + "\t" + "Сумма строки = " + (sum));
        Console.WriteLine();
        if (i == 0)
        {
            summ = sum;
        }
        if (summ > sum)
        {
            summ = sum;
            n = i;// индекс строки с наименьшей суммой числе
        }
    }
    Console.WriteLine();
    Console.Write("Сумма минимальной строки" + "\t" + (summ) + "\t" + "Строка -" + (n));
    Console.WriteLine();
    return summ;
}
Console.WriteLine();
SumArray(rezultArray);
*/



/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/
/*
int[,] GetMatrix(int rows, int cols, int min, int max)// Задаем метод для заполнения массива
{
    int[,] Array = new int[rows, cols];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            Array[i, j] = new Random().Next(min, max + 1);
        }
    }
    return Array;
}

//Создаем метод распечатывания массивов

void PrintMatrix(int[,] inputArray)
{
    for (int i = 0; i < inputArray.GetLength(0); i++)//Строки, где 0 - индекс строк
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)//Столбцы, где 1 - индекс столбцов
        {
            Console.Write(inputArray[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
//Заполняем матрицы с помощью метода  GetMatrix
int[,] rezultMatrix1 = GetMatrix(2, 2, 0, 10);
Console.WriteLine();
int[,] rezultMatrix2 = GetMatrix(2, 2, 0, 10);

// печатаем матрицу 
Console.WriteLine("Массив 1:" + "\t");
Console.WriteLine();
PrintMatrix(rezultMatrix1);
Console.WriteLine();
Console.WriteLine("Массив 2:" + "\t");
Console.WriteLine();
PrintMatrix(rezultMatrix2);

int rows = 2;
int cols = 2;
int[,] rezultMatrix3 = new int[rows, cols];//Создаем массив для хранения умноженных масивов
for (int i = 0; i < rows; i++)  // умножение
{
    for (int j = 0; j < cols; j++)
    {
        rezultMatrix3[i, j] = rezultMatrix1[i, j] * rezultMatrix2[i, j];
    }
}
Console.WriteLine();
Console.Write("Массив, полученный произведением двух массивов:" + "\t");
Console.WriteLine();
PrintMatrix(rezultMatrix3);
*/

/*    rezultMatrix3[1, 1] = (rezultMatrix1[1, 1] * rezultMatrix2[1, 1]) + (rezultMatrix1[1, 2] * rezultMatrix2[2, 1]);
    rezultMatrix3[1, 2] = (rezultMatrix1[1, 1] * rezultMatrix2[1, 2]) + (rezultMatrix1[1, 2] * rezultMatrix2[2, 2]);
    rezultMatrix3[2, 1] = (rezultMatrix1[2, 1] * rezultMatrix2[1, 1]) + (rezultMatrix1[2, 2] * rezultMatrix2[2, 1]);
    rezultMatrix3[2, 2] = (rezultMatrix1[2, 1] * rezultMatrix2[1, 2]) + (rezultMatrix1[2, 2] * rezultMatrix2[2, 2]);
int[,] rezultMatrix3*/


/*Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

int[,,] GetMatrix(int rows, int cols, int cols2, int min, int max)// Задаем метод для заполнения массива
{
    min = 10;
    max = 99;
    rows = cols = cols2 = 2;
    int[,,] Array = new int[rows, cols, cols2];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            for (int k = 0; k < cols2; k++)
            {
                Array[i, j, k] = min;
                min++;
            }
        }
    }
    return Array;
}

//Создаем метод распечатывания массивов

void PrintMatrix(int[,,] inputArray)
{
    for (int i = 0; i < inputArray.GetLength(0); i++)//Строки, где 0 - индекс строк
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)//Столбцы, где 1 - индекс столбцов
        {
            for (int k = 0; k < inputArray.GetLength(2); k++)
            {
                Console.Write(inputArray[i, j, k] + "\t" + (i, j, k) + "\t");
            }
            Console.WriteLine();
        }
    }
}

//Заполняем матрицы с помощью метода  GetMatrix
int[,,] rezultMatrix = GetMatrix(2, 2, 2, 10, 99);
Console.WriteLine();
PrintMatrix(rezultMatrix);
Console.WriteLine();


/*
ДОПОЛНИТЕЛЬНАЯ ЗАДАЧКА
Задача 62.Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/
