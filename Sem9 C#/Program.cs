

void Zad64() //Задача 64: Задайте значения M и N. Напишите программу, 
             // которая выведет все натуральные числа в промежутке от M до N кратные трём.
{
 int numberFirst = 15;
 int numberSecond = 8;
 Recursion(numberFirst, numberSecond);
 Console.WriteLine();
 void Recursion(int numberFirst, int numbmerSecond)
 {
    if (numberSecond > numberFirst) return;
    else if (numberSecond%3==0)
    {
        Console.Write(numberSecond + " ");
    }
    numberSecond++;
    Recursion(numberFirst, numberSecond);
 }
}             
//Zad64();



void Zad66() //Задача 66: Задайте значения M и N. Напишите программу, 
             // которая выведет сумму натуральных чисел в промежутке от M до N.
{
 int numberFirst = 3;
 int numberSecond = 1;
 int sum = 0;
 Recursion(numberFirst, numberSecond);
 Console.WriteLine();

 void Recursion(int numberFirst, int numberSecond)
 {
    if (numberSecond > numberFirst) return;
    sum=sum + numberSecond;
    numberSecond++;
    Recursion(numberFirst, numberSecond);
 }
 Console.Write(sum);
}             
//Zad66();




void Zad68() //Аккреман
{
 int numM=3;
 int numN=2;
 int sum=0;
 Recursion(numM, numN);
 sum = Recursion(numM,numN);
 Console.WriteLine();
 
 int Recursion(int numM, int numN)
 {
    if (numM==0) return numN+1;
    else if (numN==0) return Recursion(numM-1, 1);
    else if (numM>0 && numN>0) return Recursion(numM-1, Recursion(numM,numN-1));
    else return 0;
 }
Console.WriteLine(sum);
}
Zad68();


