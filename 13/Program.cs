// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());
if(num<100){
    Console.WriteLine("третьей цифры нет");
}
else 
{
    int d = num / 100 ;
    while(d > 10)
    {
        d = d % 10 ;
    }
    Console.WriteLine(d);
}
