const int n=100;
int[]  x= new int[n];
int max=0;
int i=0;

Console.WriteLine("Инициализируем массив:");
for (; i<n; i++)
{
    if(i%10==0)
        Console.WriteLine();
    x[i]= new Random().Next(0, 100);
    Console.Write( x[i].ToString("00  "));
}
Console.WriteLine();
Console.WriteLine("Ищем максимум:");
max=x[0];
i=1;
while(i<n)
{
    if(x[i]>max)
        max=x[i];
    i++;     
}
Console.WriteLine("Максимум найден: {0:D}", max);


