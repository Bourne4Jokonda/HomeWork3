// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.

// 14212 -> нет
// 23432 -> да
// 12821 -> да

Console.WriteLine("Введите пятизначное число ");
int number = Convert.ToInt32(Console.ReadLine());
string numberText = number.ToString();

if (numberText[0]==numberText[4] && numberText[1]==numberText[3]){
    Console.WriteLine($"Число {number} является палиндром");
}
else  Console.WriteLine($"Число {number} не является палиндром");