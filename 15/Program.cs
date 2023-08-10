// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());
if(num%6==0 || num%7==0){
    Console.WriteLine("да");
}
else 
{
    Console.WriteLine("нет");
}
