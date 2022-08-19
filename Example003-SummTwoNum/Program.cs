string input;
int a,b, result;

Console.WriteLine("Добро пожаловать в программу для сложения двух чисел!");
Console.Write("Введите первое число, либо нажмите r для использования генератора случайных чисел:");
input=Console.ReadLine();

if (input.ToUpper()=="R")
{
    a= new Random().Next(0, 100);
    Console.WriteLine("первое число сгенерировано случайно: {0:D}", a);
}
else
    a=Int32.Parse(input);
Console.Write("Введите второе число, либо нажмите r для использования генератора случайных чисел:");
input=Console.ReadLine();
if (input.ToUpper()=="R")
{
    b= new Random().Next(0, 100);
    Console.WriteLine("второе число сгенерировано случайно: {0:D}", b);
}
else
    b=Int32.Parse(input);
result=a+b;
Console.Write("Результат сложения чисел:");
Console.Write(result);