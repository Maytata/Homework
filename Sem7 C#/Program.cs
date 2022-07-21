static void FillArray(double [,] array)
{
    Random random = new Random();
    int rows = array.GetLength(0);
    int colums = array.GetLength(1);
    for (int i = 0; i<rows; i++)
    {
      for (int j = 0; j < colums; j++)
      {
        array [i,j] = Math.Round(random.NextDouble() * 10, 1);
      }
    }
}

static void FillArray1(int [,] array)
{
    Random random = new Random();
    int rows = array.GetLength(0);
    int colums = array.GetLength(1);
    for (int i = 0; i<rows; i++)
    {
      for (int j = 0; j < colums; j++)
      {
        array [i,j] = random.Next(1,11);
      }
    }
}

static void PrintArray(double [,] array)
{
    Console.WriteLine();
    Console.WriteLine("Вывод массива");
    int rows = array.GetLength(0);
    int colums = array.GetLength(1);
    for (int i = 0; i<rows; i++)
    {
      for (int j = 0; j < colums; j++)
      {
        Console.Write(array[i,j] + "\t");
      }
    Console.WriteLine();
    }
Console.WriteLine();
}

static void PrintArray1(int [,] array)
{
    Console.WriteLine();
    Console.WriteLine("Вывод массива");
    int rows = array.GetLength(0);
    int colums = array.GetLength(1);
    for (int i = 0; i<rows; i++)
    {
      for (int j = 0; j < colums; j++)
      {
        Console.Write(array[i,j] + "\t");
      }
      Console.WriteLine();
    }
Console.WriteLine();
}



void Zad47()
{
Random random = new Random();
int rows = random.Next (1,6);
int colums = random.Next (1,6);

double[,] array = new double [rows,colums];
FillArray(array);
PrintArray(array);  
}
//Zad47();




void Zad50()
{
Random random = new Random();
int rows = random.Next (1,6);
int colums = random.Next (1,6);

int[,] array = new int[rows,colums];
FillArray1(array);
PrintArray1(array);

Console.WriteLine("введите строку искомого элемента");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите стобец искомого элемента");
int column = Convert.ToInt32(Console.ReadLine());
if (row >= 1 && row <= rows && column <=1 && column <= colums)
 {
   Console.WriteLine($"Искомый элемент array [{row},{column}] = {array [row-1, column-1]}");
 }
else
 {
 Console.WriteLine("Такого элемента нет");
 }
}
//Zad50();


void Zad52()
{
Random random = new Random();
int rows = random.Next (1,6);
int colums = random.Next (1,6);

int[,] array = new int[rows,colums];
FillArray1(array);
PrintArray1(array);
for (int j = 0; j < rows; j++)
 {
   int sum = 0;
   for (int i = 0; i < colums; i++)
   {
    sum += array[i,j];
   }
  Console.Write(sum/rows + "\t" );

 }
}

Zad52();