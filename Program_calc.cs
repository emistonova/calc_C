// See https://aka.ms/new-console-template for more information
char symbol;
double result = 0.0;
double a1 = 0.0;
double b1 = 0.0;
Console.WriteLine("Введите знак арифметического действия");
Console.WriteLine("\"*\" - операция умножения;");
Console.WriteLine("\"-\" - операция вычитания;");
Console.WriteLine("\"+\" - операция сложения;");
Console.WriteLine("\"/\" - операция деления;");
Console.Write("Знак операции (ожидание ввода с клавиатуры): "); 
symbol = Convert.ToChar(Console.ReadLine());
// Вводим первое число 
Console.Write("Введите первое число (ожидание ввода с клавиатуры) a1: ");
a1=Convert.ToDouble(Console.ReadLine());
// Вводим второе число 
Console.Write("Введите второе число (ожидание ввода с клавиатуры) b1: ");
b1 = Convert.ToDouble(Console.ReadLine());
//Вычисление примера 
if (symbol == '*')
{
    result = a1 * b1;
    Console.WriteLine($" a1 {symbol} b1 = {result}");
}
if (symbol == '-')
{
    result = a1 - b1;
    Console.WriteLine($" a1 {symbol} b1 = {result}");
}
if (symbol == '+')
{
    result = a1 + b1;
    Console.WriteLine($" a1 {symbol} b1 = {result}");
}
if (symbol == '/' & b1!=0)
  {
    result = a1 / b1;
    Console.WriteLine($" a1 {symbol} b1 = {result}");
}
else
{
    Console.WriteLine("На ноль делить нельзя");
}


