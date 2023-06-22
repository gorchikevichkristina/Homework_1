//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

Console.Write("Введите первое число: "); //Приглашение пользователя ко вводу числа (вывод в терминал)
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: "); //Приглашение пользователя ко вводу числа (вывод в терминал)
int number2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число: "); //Приглашение пользователя ко вводу числа (вывод в терминал)
int number3 = Convert.ToInt32(Console.ReadLine());

int max = number1;

if (number2 > number1) max = number2;
if (number3 > number2) max = number3;

Console.Write(max);
