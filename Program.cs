//Домашняя работа к Семинару 1.
/*Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7, min = 5
a = 2 b = 10 -> max = 10, min = 2
*/
//Решение
Console.WriteLine ("Input your number_1:");
int number_1 = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("Input your number_2:");
int number_2 = Convert.ToInt32 (Console.ReadLine());
if (number_1 >number_2 )
{
    Console.WriteLine ($" max {number_1}, min {number_2}");
}
else
{
    Console.WriteLine ($" max {number_2}, min {number_1}");
}


/*Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/
// Решение
Console.WriteLine ("Input your number_1:");
int number_1 = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("Input your number_2:");
int number_2 = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("Input your number_3:");
int number_3 = Convert.ToInt32 (Console.ReadLine());

if (number_1>number_2)
{
    if (number_1>number_3)
    Console.WriteLine ($" max {number_1}");
}
 else
 {
    if (number_2>number_3)
    Console.WriteLine ($" max {number_2}");
    
        else
        {
          Console.WriteLine ($" max {number_3}");  
        }
    }

/*Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет
*/
Console.WriteLine ("Input your number:");
int number = Convert.ToInt32 (Console.ReadLine());
 if (number % 2== 0)
{
Console.WriteLine($" да "); 
}
else
{
Console.WriteLine($" нет "); 
}

/*Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8
*/
//Решение
Console.WriteLine ("Input your number N:");
int num = Convert.ToInt32 (Console.ReadLine());

int current_num= (num-num)+1;
while (current_num<= num) 
{
    if (current_num%2==0)
    Console.Write( current_num + " ");
          
        
     current_num++;
}

//Задачи на семинаре
/*int number = 26;

Console.WriteLine($" Привет! {number} да,да "); 
*/
// Задача 1. Напишите программу , которая на входе принимает число и выдает его квадрат
/*Console.WriteLine ("Input your number");
int number = Convert.ToInt32 (Console.ReadLine());
int result = number*number;

Console.WriteLine (result);
*/
//Задача 3. Напишите программу, которая на входе принимает два числа и проверяет, является ли первое число квадратом второго
/*Console.WriteLine ("Input your number_1");
int number_1 = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("Input your number_2");
int number_2 = Convert.ToInt32 (Console.ReadLine());
if (number_1 == number_2*number_2)// проверка на циклы
    Console.WriteLine ($" Число {number_1} является квадратом  числа {number_2}");
else
{
    Console.WriteLine ($" Число {number_1} не является квадратом  числа {number_2}");
}
*/
//Задача 5. Напишите программу, которая не входе прнимает одно число (N), а на выходе показывает
//все целые числа в промежутке от -N до N
/*Console.WriteLine ("Input your number N:");
int num = Convert.ToInt32 (Console.ReadLine());
int current_num=(-1)*num;
while (current_num<= num) 
{
    Console.Write( current_num + " ");// выводи текущее значение current_num
    current_num++;
}
*/
// Задача 7. Напишите программу, которая принимает на входе трехзначное число и на выходе показывает последнию
// цифру этого числа.
/*Console.WriteLine ("Input your number ");
int num = Convert.ToInt32 (Console.ReadLine());
if (num > 99 & num < 1000)
{
    int digit_3 = num % 10;
    Console.WriteLine ($"Your digit is {digit_3}");
}
else
{
    Console.WriteLine ("Not digit_3");
}
*/