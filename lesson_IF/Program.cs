//zadacha 1
//int a = Convert.ToInt32(Console.ReadLine());
//int b = Convert.ToInt32(Console.ReadLine());
//if (a != b)
//{
//    if (a > b)
//    {
//        b = a;
//    }
//    else
//    {
//        a = b;
//    }
//}
//else if (a == b)
//{
//    a = 0;
//    b = 0;
//}
//Console.WriteLine($"a={a} b={b}");

//zadacha 2
//Console.WriteLine("Введите первое число");
//int operand1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Введите второе число");
//int operand2 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Введите операцию");
//string? symbol = Console.ReadLine();
//double result = 0;
//switch (symbol)
//{
//    case "+":
//        result = operand1 + operand2;
        
//        break;
//    case "-":
//        result = operand1 - operand2;
//        break;
//    case "*":
//        result = operand1 * operand2;   
//        break;
//    case "/":
//        if (operand2 == 0)
//        {
//            Console.WriteLine("На ноль делить нельзя");
//        }
//        else
//        {
//            result = operand1 / operand2;
//        }
//        break;
//    default:
//        Console.WriteLine("Неизвестная операция");
//        break;
//}
//Console.WriteLine($" результат= { result}");


//zadacha 3
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
switch (number)
{
    case int n when (number >= 0 && number <= 14):

        Console.WriteLine("Число в диапазоне от 0 до 14");
        break;
}