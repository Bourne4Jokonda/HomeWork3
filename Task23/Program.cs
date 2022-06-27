// *Задача 23: * Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27.
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int [] array=new int [N+1];
int i =1;

Console.Write($"Таблица кубов чисел {N}");
// for (int i =1; i<=N-1; i++)
// {
//     array[i-1]=i*i*i;
//     Console.Write($"\n => {array[i]}");
//}
while(i<=N)
{
    array[i]=i*i*i;
    Console.Write($"\n => {array[i]}");
    i++;

}
